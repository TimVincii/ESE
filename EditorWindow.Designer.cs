namespace ESE;

partial class EditorWindow
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorWindow));
        TitleDisplay = new Label();
        WindowModeLabel = new Label();
        WindowModeBox = new ComboBox();
        ResolutionLabel = new Label();
        ResolutionBox = new ComboBox();
        VsyncLabel = new Label();
        VsyncBox = new ComboBox();
        label1 = new Label();
        FrameRateBox = new ComboBox();
        RenderingModeLabel = new Label();
        RenderingModeBox = new ComboBox();
        Tooltip = new ToolTip(components);
        ReadOnlyCheckbox = new CheckBox();
        RevertButton = new Button();
        LinkLabel = new LinkLabel();
        TitleGraphics = new Label();
        BrightnessLabel = new Label();
        BrightnessTrackBar = new TrackBar();
        ContrastLabel = new Label();
        ContrastTrackBar = new TrackBar();
        TitleGraphicsQuality = new Label();
        ThreeDResolutionLabel = new Label();
        ThreeDResolutionTrackBar = new TrackBar();
        ViewDistanceLabel = new Label();
        ViewDistanceBox = new ComboBox();
        TexturesLabel = new Label();
        TexturesBox = new ComboBox();
        MeshesLabel = new Label();
        MeshesBox = new ComboBox();
        TitleAdvancedGraphics = new Label();
        ShowFpsLabel = new Label();
        ShowFpsBox = new ComboBox();
        SaveButton = new Button();
        BrightnessValueLabel = new Label();
        ContrastValueLabel = new Label();
        ThreeDResolutionValueLabel = new Label();
        VersionLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)BrightnessTrackBar).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ContrastTrackBar).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ThreeDResolutionTrackBar).BeginInit();
        SuspendLayout();
        // 
        // TitleDisplay
        // 
        TitleDisplay.AutoSize = true;
        TitleDisplay.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        TitleDisplay.ForeColor = Color.White;
        TitleDisplay.Location = new Point(12, 8);
        TitleDisplay.Name = "TitleDisplay";
        TitleDisplay.Size = new Size(127, 37);
        TitleDisplay.TabIndex = 0;
        TitleDisplay.Text = "DISPLAY";
        // 
        // WindowModeLabel
        // 
        WindowModeLabel.AutoSize = true;
        WindowModeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        WindowModeLabel.ForeColor = Color.White;
        WindowModeLabel.Location = new Point(17, 56);
        WindowModeLabel.Name = "WindowModeLabel";
        WindowModeLabel.Size = new Size(122, 21);
        WindowModeLabel.TabIndex = 1;
        WindowModeLabel.Text = "Window Mode";
        // 
        // WindowModeBox
        // 
        WindowModeBox.BackColor = Color.White;
        WindowModeBox.DropDownStyle = ComboBoxStyle.DropDownList;
        WindowModeBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        WindowModeBox.ForeColor = Color.Black;
        WindowModeBox.FormattingEnabled = true;
        WindowModeBox.ItemHeight = 13;
        WindowModeBox.Items.AddRange(new object[] { "Fullscreen", "Windowed Fullscreen", "Windowed" });
        WindowModeBox.Location = new Point(260, 56);
        WindowModeBox.Name = "WindowModeBox";
        WindowModeBox.Size = new Size(168, 21);
        WindowModeBox.TabIndex = 2;
        // 
        // ResolutionLabel
        // 
        ResolutionLabel.AutoSize = true;
        ResolutionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        ResolutionLabel.ForeColor = Color.White;
        ResolutionLabel.Location = new Point(17, 80);
        ResolutionLabel.Name = "ResolutionLabel";
        ResolutionLabel.Size = new Size(92, 21);
        ResolutionLabel.TabIndex = 3;
        ResolutionLabel.Text = "Resolution";
        // 
        // ResolutionBox
        // 
        ResolutionBox.BackColor = Color.White;
        ResolutionBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        ResolutionBox.ForeColor = Color.Black;
        ResolutionBox.FormattingEnabled = true;
        ResolutionBox.ItemHeight = 13;
        ResolutionBox.Items.AddRange(new object[] { "3840x2160", "2560x1440", "1920x1080", "1811x1070", "1720x1080", "1680x1050", "1550x1080", "1280x720", "1024x768", "936x648", "800x600" });
        ResolutionBox.Location = new Point(260, 80);
        ResolutionBox.Name = "ResolutionBox";
        ResolutionBox.Size = new Size(168, 21);
        ResolutionBox.TabIndex = 4;
        ResolutionBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
        // 
        // VsyncLabel
        // 
        VsyncLabel.AutoSize = true;
        VsyncLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        VsyncLabel.ForeColor = Color.White;
        VsyncLabel.Location = new Point(17, 104);
        VsyncLabel.Name = "VsyncLabel";
        VsyncLabel.Size = new Size(54, 21);
        VsyncLabel.TabIndex = 5;
        VsyncLabel.Text = "Vsync";
        // 
        // VsyncBox
        // 
        VsyncBox.BackColor = Color.White;
        VsyncBox.DropDownStyle = ComboBoxStyle.DropDownList;
        VsyncBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        VsyncBox.ForeColor = Color.Black;
        VsyncBox.FormattingEnabled = true;
        VsyncBox.ItemHeight = 13;
        VsyncBox.Items.AddRange(new object[] { "Off", "On" });
        VsyncBox.Location = new Point(260, 104);
        VsyncBox.Name = "VsyncBox";
        VsyncBox.Size = new Size(168, 21);
        VsyncBox.TabIndex = 6;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = Color.White;
        label1.Location = new Point(17, 128);
        label1.Name = "label1";
        label1.Size = new Size(138, 21);
        label1.TabIndex = 7;
        label1.Text = "Frame Rate Limit";
        // 
        // FrameRateBox
        // 
        FrameRateBox.BackColor = Color.White;
        FrameRateBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        FrameRateBox.ForeColor = Color.Black;
        FrameRateBox.FormattingEnabled = true;
        FrameRateBox.ItemHeight = 13;
        FrameRateBox.Items.AddRange(new object[] { "Unlimited", "360", "240", "200", "180", "165", "160", "144", "120", "60", "30" });
        FrameRateBox.Location = new Point(260, 128);
        FrameRateBox.Name = "FrameRateBox";
        FrameRateBox.Size = new Size(168, 21);
        FrameRateBox.TabIndex = 8;
        FrameRateBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
        // 
        // RenderingModeLabel
        // 
        RenderingModeLabel.AutoSize = true;
        RenderingModeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        RenderingModeLabel.ForeColor = Color.Gray;
        RenderingModeLabel.Location = new Point(17, 152);
        RenderingModeLabel.Name = "RenderingModeLabel";
        RenderingModeLabel.Size = new Size(137, 21);
        RenderingModeLabel.TabIndex = 9;
        RenderingModeLabel.Text = "Rendering Mode";
        Tooltip.SetToolTip(RenderingModeLabel, "To be implemented.");
        // 
        // RenderingModeBox
        // 
        RenderingModeBox.BackColor = Color.White;
        RenderingModeBox.DropDownStyle = ComboBoxStyle.DropDownList;
        RenderingModeBox.Enabled = false;
        RenderingModeBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        RenderingModeBox.ForeColor = Color.Black;
        RenderingModeBox.FormattingEnabled = true;
        RenderingModeBox.ItemHeight = 13;
        RenderingModeBox.Items.AddRange(new object[] { "DirectX 11", "Performance Mode", "DirectX 12" });
        RenderingModeBox.Location = new Point(260, 152);
        RenderingModeBox.Name = "RenderingModeBox";
        RenderingModeBox.Size = new Size(168, 21);
        RenderingModeBox.TabIndex = 10;
        // 
        // Tooltip
        // 
        Tooltip.AutoPopDelay = 5000;
        Tooltip.InitialDelay = 250;
        Tooltip.ReshowDelay = 100;
        // 
        // ReadOnlyCheckbox
        // 
        ReadOnlyCheckbox.AutoSize = true;
        ReadOnlyCheckbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        ReadOnlyCheckbox.ForeColor = Color.White;
        ReadOnlyCheckbox.Location = new Point(12, 544);
        ReadOnlyCheckbox.Name = "ReadOnlyCheckbox";
        ReadOnlyCheckbox.Size = new Size(99, 24);
        ReadOnlyCheckbox.TabIndex = 37;
        ReadOnlyCheckbox.Text = "Read Only";
        Tooltip.SetToolTip(ReadOnlyCheckbox, resources.GetString("ReadOnlyCheckbox.ToolTip"));
        ReadOnlyCheckbox.UseVisualStyleBackColor = true;
        // 
        // RevertButton
        // 
        RevertButton.BackColor = Color.FromArgb(25, 25, 25);
        RevertButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        RevertButton.ForeColor = Color.White;
        RevertButton.Location = new Point(369, 534);
        RevertButton.Name = "RevertButton";
        RevertButton.Size = new Size(59, 34);
        RevertButton.TabIndex = 38;
        RevertButton.Text = "Revert";
        Tooltip.SetToolTip(RevertButton, "If you've made any changes without saving, and would like to revert\r\nthe state of the settings displayed here back to your original Fortnite settings, click here.");
        RevertButton.UseVisualStyleBackColor = false;
        RevertButton.Click += RevertButton_Click;
        // 
        // LinkLabel
        // 
        LinkLabel.ActiveLinkColor = Color.RoyalBlue;
        LinkLabel.AutoSize = true;
        LinkLabel.LinkColor = SystemColors.Highlight;
        LinkLabel.Location = new Point(325, 26);
        LinkLabel.Name = "LinkLabel";
        LinkLabel.Size = new Size(103, 15);
        LinkLabel.TabIndex = 43;
        LinkLabel.TabStop = true;
        LinkLabel.Text = "Check for updates";
        Tooltip.SetToolTip(LinkLabel, "https://github.com/TimVincii/ESE/releases");
        LinkLabel.LinkClicked += LinkLabel_LinkClicked;
        // 
        // TitleGraphics
        // 
        TitleGraphics.AutoSize = true;
        TitleGraphics.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        TitleGraphics.ForeColor = Color.White;
        TitleGraphics.Location = new Point(12, 181);
        TitleGraphics.Name = "TitleGraphics";
        TitleGraphics.Size = new Size(151, 37);
        TitleGraphics.TabIndex = 11;
        TitleGraphics.Text = "GRAPHICS";
        // 
        // BrightnessLabel
        // 
        BrightnessLabel.AutoSize = true;
        BrightnessLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        BrightnessLabel.ForeColor = Color.White;
        BrightnessLabel.Location = new Point(17, 229);
        BrightnessLabel.Name = "BrightnessLabel";
        BrightnessLabel.Size = new Size(90, 21);
        BrightnessLabel.TabIndex = 12;
        BrightnessLabel.Text = "Brightness";
        // 
        // BrightnessTrackBar
        // 
        BrightnessTrackBar.AutoSize = false;
        BrightnessTrackBar.LargeChange = 20;
        BrightnessTrackBar.Location = new Point(260, 229);
        BrightnessTrackBar.Maximum = 150;
        BrightnessTrackBar.Minimum = 50;
        BrightnessTrackBar.Name = "BrightnessTrackBar";
        BrightnessTrackBar.Size = new Size(168, 21);
        BrightnessTrackBar.TabIndex = 13;
        BrightnessTrackBar.TickStyle = TickStyle.None;
        BrightnessTrackBar.Value = 50;
        BrightnessTrackBar.Scroll += BrightnessTrackBar_Scroll;
        // 
        // ContrastLabel
        // 
        ContrastLabel.AutoSize = true;
        ContrastLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        ContrastLabel.ForeColor = Color.White;
        ContrastLabel.Location = new Point(17, 253);
        ContrastLabel.Name = "ContrastLabel";
        ContrastLabel.Size = new Size(74, 21);
        ContrastLabel.TabIndex = 14;
        ContrastLabel.Text = "Contrast";
        // 
        // ContrastTrackBar
        // 
        ContrastTrackBar.AutoSize = false;
        ContrastTrackBar.LargeChange = 10;
        ContrastTrackBar.Location = new Point(260, 253);
        ContrastTrackBar.Maximum = 150;
        ContrastTrackBar.Minimum = 100;
        ContrastTrackBar.Name = "ContrastTrackBar";
        ContrastTrackBar.Size = new Size(168, 21);
        ContrastTrackBar.TabIndex = 15;
        ContrastTrackBar.TickStyle = TickStyle.None;
        ContrastTrackBar.Value = 100;
        ContrastTrackBar.Scroll += ContrastTrackBar_Scroll;
        // 
        // TitleGraphicsQuality
        // 
        TitleGraphicsQuality.AutoSize = true;
        TitleGraphicsQuality.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        TitleGraphicsQuality.ForeColor = Color.White;
        TitleGraphicsQuality.Location = new Point(12, 282);
        TitleGraphicsQuality.Name = "TitleGraphicsQuality";
        TitleGraphicsQuality.Size = new Size(272, 37);
        TitleGraphicsQuality.TabIndex = 20;
        TitleGraphicsQuality.Text = "GRAPHICS QUALITY";
        // 
        // ThreeDResolutionLabel
        // 
        ThreeDResolutionLabel.AutoSize = true;
        ThreeDResolutionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        ThreeDResolutionLabel.ForeColor = Color.White;
        ThreeDResolutionLabel.Location = new Point(17, 330);
        ThreeDResolutionLabel.Name = "ThreeDResolutionLabel";
        ThreeDResolutionLabel.Size = new Size(117, 21);
        ThreeDResolutionLabel.TabIndex = 21;
        ThreeDResolutionLabel.Text = "3D Resolution";
        // 
        // ThreeDResolutionTrackBar
        // 
        ThreeDResolutionTrackBar.AutoSize = false;
        ThreeDResolutionTrackBar.LargeChange = 20;
        ThreeDResolutionTrackBar.Location = new Point(260, 330);
        ThreeDResolutionTrackBar.Maximum = 100;
        ThreeDResolutionTrackBar.Name = "ThreeDResolutionTrackBar";
        ThreeDResolutionTrackBar.Size = new Size(168, 21);
        ThreeDResolutionTrackBar.TabIndex = 22;
        ThreeDResolutionTrackBar.TickStyle = TickStyle.None;
        ThreeDResolutionTrackBar.Scroll += ThreeDResolutionTrackBar_Scroll;
        // 
        // ViewDistanceLabel
        // 
        ViewDistanceLabel.AutoSize = true;
        ViewDistanceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        ViewDistanceLabel.ForeColor = Color.White;
        ViewDistanceLabel.Location = new Point(17, 354);
        ViewDistanceLabel.Name = "ViewDistanceLabel";
        ViewDistanceLabel.Size = new Size(118, 21);
        ViewDistanceLabel.TabIndex = 25;
        ViewDistanceLabel.Text = "View Distance";
        // 
        // ViewDistanceBox
        // 
        ViewDistanceBox.BackColor = Color.White;
        ViewDistanceBox.DropDownStyle = ComboBoxStyle.DropDownList;
        ViewDistanceBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        ViewDistanceBox.ForeColor = Color.Black;
        ViewDistanceBox.FormattingEnabled = true;
        ViewDistanceBox.ItemHeight = 13;
        ViewDistanceBox.Items.AddRange(new object[] { "Near", "Medium", "Far", "Epic" });
        ViewDistanceBox.Location = new Point(260, 354);
        ViewDistanceBox.Name = "ViewDistanceBox";
        ViewDistanceBox.Size = new Size(168, 21);
        ViewDistanceBox.TabIndex = 26;
        // 
        // TexturesLabel
        // 
        TexturesLabel.AutoSize = true;
        TexturesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        TexturesLabel.ForeColor = Color.White;
        TexturesLabel.Location = new Point(17, 378);
        TexturesLabel.Name = "TexturesLabel";
        TexturesLabel.Size = new Size(74, 21);
        TexturesLabel.TabIndex = 27;
        TexturesLabel.Text = "Textures";
        // 
        // TexturesBox
        // 
        TexturesBox.BackColor = Color.White;
        TexturesBox.DropDownStyle = ComboBoxStyle.DropDownList;
        TexturesBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        TexturesBox.ForeColor = Color.Black;
        TexturesBox.FormattingEnabled = true;
        TexturesBox.ItemHeight = 13;
        TexturesBox.Items.AddRange(new object[] { "Low", "Medium", "High", "Epic" });
        TexturesBox.Location = new Point(260, 378);
        TexturesBox.Name = "TexturesBox";
        TexturesBox.Size = new Size(168, 21);
        TexturesBox.TabIndex = 28;
        // 
        // MeshesLabel
        // 
        MeshesLabel.AutoSize = true;
        MeshesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        MeshesLabel.ForeColor = Color.White;
        MeshesLabel.Location = new Point(17, 402);
        MeshesLabel.Name = "MeshesLabel";
        MeshesLabel.Size = new Size(67, 21);
        MeshesLabel.TabIndex = 29;
        MeshesLabel.Text = "Meshes";
        // 
        // MeshesBox
        // 
        MeshesBox.BackColor = Color.White;
        MeshesBox.DropDownStyle = ComboBoxStyle.DropDownList;
        MeshesBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        MeshesBox.ForeColor = Color.Black;
        MeshesBox.FormattingEnabled = true;
        MeshesBox.ItemHeight = 13;
        MeshesBox.Items.AddRange(new object[] { "Low", "High" });
        MeshesBox.Location = new Point(260, 402);
        MeshesBox.Name = "MeshesBox";
        MeshesBox.Size = new Size(168, 21);
        MeshesBox.TabIndex = 30;
        // 
        // TitleAdvancedGraphics
        // 
        TitleAdvancedGraphics.AutoSize = true;
        TitleAdvancedGraphics.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        TitleAdvancedGraphics.ForeColor = Color.White;
        TitleAdvancedGraphics.Location = new Point(12, 431);
        TitleAdvancedGraphics.Name = "TitleAdvancedGraphics";
        TitleAdvancedGraphics.Size = new Size(307, 37);
        TitleAdvancedGraphics.TabIndex = 31;
        TitleAdvancedGraphics.Text = "ADVANCED GRAPHICS";
        // 
        // ShowFpsLabel
        // 
        ShowFpsLabel.AutoSize = true;
        ShowFpsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        ShowFpsLabel.ForeColor = Color.White;
        ShowFpsLabel.Location = new Point(17, 479);
        ShowFpsLabel.Name = "ShowFpsLabel";
        ShowFpsLabel.Size = new Size(83, 21);
        ShowFpsLabel.TabIndex = 32;
        ShowFpsLabel.Text = "Show FPS";
        // 
        // ShowFpsBox
        // 
        ShowFpsBox.BackColor = Color.White;
        ShowFpsBox.DropDownStyle = ComboBoxStyle.DropDownList;
        ShowFpsBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        ShowFpsBox.ForeColor = Color.Black;
        ShowFpsBox.FormattingEnabled = true;
        ShowFpsBox.ItemHeight = 13;
        ShowFpsBox.Items.AddRange(new object[] { "Off", "On" });
        ShowFpsBox.Location = new Point(260, 479);
        ShowFpsBox.Name = "ShowFpsBox";
        ShowFpsBox.Size = new Size(168, 21);
        ShowFpsBox.TabIndex = 33;
        // 
        // SaveButton
        // 
        SaveButton.BackColor = Color.FromArgb(25, 25, 25);
        SaveButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        SaveButton.ForeColor = Color.White;
        SaveButton.Location = new Point(173, 534);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(94, 34);
        SaveButton.TabIndex = 36;
        SaveButton.Text = "Save";
        SaveButton.UseVisualStyleBackColor = false;
        SaveButton.Click += SaveButton_Click;
        // 
        // BrightnessValueLabel
        // 
        BrightnessValueLabel.AutoSize = true;
        BrightnessValueLabel.BackColor = Color.Transparent;
        BrightnessValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        BrightnessValueLabel.ForeColor = SystemColors.Highlight;
        BrightnessValueLabel.Location = new Point(101, 229);
        BrightnessValueLabel.Name = "BrightnessValueLabel";
        BrightnessValueLabel.Size = new Size(31, 21);
        BrightnessValueLabel.TabIndex = 39;
        BrightnessValueLabel.Text = "(0)";
        // 
        // ContrastValueLabel
        // 
        ContrastValueLabel.AutoSize = true;
        ContrastValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        ContrastValueLabel.ForeColor = SystemColors.Highlight;
        ContrastValueLabel.Location = new Point(85, 253);
        ContrastValueLabel.Name = "ContrastValueLabel";
        ContrastValueLabel.Size = new Size(40, 21);
        ContrastValueLabel.TabIndex = 40;
        ContrastValueLabel.Text = "(1x)";
        // 
        // ThreeDResolutionValueLabel
        // 
        ThreeDResolutionValueLabel.AutoSize = true;
        ThreeDResolutionValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        ThreeDResolutionValueLabel.ForeColor = SystemColors.Highlight;
        ThreeDResolutionValueLabel.Location = new Point(128, 330);
        ThreeDResolutionValueLabel.Name = "ThreeDResolutionValueLabel";
        ThreeDResolutionValueLabel.Size = new Size(31, 21);
        ThreeDResolutionValueLabel.TabIndex = 41;
        ThreeDResolutionValueLabel.Text = "(0)";
        // 
        // VersionLabel
        // 
        VersionLabel.AutoSize = true;
        VersionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        VersionLabel.ForeColor = Color.White;
        VersionLabel.Location = new Point(351, 8);
        VersionLabel.Name = "VersionLabel";
        VersionLabel.Size = new Size(52, 15);
        VersionLabel.TabIndex = 42;
        VersionLabel.Text = "ESE V1.0";
        // 
        // EditorWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(25, 25, 25);
        ClientSize = new Size(440, 576);
        Controls.Add(LinkLabel);
        Controls.Add(VersionLabel);
        Controls.Add(ThreeDResolutionValueLabel);
        Controls.Add(ContrastValueLabel);
        Controls.Add(BrightnessValueLabel);
        Controls.Add(RevertButton);
        Controls.Add(ReadOnlyCheckbox);
        Controls.Add(SaveButton);
        Controls.Add(ShowFpsBox);
        Controls.Add(ShowFpsLabel);
        Controls.Add(TitleAdvancedGraphics);
        Controls.Add(MeshesBox);
        Controls.Add(MeshesLabel);
        Controls.Add(TexturesBox);
        Controls.Add(TexturesLabel);
        Controls.Add(ViewDistanceBox);
        Controls.Add(ViewDistanceLabel);
        Controls.Add(ThreeDResolutionTrackBar);
        Controls.Add(ThreeDResolutionLabel);
        Controls.Add(TitleGraphicsQuality);
        Controls.Add(ContrastTrackBar);
        Controls.Add(ContrastLabel);
        Controls.Add(BrightnessTrackBar);
        Controls.Add(BrightnessLabel);
        Controls.Add(TitleGraphics);
        Controls.Add(RenderingModeBox);
        Controls.Add(RenderingModeLabel);
        Controls.Add(FrameRateBox);
        Controls.Add(label1);
        Controls.Add(VsyncBox);
        Controls.Add(VsyncLabel);
        Controls.Add(ResolutionBox);
        Controls.Add(ResolutionLabel);
        Controls.Add(WindowModeBox);
        Controls.Add(WindowModeLabel);
        Controls.Add(TitleDisplay);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        KeyPreview = true;
        MaximizeBox = false;
        Name = "EditorWindow";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ESE";
        Load += Main_Load;
        ((System.ComponentModel.ISupportInitialize)BrightnessTrackBar).EndInit();
        ((System.ComponentModel.ISupportInitialize)ContrastTrackBar).EndInit();
        ((System.ComponentModel.ISupportInitialize)ThreeDResolutionTrackBar).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label TitleDisplay;
    private Label WindowModeLabel;
    private ComboBox WindowModeBox;
    private Label ResolutionLabel;
    private ComboBox ResolutionBox;
    private Label VsyncLabel;
    private ComboBox VsyncBox;
    private Label label1;
    private ComboBox FrameRateBox;
    private Label RenderingModeLabel;
    private ComboBox RenderingModeBox;
    private ToolTip Tooltip;
    private Label TitleGraphics;
    private Label BrightnessLabel;
    private TrackBar BrightnessTrackBar;
    private Label ContrastLabel;
    private TrackBar ContrastTrackBar;
    private Label TitleGraphicsQuality;
    private Label ThreeDResolutionLabel;
    private TrackBar ThreeDResolutionTrackBar;
    private Label ViewDistanceLabel;
    private ComboBox ViewDistanceBox;
    private Label TexturesLabel;
    private ComboBox TexturesBox;
    private Label MeshesLabel;
    private ComboBox MeshesBox;
    private Label TitleAdvancedGraphics;
    private Label ShowFpsLabel;
    private ComboBox ShowFpsBox;
    private Button SaveButton;
    private CheckBox ReadOnlyCheckbox;
    private Button RevertButton;
    private Label BrightnessValueLabel;
    private Label ContrastValueLabel;
    private Label ThreeDResolutionValueLabel;
    private Label VersionLabel;
    private LinkLabel LinkLabel;
}
