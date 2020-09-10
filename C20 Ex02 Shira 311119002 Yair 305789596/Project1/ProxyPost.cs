using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public class ProxyPost  ///CHECNGE AACCEESSSS MODIFAIER
    {
        private Post m_Post;
        private string m_Message;
        private string m_Date;
        private string m_PictureURL;
    
        public string Name { get; private set; }
        public string Message
        {
            get
            {
                if(m_Message == null)
                {
                    m_Message = Utils.CheckPropertyStr(m_Post.Message);
                    if (string.IsNullOrEmpty(m_Message))
                    {
                        m_Message = Utils.CheckPropertyStr(m_Post.Description);
                    }
                }
                return m_Message;
            }
        }

        public string Date
        {
            get
            {
                if (m_Date == null)
                {
                    m_Date = Utils.CheckPropertyStr(m_Post.CreatedTime.ToString());
                }
                return m_Date;
            }
        }

        public string PictureUrl
        {
            get
            {
                if (m_PictureURL == null)
                {
                    m_PictureURL = Utils.CheckPropertyStr(m_Post.PictureURL);
                }
                return m_PictureURL;
            }
        }

        public ProxyPost(Post i_Post)
        {
            m_Post = i_Post;
            Name = m_Post.Name;
        }
    }
}