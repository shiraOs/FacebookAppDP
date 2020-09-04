using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    internal class ProxyPost
    {
        private Post m_Post;
        public string Name { get; private set; }
        public string Message { get; private set; }
        public string Date { get; private set; }
        public string PictureUrl { get; private set; }
        internal ProxyPost(Post i_Post)
        {
            m_Post = i_Post;
            Name = m_Post.Name;
            Date = LogicApp.CheckPropertyStr(m_Post.CreatedTime.ToString());
            Message = LogicApp.CheckPropertyStr(m_Post.Message);

            if(string.IsNullOrEmpty(Message))
            {
                Message = LogicApp.CheckPropertyStr(m_Post.Description);
            }

            PictureUrl = m_Post.PictureURL;
        }
    }
}