using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    internal class ICommandGameByNumbers : ICommandGame
    {
        public List<Album> AlbumsGameList { get; private set; }

        public List<int> AlbumsIndexerList { get; private set; }

        public string RightAnswer { get; private set; }

        internal ICommandGameByNumbers()
        {
            AlbumsGameList = new List<Album>();
            AlbumsIndexerList = new List<int>();
        }

        public void ExecuteGame(FacebookObjectCollection<Album> i_Albums)
        {
            foreach (Album album in i_Albums)
            {
                if ((album.Count > 0) && !string.IsNullOrEmpty(album.PictureAlbumURL))
                { // album has picture and location
                    AlbumsGameList.Add(album);
                }
            }
        }

        public void InitGame(Album i_Album)
        {
            RightAnswer = i_Album.Count.ToString();
        }

        public string GetAnswer(int i_AlbumIndex)
        {
            return AlbumsGameList[AlbumsIndexerList[i_AlbumIndex]].Count.ToString();
        }
    }
}
