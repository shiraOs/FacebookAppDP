using System;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public class AppSettings
    {
        private static readonly string sr_Path = AppDomain.CurrentDomain.BaseDirectory + @"\appSettings.xml";
        internal static readonly Size sr_BigFormSize = new Size(815, 725);
        internal static readonly Size sr_SmallFormSize = new Size(815, 300);
        internal static readonly string sr_AppID = "1163211064078938";
        internal static readonly string[] sr_Permissions =
        {
                "public_profile",
                "user_birthday",
                "user_gender",
                "user_friends",
                "user_location",
                "user_photos",
                "user_posts"
        };
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

        internal static bool IsFeatureOpen(Size i_FormSize)
        {
            return i_FormSize == sr_BigFormSize;
        }
    }
}