using System;
using FacebookWrapper.ObjectModel;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public class DetailsFriend : Details
    {
        private User m_SelectedFriend;

        public DetailsFriend(User i_SelectedFriend)
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
}
