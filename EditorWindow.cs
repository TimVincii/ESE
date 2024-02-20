using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace ESE;

public partial class EditorWindow : Form
{
    private ConfigEditor editor;
    private string GameUserSettingsPath;
    public EditorWindow()
    {
        InitializeComponent();
    }

    /// <summary>
    /// An event-triggered method that's responsible for alerting the user in
    /// case they try to close ESE without saving their changes.
    /// </summary>
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
        SaveToConfigEditor(true);
        if (SaveNeeded())
        {
            if (Emb.MakeQuestionBox("You have unsaved changes, would you like to exit anyway?").Result() == DialogResult.No)
                e.Cancel = true;
        }
    }

    private void Main_Load(object sender, EventArgs e)
    {
        ;
        RenderingModeBox.Text = "Performance Mode";
        GameUserSettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FortniteGame\Saved\Config\WindowsClient\GameUserSettings.ini";
        editor = new ConfigEditor(GameUserSettingsPath);
        if (editor.GetConfigValue(KeyRegistry.keys[11]) != "es31")
        {
            Emb.MakeInfoBox("It seems your rendering mode isn't set to performance mode. As of now, ESE supports performance mode only.\nExiting...").Show();
            Environment.Exit(1);
        }
        CheckKeyValidity();
        CheckValuesValidity();
        if (ConfigFileIsReadOnly())
            ReadOnlyCheckbox.Checked = true;
    }

    /// <summary>
    /// A method that's responsible for checking the validity of all of the necessary keys
    /// in the Fortnite configuration file.
    /// </summary>
    /// <remarks>
    /// Fixes the following issue:
    /// When switching to windowed fullscreen in Fortnite, the "FullscreenMode" key is deleted from the configuration.
    /// This is a pain to deal with, and frankly I have no idea why the developers chose to do this.
    /// I decided to deal with it using the following way:
    /// Once ESE reads the configuration file into the List, it checks if the "FullscreenMode" key and only that is missing,
    /// if so, the key gets added to the List and to the Fortnite config.
    /// </remarks>
    private void CheckKeyValidity()
    {
        List<string> NotContained = KeyRegistry.keys.Where(key => !editor.Configuration.Any(keyandvalue => keyandvalue.StartsWith(key))).ToList();
        if (NotContained.Any())
        {
            if (NotContained.Count == 1 && NotContained[0] == KeyRegistry.keys[4])
            {
                int FirstEmptyLineIndex = editor.Configuration.FindIndex(line => string.IsNullOrWhiteSpace(line));
                if (FirstEmptyLineIndex == -1)
                {
                    Emb.MakeErrorBox("An empty line was not found in your Fortnite configuration, consider resetting your Fortnite settings.");
                    Environment.Exit(3);
                }
                editor.AddLineToConfig(FirstEmptyLineIndex, KeyRegistry.keys[4] + '=' + editor.GetConfigValue(KeyRegistry.keys[12]));
                editor.SaveConfigToFile(GameUserSettingsPath);
                return;
            }
            string KeyMissingMessage = "The following keys are necessary for ESE to function, and are missing from your Fortnite configuration file:\n\n";
            foreach (var key in NotContained)
            {
                KeyMissingMessage += key + ", ";
            }
            KeyMissingMessage += "\n\nIf you haven't played Fortnite in a while, updating and relaunching the game might fix this issue. Otherwise, consider resetting your Fortnite settings.";
            Emb.MakeErrorBox(KeyMissingMessage).Show();
            Environment.Exit(2);
        }
    }


    /// <summary>
    /// A method that's responsible for checking the values of necessary keys in the configuration.
    /// </summary>
    private void CheckValuesValidity()
    {
        string ValueErrorMessage = string.Empty;
        int[] IntegerValues = new int[KeyRegistry.IntegerKeys.Length];
        float[] FloatingValues = new float[KeyRegistry.FloatingKeys.Length];
        bool[] BooleanValues = new bool[KeyRegistry.BooleanKeys.Length];

        //Check integer values
        for (int i = 0; i < KeyRegistry.IntegerKeys.Length; i++)
            if (!int.TryParse(editor.GetConfigValue(KeyRegistry.IntegerKeys[i]), out int IntegerValue))
                ValueErrorMessage += KeyRegistry.IntegerKeys[i] + ", ";
            else
                IntegerValues[i] = IntegerValue;

        //Check floating values
        for (int i = 0; i < KeyRegistry.FloatingKeys.Length; i++)
            if (!float.TryParse(editor.GetConfigValue(KeyRegistry.FloatingKeys[i]), out float FloatingValue))
                ValueErrorMessage += KeyRegistry.FloatingKeys[i] + ", ";
            else
                FloatingValues[i] = FloatingValue;

        //Check boolean values
        for (int i = 0; i < KeyRegistry.BooleanKeys.Length; i++)
            if (!bool.TryParse(editor.GetConfigValue(KeyRegistry.BooleanKeys[i]), out bool BooleanValue))
                ValueErrorMessage = KeyRegistry.BooleanKeys[i] + ", ";
            else
                BooleanValues[i] = BooleanValue;

        if (ValueErrorMessage != string.Empty)
        {
            ValueErrorMessage = "The following keys are necessary for ESE to function, and their values are invalid:\n\n"
          + ValueErrorMessage + "\n\nRelaunching Fortnite should fix this issue.";
            Emb.MakeErrorBox(ValueErrorMessage).Show();
            Environment.Exit(4);
        }

        ApplyValuesToControls(IntegerValues, FloatingValues, BooleanValues);
    }

    /// <summary>
    /// A method that's responsible for applying the retrieved values to their respected controls
    /// on the EditorWindow.
    /// </summary>
    /// <param name="IntegerValues">Retrieved Integer values from CheckValuesValidity()</param>
    /// <param name="FloatingValues">Retrieved Floating values from CheckValuesValidity()</param>
    /// <param name="BooleanValues">Retrieved Boolean values from CheckValuesValidity()</param>
    private void ApplyValuesToControls(int[] IntegerValues, float[] FloatingValues, bool[] BooleanValues)
    {
        //Window Mode
        WindowModeBox.SelectedIndex = IntegerValues[2];

        //Resolution
        ResolutionBox.Text = IntegerValues[10].ToString() + 'x' + IntegerValues[11].ToString();

        //Vsync
        VsyncBox.SelectedIndex = BooleanValues[1] ? 1 : 0;

        //Frame Rate Limit
        if (FloatingValues[1] == 0)
            FrameRateBox.SelectedIndex = 0;
        else
            FrameRateBox.Text = FloatingValues[1].ToString();

        //Brightness
        BrightnessTrackBar.Value = (int)(50 + (FloatingValues[0] - 1.7f) * 100);
        BrightnessValueLabel.Text = "(" + BrightnessTrackBar.Value + ")";


        //Contrast
        ContrastTrackBar.Value = (int)(100 + (FloatingValues[2] - 1.0f) * 50 / 0.5f);
        ContrastValueLabel.Text = "(" + (ContrastTrackBar.Value / 100.0) + "x)";

        //3D Resolution
        ThreeDResolutionTrackBar.Value = IntegerValues[13];
        ThreeDResolutionValueLabel.Text = "(" + ThreeDResolutionTrackBar.Value + ")";

        //View Distance
        ViewDistanceBox.SelectedIndex = IntegerValues[15];

        //Textures
        TexturesBox.SelectedIndex = IntegerValues[14];

        //Meshes
        MeshesBox.SelectedIndex = IntegerValues[8];

        //Show FPS
        ShowFpsBox.SelectedIndex = BooleanValues[0] ? 1 : 0;
    }

    /// <summary>
    /// A method that's responsible for checking whether the Fortnite configuration file is read only or not.
    /// </summary>
    /// <returns>True if the file is read only, false otherwise.</returns>
    private bool ConfigFileIsReadOnly()
    {
        FileAttributes GameUserSettingsAttributes = File.GetAttributes(GameUserSettingsPath);
        return (GameUserSettingsAttributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;
    }


    /// <summary>
    /// A method that's responsible for disabling the read only property on the Fortnite configuration file.
    /// </summary>
    private void DisableReadOnly()
    {
        FileAttributes GameUserSettingsAttributes = File.GetAttributes(GameUserSettingsPath);
        GameUserSettingsAttributes &= ~FileAttributes.ReadOnly;
        File.SetAttributes(GameUserSettingsPath, GameUserSettingsAttributes);
    }

    /// <summary>
    /// A method that's responsible for enabling the read only property on the Fortnite configuration file.
    /// </summary>
    private void EnableReadOnly()
    {
        FileAttributes GameUserSettingsAttributes = File.GetAttributes(GameUserSettingsPath);
        GameUserSettingsAttributes |= FileAttributes.ReadOnly;
        File.SetAttributes(GameUserSettingsPath, GameUserSettingsAttributes);
    }

    /// <summary>
    /// An event-triggered method that's responsible for processing the click of the save button.
    /// If the settings were modified, saves them to the real Fortnite configuration file.
    /// </summary>
    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (!SaveToConfigEditor(false))
            return;

        if (!SaveNeeded())
        {
            Emb.MakeInfoBox("No changes were made.").Show();
            return;
        }

        if (Emb.MakeQuestionBox("Are you sure you want to save the current settings? please note that this action is not reversable.").Result() == DialogResult.No)
            return;

        bool ReenableReadOnly = false;
        if (ConfigFileIsReadOnly())
        {
            if (ReadOnlyCheckbox.Checked)
                ReenableReadOnly = true;
            DisableReadOnly();
        }
        else if (ReadOnlyCheckbox.Checked)
            ReenableReadOnly = true;

        editor.SaveConfigToFile(GameUserSettingsPath);

        if (ReenableReadOnly)
            EnableReadOnly();

        Emb.MakeInfoBox("Your changes were succesfully saved!").Show();
    }

    /// <summary>
    /// A method that's responsible for saving the selected settings to the config editor.
    /// </summary>
    /// <returns>True if the saving process was succesfully completed, false otherwise.</returns>
    private bool SaveToConfigEditor(bool DuringExit)
    {
        string[] ResolutionDimensions = ResolutionBox.Text.Replace(" ", string.Empty).Split("x");
        if (ResolutionDimensions.Length != 2 || !int.TryParse(ResolutionDimensions[0], out int IntWidth) || !int.TryParse(ResolutionDimensions[1], out int IntHeight))
        {
            if (!DuringExit)
                Emb.MakeInfoBox("The resolution you've inputted seems to be invalid, please check up on it and try again.").Show();
            return false;
        }

        if (!float.TryParse(FrameRateBox.Text, out float FloatFrameRateLimit) && FrameRateBox.SelectedIndex != 0)
        {
            if (!DuringExit)
                Emb.MakeInfoBox("The frame rate limit you've inputted seems to be invalid, please check up on it and try again.").Show();
            return false;
        }

        //Window Mode
        editor.SetConfigValue(KeyRegistry.keys[4], WindowModeBox.SelectedIndex.ToString());
        editor.SetConfigValue(KeyRegistry.keys[5], WindowModeBox.SelectedIndex.ToString());
        editor.SetConfigValue(KeyRegistry.keys[12], WindowModeBox.SelectedIndex.ToString());

        //Resolution
        editor.SetConfigValue(KeyRegistry.keys[0], IntHeight.ToString());
        editor.SetConfigValue(KeyRegistry.keys[1], IntWidth.ToString());
        editor.SetConfigValue(KeyRegistry.keys[6], IntHeight.ToString());
        editor.SetConfigValue(KeyRegistry.keys[7], IntWidth.ToString());
        editor.SetConfigValue(KeyRegistry.keys[8], IntWidth.ToString());
        editor.SetConfigValue(KeyRegistry.keys[9], IntHeight.ToString());
        editor.SetConfigValue(KeyRegistry.keys[13], IntWidth.ToString());
        editor.SetConfigValue(KeyRegistry.keys[14], IntHeight.ToString());

        //Vsync
        if (VsyncBox.SelectedIndex == 0)
            editor.SetConfigValue(KeyRegistry.keys[17], "False");
        else
            editor.SetConfigValue(KeyRegistry.keys[17], "True");

        //Frame Rate Limit
        if (FrameRateBox.SelectedIndex == 0)
            editor.SetConfigValue(KeyRegistry.keys[3], "0.00000");
        else
            editor.SetConfigValue(KeyRegistry.keys[3], FloatFrameRateLimit.ToString("F6"));

        //Brightness
        float FloatDisplayGamma = 1.7f + (BrightnessTrackBar.Value - 50) * 0.01f * 1.0f;
        editor.SetConfigValue(KeyRegistry.keys[2], FloatDisplayGamma.ToString("F6"));

        //Contrast
        float FloatUserInterfaceContrast = 1f + (ContrastTrackBar.Value - 100) * 0.5f / 50;
        editor.SetConfigValue(KeyRegistry.keys[15], FloatUserInterfaceContrast.ToString("F6"));

        //3D Resolution
        editor.SetConfigValue(KeyRegistry.keys[19], ThreeDResolutionTrackBar.Value.ToString());

        //View Distance
        editor.SetConfigValue(KeyRegistry.keys[21], ViewDistanceBox.SelectedIndex.ToString());
        editor.SetConfigValue(KeyRegistry.keys[18], ViewDistanceBox.SelectedIndex.ToString());

        //Textures
        editor.SetConfigValue(KeyRegistry.keys[20], TexturesBox.SelectedIndex.ToString());

        //Meshes
        editor.SetConfigValue(KeyRegistry.keys[10], MeshesBox.SelectedIndex.ToString());

        //Show FPS
        if (ShowFpsBox.SelectedIndex == 0)
            editor.SetConfigValue(KeyRegistry.keys[16], "False");
        else
            editor.SetConfigValue(KeyRegistry.keys[16], "True");

        return true;
    }

    /// <summary>
    /// An event-triggered method that's responsible for processing the click of the revert button.
    /// </summary>
    private void RevertButton_Click(object sender, EventArgs e)
    {
        CheckKeyValidity();
        CheckValuesValidity();
        if (ConfigFileIsReadOnly())
            ReadOnlyCheckbox.Checked = true;
        else
            ReadOnlyCheckbox.Checked = false;
    }

    /// <summary>
    /// A method that's responsible for comparing the current config to
    /// the Fortnite configuration file and finding if a difference exists.
    /// Additionaly, a save is indeed needed incase the read only checkbox was toggled.
    /// </summary>
    /// <returns>True if a difference exists, false otherwise.</returns>
    private bool SaveNeeded()
    {
        List<string> configuration = File.ReadAllLines(GameUserSettingsPath).ToList();
        return !editor.Configuration.SequenceEqual(configuration) || ReadOnlyCheckbox.Checked != ConfigFileIsReadOnly();
    }

    /// <summary>
    /// An event-triggered method that's responsible for fixing a visual issue occuring with
    /// a combo box that has a DropDownStyle of Droplist.
    /// Moves the caret to the end of the selected index text.
    /// </summary>
    /// <remarks>
    /// Called by any combo box with the DropDownStyle of DropList.
    /// </remarks>
    private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        ComboBox Sender = (ComboBox)sender;
        BeginInvoke(new Action(() => Sender.Select(Sender.Text.Length, 0)));

    }

    /// <summary>
    /// An event-triggered method that's responsible for updating the brightness label 
    /// whenever the brightness trackbar is scrolled.
    /// </summary>
    private void BrightnessTrackBar_Scroll(object sender, EventArgs e)
    {
        BrightnessValueLabel.Text = "(" + BrightnessTrackBar.Value + ")";
    }

    /// <summary>
    /// An event-triggered method that's responsible for updating the contrast label 
    /// whenever the contrast trackbar is scrolled.
    /// </summary>
    private void ContrastTrackBar_Scroll(object sender, EventArgs e)
    {
        ContrastValueLabel.Text = "(" + (ContrastTrackBar.Value / 100.0) + "x)";
    }

    /// <summary>
    /// An event-triggered method that's responsible for updating the 3d resolution label 
    /// whenever the 3d resolution trackbar is scrolled.
    /// </summary>
    private void ThreeDResolutionTrackBar_Scroll(object sender, EventArgs e)
    {
        ThreeDResolutionValueLabel.Text = "(" + ThreeDResolutionTrackBar.Value + ")";
    }

    private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var psi = new ProcessStartInfo
        {
            FileName = "https://github.com/TimVincii/ESE/releases",
            UseShellExecute = true
        };
        Process.Start(psi);
    }
}
