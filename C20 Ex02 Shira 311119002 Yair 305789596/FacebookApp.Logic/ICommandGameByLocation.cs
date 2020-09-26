using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;


namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    internal class ICommandGameByLocation : ICommand
    {
        public List<Album> AlbumsGameList { get; private set; }
        public List<int> AlbumsIndexerList { get; private set; }
        public string RightAnswer { get; private set; }
        internal ICommandGameByLocation()
        {
            AlbumsGameList = new List<Album>();
            AlbumsIndexerList = new List<int>();
        }
        public void ExecuteGame(FacebookObjectCollection<Album> o_Albums)
        {
            foreach (Album album in o_Albums)
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
        public string GetAnswer(int albumIndex)
        {
            return AlbumsGameList[AlbumsIndexerList[albumIndex]].Location;
        }
    }
}
