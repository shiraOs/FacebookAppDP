using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    internal class IFormAlbum : FormDeatils.IFormDeatils
    {
        private Album m_SelectedAlbum;
        public string TitleName { get; set; }
        public string PictureURL { get; set; }
        public string FirstDetailsLine { get; set; }
        public string SecondDetailsLine { get; set; }
        public string ThirdDetailsLine { get; set; }

        public IFormAlbum(Album i_SelectedAlbum)
        {
            m_SelectedAlbum = i_SelectedAlbum;
            TitleName = i_SelectedAlbum.Name;
            FirstDetailsLine = LogicApp.CheckPropertyStr(i_SelectedAlbum.Location);
            SecondDetailsLine = LogicApp.CheckPropertyStr(m_SelectedAlbum.CreatedTime.ToString());
            ThirdDetailsLine = picturesInAlbums();
            PictureURL = LogicApp.CheckPropertyStr(i_SelectedAlbum.PictureAlbumURL);
        }

        private string picturesInAlbums()
        {
            string res = string.Empty;
            string numOfPics = LogicApp.CheckPropertyStr(m_SelectedAlbum.Count.ToString());
            if (!string.IsNullOrEmpty(numOfPics))
            {
                res = string.Format("{0} Pictures in Albums", numOfPics);
            }
            return res;
        }
    }
}
