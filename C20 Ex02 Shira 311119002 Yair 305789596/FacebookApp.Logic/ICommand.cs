﻿using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    internal interface ICommand
    {
        List<Album> AlbumsGameList { get; }
        List<int> AlbumsIndexerList { get; }
        string RightAnswer { get; }
        void ExecuteGame(FacebookObjectCollection<Album> o_Albums);
        void InitGame(Album i_Album);
        string GetAnswer(int albumIndex);
    }
}