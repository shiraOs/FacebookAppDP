using System;
using FacebookWrapper.ObjectModel;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public static class VMGameBoard
    {
        private static string[] s_PicturesURLsArray = new string[PictureGameFeature.sr_MinNumOfAlbumsInGame];

        public static bool IsGameCommandSet { get; set; }

        public static string GetPicUrlByIndex(int i_Index)
        {
            if (i_Index > PictureGameFeature.sr_MinNumOfAlbumsInGame)
            {
                throw new Exception(string.Format("your Index is out of range. The game as only {0} pictures", PictureGameFeature.sr_MinNumOfAlbumsInGame));
            }

            return s_PicturesURLsArray[i_Index];
        }

        public static int Points
        {
            get
            {
                return PictureGameFeature.s_GamePoints;
            }
        }

        public static bool IsFeatureAvailable
        {
            get
            {
                return PictureGameFeature.IsFeatureAvailable();
            }
        }

        public static int PictureGameAlbumIndex
        {
            get
            {
                return PictureGameFeature.s_PictureGameIndex;
            }
        }

        public static void ReplaceRightAnswerPictureURL()
        {
            string newPictureURL = PictureGameFeature.GetNewPictureUrl();

            switch(PictureGameFeature.s_PictureGameIndex)
            {
                case 0:
                    s_PicturesURLsArray[0] = newPictureURL;
                    break;
                case 1:
                    s_PicturesURLsArray[1] = newPictureURL;
                    break;
                case 2:
                    s_PicturesURLsArray[2] = newPictureURL;
                    break;
                case 3:
                    s_PicturesURLsArray[3] = newPictureURL;
                    break;
            }
        }

        public static void InitPictureGameDetails(int o_IndexAlbum)
        {
            PictureGameFeature.InitPictureGameDetails(o_IndexAlbum);
        }

        public static void CreatePicturesGameFeature(FacebookObjectCollection<Album> o_Albums)
        {
            PictureGameFeature.CreateGame(o_Albums);
            if (IsFeatureAvailable)
            {
                PictureGameFeature.ChooseRandomAlbums(out s_PicturesURLsArray[0], out s_PicturesURLsArray[1], out s_PicturesURLsArray[2], out s_PicturesURLsArray[3]);                    
            }
        }

        public static void ResetFeature()
        {
            PictureGameFeature.Reset();
            IsGameCommandSet = false;
        }

        public static void SetCommand(string i_Text)
        {
            if (i_Text.Contains("Location"))
            {
                PictureGameFeature.Command = new CommandGameByLocation();
                IsGameCommandSet = true;
            }
            else if(i_Text.Contains("Number"))
            {
                IsGameCommandSet = true;
                PictureGameFeature.Command = new CommandGameByNumbers();
            }
            else
            {
                IsGameCommandSet = false;
            }
        }
    }
}
