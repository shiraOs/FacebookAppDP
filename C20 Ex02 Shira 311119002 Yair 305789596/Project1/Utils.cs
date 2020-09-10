using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
    }
}
