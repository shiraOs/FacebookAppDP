using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public class IFormAlbum : IFormDetails
    {
        public Details CreateForm(object i_Object)
        {
            return new DetailsAlbum(i_Object as Album);
        }
    }
}
