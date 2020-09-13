using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public abstract class Details
    {
        public string TitleName { get; set; }
        
        public string PictureURL { get; set; }
        
        public string FirstDetailsLine { get; set; }
        
        public string SecondDetailsLine { get; set; }

        public string ThirdDetailsLine { get; set; }
    }

    public class FriendDetails : Details
    {
        private User m_SelectedFriend;

        public FriendDetails(User i_SelectedFriend)
        {
            m_SelectedFriend = i_SelectedFriend;
            TitleName = i_SelectedFriend.Name;
            FirstDetailsLine = Utils.CheckPropertyStr(i_SelectedFriend.Gender.ToString());
            SecondDetailsLine = userAge();
            ThirdDetailsLine = Utils.CheckPropertyStr(i_SelectedFriend.Location.Name);
            PictureURL = Utils.CheckPropertyStr(i_SelectedFriend.PictureNormalURL);
        }

        private string userAge()
        {
            string res = string.Empty;
            string birthday = Utils.CheckPropertyStr(m_SelectedFriend.Birthday.ToString());

            if (!string.IsNullOrEmpty(birthday))
            {
                res = string.Format("Age: {0}", Utils.GetUserAge(birthday));
            }

            return res;
        }
    }

    public class AlbumDetails : Details
    {
        private Album m_SelectedAlbum;

        public AlbumDetails(Album i_SelectedAlbum)
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
