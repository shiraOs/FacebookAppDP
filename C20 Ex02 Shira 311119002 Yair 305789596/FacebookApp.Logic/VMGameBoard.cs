using System;
using FacebookWrapper.ObjectModel;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public static class VMGameBoard
    {
        private static string[] m_PicturesURLsArray = new string[PictureGameFeature.sr_MinNumOfAlbumsInGame];

        public static bool GameSet { get; set; }

        public static string GetPicUrlByIndex(int i_Index)
        {
            if (i_Index > PictureGameFeature.sr_MinNumOfAlbumsInGame)
            {
                throw new Exception(string.Format("your Index is out of range. The game as only {0} pictures", PictureGameFeature.sr_MinNumOfAlbumsInGame));
            }

            return m_PicturesURLsArray[i_Index];
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
                    m_PicturesURLsArray[0] = newPictureURL;
                    break;
                case 1:
                    m_PicturesURLsArray[1] = newPictureURL;
                    break;
                case 2:
                    m_PicturesURLsArray[2] = newPictureURL;
                    break;
                case 3:
                    m_PicturesURLsArray[3] = newPictureURL;
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
                PictureGameFeature.ChooseRandomAlbums(out m_PicturesURLsArray[0], out m_PicturesURLsArray[1], out m_PicturesURLsArray[2], out m_PicturesURLsArray[3]);                    
            }
        }

        public static void ResetFeature()
        {
            GameSet = false;
            PictureGameFeature.Reset();
        }

        public static void SetCommand(string i_Text)
        {
   
            if (i_Text.Contains("Location"))
            {
                PictureGameFeature.Command = new CommandGameByLocation();
                GameSet = true;
            }
            else if(i_Text.Contains("Number"))
            {
                GameSet = true;
                PictureGameFeature.Command = new CommandGameByNumbers();
            }
            else
            {
                GameSet = false;
            }

        }
    }
}
