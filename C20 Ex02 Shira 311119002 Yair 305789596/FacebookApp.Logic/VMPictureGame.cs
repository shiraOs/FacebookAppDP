using System;

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
                if (PictureGameFeature.Command is CommandGameByLocation)
                {
                    title = "Where the picture was taken?";
                }
                else if (PictureGameFeature.Command is CommandGameByNumbers)
                {
                    title = "How many pictures in album?";
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
                    answerMsg = string.Format("RIGHT ANSWER!!! :)){0}", Environment.NewLine);
                    if (PictureGameFeature.Command is CommandGameByLocation)
                    {
                        answerMsg += string.Format("The picture was taken in {0}", PictureGameFeature.RightAnswer);
                    }
                    else
                    {
                        answerMsg += string.Format("There are {0} pictures in the album", PictureGameFeature.RightAnswer);
                    }
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
