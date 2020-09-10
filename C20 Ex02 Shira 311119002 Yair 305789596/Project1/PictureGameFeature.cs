using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public static class PictureGameFeature
    {
        public static event Action RightAnswerClicked;

        public static readonly List<Album> sr_AlbumGame = new List<Album>();
        internal static readonly List<int> sr_AlbumIndexers = new List<int>();
        public static readonly List<string> sr_AlbumsLocations = new List<string>();
        public static readonly int sr_NumOfAlbumsInGame = 4;
        internal static readonly int r_AnswersCount = 4;
        internal static int m_GamePoints = 0;
        public static int m_PictureGameIndex;
        internal static int m_RightAnswerIndex;
        internal static Random s_Rnd = new Random();
        internal static string m_UserAnswer;
        internal static string m_RightAnswer;
        internal static string[] m_Answer;

        public static void BuildGame(int i_IndexAlbum)
        {
            m_PictureGameIndex = i_IndexAlbum;
            m_RightAnswerIndex = s_Rnd.Next(0, 4);
            m_RightAnswer = GetAlbum().Location;
            m_Answer = new string[r_AnswersCount];
            m_Answer[m_RightAnswerIndex] = m_RightAnswer;
            placeAnswers();
        }

        public static void ResetFeature()
        {
            m_GamePoints = 0;
        }

        public static void ChooseRandomAlbums(out string o_Url1, out string o_Url2, out string o_Url3, out string o_Url4)
        {
            for (int i = 0; i < sr_NumOfAlbumsInGame; i++)
            {
                getRandomIndex(out int index);
                sr_AlbumIndexers.Add(index);
            }

            o_Url1 = sr_AlbumGame[sr_AlbumIndexers[0]].PictureAlbumURL;
            o_Url2 = sr_AlbumGame[sr_AlbumIndexers[1]].PictureAlbumURL;
            o_Url3 = sr_AlbumGame[sr_AlbumIndexers[2]].PictureAlbumURL;
            o_Url4 = sr_AlbumGame[sr_AlbumIndexers[3]].PictureAlbumURL;
        }

        private static void getRandomIndex(out int o_Index)
        {
            int numOfAlbums = sr_AlbumGame.Count;

            do
            {
                o_Index = s_Rnd.Next(0, numOfAlbums);
            }
            while (isIndexAlreadyAppear(o_Index));
        }

        private static bool isIndexAlreadyAppear(int i_IndexToCheck)
        {
            bool result = false;

            foreach (int albumIndex in sr_AlbumIndexers)
            {
                if (albumIndex.Equals(i_IndexToCheck))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public static void ReplaceAlbumIndex()
        {
            getRandomIndex(out int index);
            sr_AlbumIndexers[m_PictureGameIndex] = index;
        }

        internal static Album GetAlbum()
        {
            return sr_AlbumGame[sr_AlbumIndexers[m_PictureGameIndex]];
        }

        internal static string GetPictureUrl()
        {
            return sr_AlbumGame[sr_AlbumIndexers[m_PictureGameIndex]].PictureAlbumURL;
        }

        public static string GetNewPictureUrl()
        {
            getRandomIndex(out int index);
            sr_AlbumIndexers[m_PictureGameIndex] = index;
            return GetPictureUrl();
        }

        internal static bool CheckUserAnswer()
        {
            bool result = false;
            if (m_UserAnswer.Equals(m_RightAnswer))
            {
                result = true;
                m_GamePoints++;
                RightAnswerClicked.Invoke();
            }
 
            return result;
        }

        private static void placeAnswers()
        {
            int albumIndex = 0;

            for (int i = 0; i < r_AnswersCount; i++)
            {
                if (albumIndex.Equals(m_PictureGameIndex))
                {
                    albumIndex++;
                }

                if (!m_RightAnswer.Equals(m_Answer[i]))
                {
                    m_Answer[i] = (sr_AlbumGame[sr_AlbumIndexers[albumIndex]].Location);
                    albumIndex++;
                }
            }
        }
    }
}
