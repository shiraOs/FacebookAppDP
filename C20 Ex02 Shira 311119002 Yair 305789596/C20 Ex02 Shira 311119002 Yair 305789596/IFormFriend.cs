using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    internal class IFormFriend: FormDeatils.IFormDeatils
    {
        public string TitleName { get; set; }
        public string PictureURL { get; set; }
        public string FirstDetailsLine { get; set; }
        public string SecondDetailsLine { get; set; }
        public string ThirdDetailsLine { get; set; }

        public IFormFriend(User i_SelectedFriend)
        {
            TitleName = i_SelectedFriend.Name;
            FirstDetailsLine = LogicApp.CheckPropertyStr(i_SelectedFriend.Gender.ToString());
            SecondDetailsLine = LogicApp.CheckPropertyStr(i_SelectedFriend.Birthday);
            ThirdDetailsLine = LogicApp.CheckPropertyStr(i_SelectedFriend.Location.Name);
            PictureURL = LogicApp.CheckPropertyStr(i_SelectedFriend.PictureNormalURL);
        }
    }
}
