using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public class IFormFriend : IFormDetails
    {
        public Details CreateForm(object o_Object)
        {
            return new DetailsFriend(o_Object as User);
        }
    }
}
