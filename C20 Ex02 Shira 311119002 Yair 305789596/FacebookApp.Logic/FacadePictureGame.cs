using System;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public static class FacadePictureGame
    {
        internal static string m_FirstPictureURL;
        internal static string m_SecondPictureURL;
        internal static string m_ThirdPictureURL;
        internal static string m_FourthPictureURL;

        public static string FirstPictureURL
        {
            get
            {
                return m_FirstPictureURL;
            }
        }

        public static string SecondPictureURL
        {
            get
            {
                return m_SecondPictureURL;
            }
        }

        public static string ThirdPictureURL
        {
            get
            {
                return m_ThirdPictureURL;
            }
        }

        public static string FourthPictureURL
        {
            get
            {
                return m_FourthPictureURL;
            }
        }

        public static string FirstAnswer
        {
            get
            {
                return PictureGameFeature.m_Answer[0];
            }
        }

        public static string SecondAnswer
        {
            get
            {
                return PictureGameFeature.m_Answer[1];
            }
        }

        public static string ThirdAnswer
        {
            get
            {
                return PictureGameFeature.m_Answer[2];
            }
        }

        public static string ForthAnswer
        {
            get
            {
                return PictureGameFeature.m_Answer[3];
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
                return PictureGameFeature.m_GamePoints;
            }
        }

        public static string UserAnswer
        {
            set
            {
                PictureGameFeature.m_UserAnswer = value;
            }
        }

        public static bool IsRightAnswer()
        {
            bool result = false;
            if (PictureGameFeature.CheckUserAnswer())
            {
                result = true;
                PictureGameFeature.m_GamePoints++;
            }

            return result;
        }

        public static void ReplaceRightAnswerPictureURL()
        {
            string newPictureURL = PictureGameFeature.GetNewPictureUrl();

            switch(PictureGameFeature.m_PictureGameIndex)
            {
                case 0:
                    m_FirstPictureURL = newPictureURL;
                    break;
                case 1:
                    m_SecondPictureURL = newPictureURL;
                    break;
                case 2:
                    m_ThirdPictureURL = newPictureURL;
                    break;
                case 3:
                    m_FourthPictureURL = newPictureURL;
                    break;
            }
        }

        public static string AnswerMessageGame
        {
            get
            {
                string answerMsg = string.Empty;

                if (PictureGameFeature.CheckUserAnswer())
                {
                    answerMsg = string.Format("RIGHT ANSWER!!! :)){0}The picture was taken in {1}", Environment.NewLine, PictureGameFeature.m_RightAnswer);
                }
                else
                {
                    answerMsg = string.Format("WORNG ANSWER! :( {0}You can try again!", Environment.NewLine);
                }

                return answerMsg;
            }
        }

        public static void BuildGame(int i_IndexAlbum)
        {
            PictureGameFeature.BuildGame(i_IndexAlbum);
        }

        public static void CreatePicturesGameFeature(FacebookObjectCollection<Album> i_Albums)
        {
            PictureGameFeature.CreateAlbumsListWithLocationAndPicture(i_Albums);
            if (IsFeatureAvailable)
            {
                PictureGameFeature.ChooseRandomAlbums(out m_FirstPictureURL, out m_SecondPictureURL, out m_ThirdPictureURL, out m_FourthPictureURL);                    
            }
        }

        public static bool IsFeatureAvailable
        {
            get
            {
                bool result = false;
                if (PictureGameFeature.sr_AlbumsLocations.Count >= PictureGameFeature.sr_NumOfAlbumsInGame)
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
                return PictureGameFeature.m_PictureGameIndex;
            }
        }

        public static void ResetFeature()
        {
            PictureGameFeature.m_GamePoints = 0;
            if(IsFeatureAvailable)
            {
                PictureGameFeature.ChooseRandomAlbums(out m_FirstPictureURL, out m_SecondPictureURL, out m_ThirdPictureURL, out m_FourthPictureURL);
            }
        }
    }
}
