using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public class ICommandGameByLocation : ICommandGame
    {
        public List<Album> AlbumsGameList { get; private set; }

        public List<int> AlbumsIndexerList { get; private set; }

        public string RightAnswer { get; private set; }

        internal ICommandGameByLocation()
        {
            AlbumsGameList = new List<Album>();
            AlbumsIndexerList = new List<int>();
        }

        public void ExecuteGame(FacebookObjectCollection<Album> i_Albums)
        {
            foreach (Album album in i_Albums)
            {
                if (!string.IsNullOrEmpty(album.Location) && !string.IsNullOrEmpty(album.PictureAlbumURL))
                { // album has picture and location
                    AlbumsGameList.Add(album);
                }
            }
        }

        public void InitGame(Album i_Album)
        {
            RightAnswer = i_Album.Location;
        }

        public string GetAnswer(int i_AlbumIndex)
        {
            return AlbumsGameList[AlbumsIndexerList[i_AlbumIndex]].Location;
        }
    }
}
