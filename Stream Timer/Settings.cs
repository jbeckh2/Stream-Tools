using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Timer
{
    public class Settings
    {
        public string TimeSpanFormat { get; set; }
        public string OutputFile { get; set; }
        public bool ShowMessage { get; set; }
        public string Message { get; set; }

        internal void Save()
        {
            string location = GetSettingsFileLocation();
            Save(location);
        }

        private void Save(string location)
        {
            using (FileStream fs = new FileStream(location, FileMode.Create, FileAccess.ReadWrite))
            {
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());

                x.Serialize(fs, this);

                fs.Flush();
                fs.Close();
            }
        }

        private static string GetSettingsFileLocation()
        {
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string streamToolsFolder = Path.Combine(appDataFolder, "Stream Tools");
            if (!Directory.Exists(streamToolsFolder))
            {
                Directory.CreateDirectory(streamToolsFolder);
            }

            string settingPath = Path.Combine(streamToolsFolder, "Stream Timer Settings.xml");

            return settingPath;
        }

        public static Settings Load()
        {
            string location = GetSettingsFileLocation();
            return Load(location);
        }

        public static Settings Load(string fileLocation)
        {
            Settings result = null;

            if (File.Exists(fileLocation))
            {
                try
                {
                    using (FileStream fs = new FileStream(fileLocation, FileMode.Open, FileAccess.Read))
                    {
                        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
                        result = x.Deserialize(fs) as Settings;
                        fs.Close();
                    }
                } catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }

            return result;
        }
    }
}
