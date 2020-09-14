using System;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public static class FacadePictureGame
    {
        internal static string[] m_PicturesURLsArray = new string[PictureGameFeature.sr_NumOfAlbumsInGame];

        public static string FirstAnswer
        {
            get
            {
                return PictureGameFeature.s_Answers[0];
            }
        }

        public static string SecondAnswer
        {
            get
            {
                return PictureGameFeature.s_Answers[1];
            }
        }

        public static string ThirdAnswer
        {
            get
            {
                return PictureGameFeature.s_Answers[2];
            }
        }

        public static string ForthAnswer
        {
            get
            {
                return PictureGameFeature.s_Answers[3];
            }
        }

        public static string GamePictureUrl
        {
            get
            {
                return PictureGameFeature.GetPictureUrl();
            }
        }

        public static int Points
        {
            get
            {
                return PictureGameFeature.s_GamePoints;
            }
        }

        public static string UserAnswer
        {
            set
            {
                PictureGameFeature.s_UserAnswer = value;
            }
        }

        public static string AnswerMessageGame
        {
            get
            {
                string answerMsg = string.Empty;

                if (PictureGameFeature.CheckUserAnswer())
                {
                    answerMsg = string.Format("RIGHT ANSWER!!! :)){0}The picture was taken in {1}", Environment.NewLine, PictureGameFeature.s_RightAnswer);
                }
                else
                {
                    answerMsg = string.Format("WORNG ANSWER! :( {0}You can try again!", Environment.NewLine);
                }

                return answerMsg;
            }
        }

        public static bool IsFeatureAvailable
        {
            get
            {
                bool result = false;
                if (PictureGameFeature.sr_AlbumGame.Count >= PictureGameFeature.sr_NumOfAlbumsInGame)
                {
                    result = true;
                }

                return result;
            }
        }

        public static int PictureGameAlbumIndex
        {
            get
            {
                return PictureGameFeature.s_PictureGameIndex;
            }
        }

        public static bool IsRightAnswer()
        {
            PictureGameFeature.UpdatePoints();
            return PictureGameFeature.CheckUserAnswer();
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
            PictureGameFeature.CreateAlbumsListWithLocationAndPicture(o_Albums);

            if (IsFeatureAvailable)
            {
                PictureGameFeature.ChooseRandomAlbums(out m_PicturesURLsArray[0], out m_PicturesURLsArray[1], out m_PicturesURLsArray[2], out m_PicturesURLsArray[3]);                    
            }
        }

        public static void ResetFeature()
        {
            PictureGameFeature.s_GamePoints = 0;

            if (IsFeatureAvailable) 
            {
                PictureGameFeature.ChooseRandomAlbums(out m_PicturesURLsArray[0], out m_PicturesURLsArray[1], out m_PicturesURLsArray[2], out m_PicturesURLsArray[3]);
            }
        }

        public static string GetPicUrlByIndex(int i_Index)
        {
            if (i_Index > PictureGameFeature.sr_NumOfAlbumsInGame)
            {
                throw new Exception(string.Format("your Index is out of range. The game as only {0} pictures", PictureGameFeature.sr_NumOfAlbumsInGame));
            }

            return m_PicturesURLsArray[i_Index];
        }
    }
}
