using System;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public static class FacadePictureGame
    {
        public static string AnswerOne
        {
            get
            {
               return PictureGameFeature.m_Answer[0];
            }
        }

        public static string AnswerTwo
        {
            get
            {
                return PictureGameFeature.m_Answer[1];
            }
        }

        public static string AnswerThree
        {
            get
            {
                return PictureGameFeature.m_Answer[2];
            }
        }

        public static string AnswerFour
        {
            get
            {
                return PictureGameFeature.m_Answer[3];
            }
        }

        public static string PictureUrl
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
    }
}
