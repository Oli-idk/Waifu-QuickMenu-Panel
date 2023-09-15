using System.Configuration;

namespace QuickMenu
{
    internal class Config
    {
        public static void SetConfig(string key, string value, bool overwriteIfExists = true)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else if(overwriteIfExists)
            {
                settings[key].Value = value;
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        public static string GetConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static void InitConfig()
        {
            for (int i = 1; i < 11; i++)
            {
                SetConfig($"Button{i}-Label", $"Btn{i}", false);
                SetConfig($"Button{i}-Path", $"", false);
                SetConfig($"Button{i}-Extra-Args", $"", false);
            }
        }

    }
}

