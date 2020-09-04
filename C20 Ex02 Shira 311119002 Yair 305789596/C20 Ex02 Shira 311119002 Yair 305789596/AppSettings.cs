using System;
using System.IO;
using System.Xml.Serialization;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public class AppSettings
    {
        private static readonly string sr_Path = AppDomain.CurrentDomain.BaseDirectory + @"\appSettings.xml";

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public AppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings obj = new AppSettings();

            if (File.Exists(sr_Path))
            {
                using (Stream stream = new FileStream(sr_Path, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    obj = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return obj;
        }

        public void SaveToFile()
        {
            if (File.Exists(sr_Path))
            {
                File.Delete(sr_Path);
            }

            if (RememberUser)
            {
                using (Stream stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\appSettings.xml", FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
        }
    }
}