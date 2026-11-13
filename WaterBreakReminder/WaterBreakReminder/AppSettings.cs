
using System;
using System.IO;
using System.Text.Json;

namespace WaterBreakReminder
{
    public class AppSettings
    {
        public bool SoundEnabled { get; set; } = true;

        private static string SettingsPath =>
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData
                ),
                "WaterAndBreakReminder",
                "settings.json"
            );

        public static AppSettings Load()
        {
            try
            {
                if (File.Exists(SettingsPath))
                {
                    string json = File.ReadAllText(SettingsPath);

                    return JsonSerializer.Deserialize<AppSettings>(json)
                           ?? new AppSettings();
                }
            }
            catch
            {
            }

            return new AppSettings();
        }

        public void Save()
        {
            string folder = Path.GetDirectoryName(SettingsPath)!;

            Directory.CreateDirectory(folder);

            string json = JsonSerializer.Serialize(
                this,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );

            File.WriteAllText(SettingsPath, json);
        }
    }
}
