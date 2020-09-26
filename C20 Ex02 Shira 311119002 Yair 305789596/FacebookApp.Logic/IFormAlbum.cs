using FacebookWrapper.ObjectModel;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public class IFormAlbum : IFormDetails
    {
        public Details CreateForm(object o_Object)
        {
            return new DetailsAlbum(o_Object as Album);
        }
    }
}
