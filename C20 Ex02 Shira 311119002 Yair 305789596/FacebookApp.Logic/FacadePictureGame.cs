using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    class FacadePictureGame
    {
        public event Action RightAnswerClicked;
        internal string[] m_Answers;
        internal string m_PictureUrl;
        private int m_RightAnswerIndex;
        private string m_RightAnswer;
        private readonly int r_AnswersCount = 4;
        internal int Points { get; set; }

        internal void BuildGame(Album i_Album)
        {
            m_RightAnswerIndex = LogicApp.s_Rnd.Next(0, 4);
            m_RightAnswer = i_Album.Location;
            m_PictureUrl = i_Album.PictureAlbumURL;
            m_Answers = new string[r_AnswersCount];
            m_Answers[m_RightAnswerIndex] = m_RightAnswer;
            placeAnswers();
        }

        private void placeAnswers()
        {
            int albumIndex = 0;

            for (int i = 0; i < r_AnswersCount; i++)
            {
                if (albumIndex.Equals(LogicApp.PictureGameIndex))
                {
                    albumIndex++;
                }

                if (!m_RightAnswer.Equals(m_Answers[i]))
                {
                    m_Answers[i] = (LogicApp.sr_AlbumGame[LogicApp.sr_AlbumIndexers[albumIndex]].Location);
                    albumIndex++;
                }
            }
        }

        internal string EndGame(string i_AnswerText)
        {
            string endGameMessage = string.Empty;

            if (i_AnswerText.Equals(m_RightAnswer))
            {
                endGameMessage = string.Format("RIGHT ANSWER!!! :)){0}The picture was taken in {1}", Environment.NewLine, m_RightAnswer);
                this.Points++;
                RightAnswerClicked.Invoke();
            }
            else
            {
                endGameMessage = string.Format("WORNG ANSWER! :( {0}You can try again!", Environment.NewLine);
            }

            return endGameMessage;
        }
    }
}
