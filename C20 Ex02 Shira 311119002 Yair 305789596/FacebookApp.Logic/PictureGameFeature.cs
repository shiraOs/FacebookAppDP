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
        internal static readonly int sr_AnswersCount = 4;
        internal static int s_GamePoints = 0;
        internal static int s_PictureGameIndex;
        internal static int s_RightAnswerIndex;
        internal static Random s_Rnd = new Random();
        internal static string s_UserAnswer;
        internal static string s_RightAnswer;
        internal static string[] s_Answers;

        internal static void CreateAlbumsListWithLocationAndPicture(FacebookObjectCollection<Album> i_Albums)
        {
            foreach (Album album in i_Albums)
            {
                if (!string.IsNullOrEmpty(album.Location) && !string.IsNullOrEmpty(album.PictureAlbumURL))
                { // album has picture and location
                     sr_AlbumGame.Add(album);
                }
            }
        }

        internal static void InitPictureGameDetails(int i_IndexAlbum)
        {
            s_PictureGameIndex = i_IndexAlbum;
            s_RightAnswerIndex = s_Rnd.Next(0, 4);
            s_RightAnswer = GetCurrentAlbum().Location;
            s_Answers = new string[sr_AnswersCount];
            s_Answers[s_RightAnswerIndex] = s_RightAnswer;
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

        internal static Album GetCurrentAlbum()
        {
            return sr_AlbumGame[sr_AlbumIndexers[s_PictureGameIndex]];
        }

        internal static string GetPictureUrl()
        {
            return sr_AlbumGame[sr_AlbumIndexers[s_PictureGameIndex]].PictureAlbumURL;
        }

        internal static string GetNewPictureUrl()
        {
            getRandomIndex(out int index);
            sr_AlbumIndexers[s_PictureGameIndex] = index;

            return GetPictureUrl();
        }

        internal static void UpdatePoints()
        {
           if(CheckUserAnswer())
            {
                s_GamePoints++;
            }
        }

        internal static bool CheckUserAnswer()
        {
            bool result = false;

            if (s_UserAnswer.Equals(s_RightAnswer))
            {
                result = true;
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

            for (int i = 0; i < sr_AnswersCount; i++)
            {
                if (albumIndex.Equals(s_PictureGameIndex))
                {
                    albumIndex++;
                }

                if (!s_RightAnswer.Equals(s_Answers[i]))
                {
                    s_Answers[i] = sr_AlbumGame[sr_AlbumIndexers[albumIndex]].Location;
                    albumIndex++;
                }
            }
        }
    }
}
