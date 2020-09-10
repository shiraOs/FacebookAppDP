using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public class IFormFriend: FormDetails.IFormDeatils
    {
        public string TitleName { get; set; }
        public string PictureURL { get; set; }
        public string FirstDetailsLine { get; set; }
        public string SecondDetailsLine { get; set; }
        public string ThirdDetailsLine { get; set; }

        public IFormFriend(User i_SelectedFriend)
        {
            TitleName = i_SelectedFriend.Name;
            FirstDetailsLine = Utils.CheckPropertyStr(i_SelectedFriend.Gender.ToString());
            SecondDetailsLine = Utils.CheckPropertyStr(i_SelectedFriend.Birthday);
            ThirdDetailsLine = Utils.CheckPropertyStr(i_SelectedFriend.Location.Name);
            PictureURL = Utils.CheckPropertyStr(i_SelectedFriend.PictureNormalURL);
        }
    }
}
