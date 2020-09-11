using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;


namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public static class Utils
    {
        public static string CheckPropertyStr(string i_Property)
        {
            string checkedProperty = string.Empty;

            if (!string.IsNullOrEmpty(i_Property))
            {
                checkedProperty = i_Property;
            }

            return checkedProperty;
        }

        public static void LoadPictureToPictureBox(object i_Sender, string i_PictureUrl)
        {
            PictureBox currPictureBox = i_Sender as PictureBox;
            if (!string.IsNullOrEmpty(i_PictureUrl))
            {
                currPictureBox.LoadAsync(i_PictureUrl);
            }
            else
            {
                currPictureBox.Image = null;
            }
        }
        public static int GetUserAge(string i_Birthday)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            string format = "d";
            DateTime birthdayDate = DateTime.ParseExact(i_Birthday, format, provider);
            DateTime todayDate = DateTime.Today;
            int age = todayDate.Year - birthdayDate.Year;

            if (birthdayDate.Date > todayDate.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
