using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public interface IFormDeatils
    {
        Details CreateForm(object i_Object);
    } 

    public class IFormFriend : IFormDeatils
    {
        public Details CreateForm(object i_Object)
        {
            return new FriendDetails(i_Object as User);
        }
    }

    public class IFormAlbum : IFormDeatils
    {
        public Details CreateForm(object i_Object)
        {
            return new AlbumDetails(i_Object as Album);
        }
    }
}
