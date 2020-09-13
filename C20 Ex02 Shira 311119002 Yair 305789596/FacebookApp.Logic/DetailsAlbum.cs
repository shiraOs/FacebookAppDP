using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

using System.Text;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public class DetailsAlbum : Details
    {
        private Album m_SelectedAlbum;

        public DetailsAlbum(Album i_SelectedAlbum)
        {
            m_SelectedAlbum = i_SelectedAlbum;
            TitleName = i_SelectedAlbum.Name;
            FirstDetailsLine = Utils.CheckPropertyStr(i_SelectedAlbum.Location);
            SecondDetailsLine = Utils.CheckPropertyStr(i_SelectedAlbum.CreatedTime.ToString());
            ThirdDetailsLine = picturesInAlbums();
            PictureURL = Utils.CheckPropertyStr(i_SelectedAlbum.PictureAlbumURL);
        }

        private string picturesInAlbums()
        {
            string res = string.Empty;
            string numOfPics = Utils.CheckPropertyStr(m_SelectedAlbum.Count.ToString());

            if (!string.IsNullOrEmpty(numOfPics))
            {
                res = string.Format("{0} Pictures in Albums", numOfPics);
            }

            return res;
        }
    }
}
