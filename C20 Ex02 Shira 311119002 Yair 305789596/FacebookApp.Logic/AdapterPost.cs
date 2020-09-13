using System;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public interface IPresentDetails
    {
        string Name { get; }

        string Description { get; }

        string PictureURL { get; }

        DateTime? CreatedTime { get; }
    }

    public class AdapterPost : IPresentDetails
    {
        public Post Post { get; set; }

        private string m_Description;
        private string m_PictureURL;
        private DateTime? m_CreatedTime;

        public string Name
        {
            get
            {
                return Post.Name;
            }
        }

        public string Description
        {
            get
            {
                if (string.IsNullOrEmpty(m_Description))
                {
                    m_Description = Utils.CheckPropertyStr(Post.Message);
                    if (string.IsNullOrEmpty(m_Description))
                    {
                        m_Description = Utils.CheckPropertyStr(Post.Description);
                    }

                    if (string.IsNullOrEmpty(m_Description))
                    {
                        m_Description = Utils.CheckPropertyStr(Post.Name);
                    }
                }

                return m_Description;
            }
        }

        public DateTime? CreatedTime
        {
            get
            {
                if (m_CreatedTime == null)
                {
                    if (Post.CreatedTime != null)
                    {
                        m_CreatedTime = Convert.ToDateTime(Post.CreatedTime).Date;
                    }
                }

                return m_CreatedTime;
            }
        }

        public string PictureURL
        {
            get
            {
                if (string.IsNullOrEmpty(m_PictureURL))
                {
                    if (!string.IsNullOrEmpty(Post.PictureURL))
                    {
                        m_PictureURL = Post.PictureURL;
                    }
                    else
                    {
                        m_PictureURL = Utils.m_DefultPictureUrl;
                    }
                }

                return m_PictureURL;
            }
        }
    }
}
