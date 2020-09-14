using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    internal static class PictureGameFeature
    {
        internal static readonly List<Album> sr_AlbumGame = new List<Album>();
        internal static readonly List<int> sr_AlbumIndexers = new List<int>();
        internal static readonly int sr_NumOfAlbumsInGame = 4;
        internal static readonly int r_AnswersCount = 4;
        internal static int m_GamePoints = 0;
        internal static int m_PictureGameIndex;
        internal static int m_RightAnswerIndex;
        internal static Random s_Rnd = new Random();
        internal static string m_UserAnswer;
        internal static string m_RightAnswer;
        internal static string[] m_Answers;

        internal static void CreateAlbumsListWithLocationAndPicture(FacebookObjectCollection<Album> i_Albums)
        {
            foreach (Album album in i_Albums)
            {
                if (!string.IsNullOrEmpty(album.Location) && !string.IsNullOrEmpty(album.PictureAlbumURL))
                { // album has picture and location
                    PictureGameFeature.sr_AlbumGame.Add(album);
                }
            }
        }

        internal static void InitPictureGameDetails(int i_IndexAlbum)
        {
            m_PictureGameIndex = i_IndexAlbum;
            m_RightAnswerIndex = s_Rnd.Next(0, 4);
            m_RightAnswer = GetAlbum().Location;
            m_Answers = new string[r_AnswersCount];
            m_Answers[m_RightAnswerIndex] = m_RightAnswer;
            placeAnswers();
        }

        internal static void ChooseRandomAlbums(out string o_Url1, out string o_Url2, out string o_Url3, out string o_Url4)
        {
            sr_AlbumIndexers.Clear();
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

        internal static void ReplaceAlbumIndex()
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

        internal static string GetNewPictureUrl()
        {
            getRandomIndex(out int index);
            sr_AlbumIndexers[m_PictureGameIndex] = index;
            return GetPictureUrl();
        }

        internal static void UpdatePoints()
        {
           if(CheckUserAnswer())
            {
                m_GamePoints++;
            }
        }
        internal static bool CheckUserAnswer()
        {
            bool result = false;
            if (m_UserAnswer.Equals(m_RightAnswer))
            {
                result = true;
                m_GamePoints++;
            }

            return result;
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

        private static void placeAnswers()
        {
            int albumIndex = 0;

            for (int i = 0; i < r_AnswersCount; i++)
            {
                if (albumIndex.Equals(m_PictureGameIndex))
                {
                    albumIndex++;
                }

                if (!m_RightAnswer.Equals(m_Answers[i]))
                {
                    m_Answers[i] = sr_AlbumGame[sr_AlbumIndexers[albumIndex]].Location;
                    albumIndex++;
                }
            }
        }
    }
}
