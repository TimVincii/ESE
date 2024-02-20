using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ESE
{
    internal class ConfigEditor
    {
        private List<string> configuration;

        /// <summary>
        /// The constructor method of the config editor.
        /// Reads the Fortnite configuration data into the list, then checks if any
        /// of the necessary setting keys are missing.
        /// </summary>
        public ConfigEditor(string path)
        {
            if (!File.Exists(path))
            {
                Emb.MakeErrorBox("The Fortnite configuration file wasn't found, relaunching Fortnite should fix this issue.").Show();
                Environment.Exit(2);
            }
            configuration = File.ReadAllLines(path).ToList();
        }

        /// <summary>
        /// A method to retrieve the configuration List.
        /// </summary>
        public List<string> Configuration { get { return configuration; } }

        /// <summary>
        /// A method to get the value of a certain key in the configuration.
        /// </summary>
        /// <param name="key">The key name.</param>
        /// <returns>The value of the provided key, as a string.</returns>
        public string GetConfigValue(string key)
        {
            for (int i = 0; i < configuration.Count; i++)
                if (configuration[i].StartsWith(key))
                    return configuration[i].Replace(key + '=', string.Empty);

            Emb.MakeErrorBox("A searched key wasn't found in the configuration.").Show();
            Environment.Exit(0);
            return null;
        }

        /// <summary>
        /// A method to set the value of a certain key in the configuration.
        /// </summary>
        /// <param name="key">The key name.</param>
        /// <param name="NewValue">The new value to be set for the provided key.</param>
        public void SetConfigValue(string key, string NewValue)
        {
            for (int i = 0; i < configuration.Count; i++)
                if (configuration[i].StartsWith(key))
                {
                    configuration[i] = key + '=' + NewValue;
                    return;
                }
        }

        /// <summary>
        /// A method that allows for inserting a line at a certain index of the configuration.
        /// </summary>
        /// <param name="LineIndex">The index at which the provided line should be inserte at.</param>
        /// <param name="line">The lines to insert.</param>
        public void AddLineToConfig(int LineIndex, string line) { configuration.Insert(LineIndex, line); }

        /// <summary>
        /// A method to save the current configuration list to the Fortnite config file.
        /// </summary>
        public void SaveConfigToFile(string path)
        {     
            if (!File.Exists(path))
            {
                Emb.MakeErrorBox("The Fortnite configuration file wasn't found, relaunching Fortnite should fix this issue.").Show();
                Environment.Exit(0);
            }
            File.WriteAllLines(path, configuration);
        }
    }
}
