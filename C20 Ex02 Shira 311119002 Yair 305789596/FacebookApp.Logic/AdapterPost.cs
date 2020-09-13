using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    interface IPostDetails
    {
        string PostName { get; set; }
        string PostDescription { get; set; }
        DateTime PostCreateTime { get; set; }
        Image PostPicture { get; set; }

    }
    public class AdapterPost : IPostDetails
    {
        public Post Adoptee { get; set; }
        public string PostName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PostDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime PostCreateTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Image PostPicture { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
