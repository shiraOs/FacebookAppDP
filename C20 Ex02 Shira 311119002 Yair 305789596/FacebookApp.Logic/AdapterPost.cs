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
        public Post Adoptee { get; set; }

        private string m_Description;
        private string m_PictureURL;
        private DateTime? m_CreatedTime;

        public string Name
        {
            get
            {
                return Adoptee.Name;
            }
        }

        public string Description
        {
            get
            {
                if (string.IsNullOrEmpty(m_Description))
                {
                    m_Description = Utils.CheckPropertyStr(Adoptee.Message);
                    if (string.IsNullOrEmpty(m_Description))
                    {
                        m_Description = Utils.CheckPropertyStr(Adoptee.Description);
                    }

                    if (string.IsNullOrEmpty(m_Description))
                    {
                        m_Description = Utils.CheckPropertyStr(Adoptee.Name);
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
                    if (Adoptee.CreatedTime != null)
                    {
                        m_CreatedTime = Convert.ToDateTime(Adoptee.CreatedTime).Date;
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
                    if (!string.IsNullOrEmpty(Adoptee.PictureURL))
                    {
                        m_PictureURL = Adoptee.PictureURL;
                    }
                    else
                    {
                        m_PictureURL = Utils.m_DefaultPictureUrl;
                    }
                }

                return m_PictureURL;
            }
        }
    }
}
