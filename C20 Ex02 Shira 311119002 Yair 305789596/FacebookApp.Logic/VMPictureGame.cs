using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public static class VMPictureGame
    {
        public static string AlbumName
        {
            get
            {
               return PictureGameFeature.GetCurrentAlbum().Name;
            }
        }

        public static string QuestionGame
        {
            get
            {
                string title = string.Empty;
                if (PictureGameFeature.GameType == PictureGameFeature.eGameType.eGameLocation)
                {
                    title = "Where the picture was taken?";
                }
                else if (PictureGameFeature.GameType == PictureGameFeature.eGameType.eGamePictureNum)
                {
                    title = string.Format("How many pictures in album?");
                }

                return title;
            }
        }

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

        public static string UserAnswer
        {
            set
            {
                PictureGameFeature.UserAnswer = value;
            }
        }

        public static string AnswerMessageGame
        {
            get
            {
                string answerMsg = string.Empty;

                if (PictureGameFeature.CheckUserAnswer())
                {
                    answerMsg = string.Format("RIGHT ANSWER!!! :)){0}The picture was taken in {1}", Environment.NewLine, PictureGameFeature.RightAnswer);
                }
                else
                {
                    answerMsg = string.Format("WORNG ANSWER! :( {0}You can try again!", Environment.NewLine);
                }

                return answerMsg;
            }
        }

        public static bool IsRightAnswer()
        {
            PictureGameFeature.UpdatePoints();
            return PictureGameFeature.CheckUserAnswer();
        }
    }
}
