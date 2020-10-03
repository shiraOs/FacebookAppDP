using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public static class PictureGameFeature
    {
        public enum eTypeGame
        {
            eGameNotSet,
            eGameLocation,
            eGamePictureNum
        }

      
        internal static int s_GamePoints = 0;
        internal static readonly int sr_MinNumOfAlbumsInGame = 4;
        internal static readonly int sr_AnswersCount = 4;
        internal static int s_PictureGameIndex;
        internal static int s_RightAnswerIndex;
        internal static Random s_Rnd = new Random();
        internal static string[] s_Answers = new string[sr_AnswersCount];

        public static eTypeGame TypeGame { get; internal set; }

        private static ICommandGame Command { get; set; }


        internal static string UserAnswer { get; set; }

        internal static string RightAnswer
        {
            get
            {
                return Command.RightAnswer;
            }
        }

        internal static bool IsFeatureAvailable()
        {
            bool result = false;
            if(Command != null)
            {
                if (Command.AlbumsGameList.Count >= sr_MinNumOfAlbumsInGame)
                {
                    result = true;
                }
            }

            return result;
        }

        internal static void InitPictureGameDetails(int i_IndexAlbum)
        {
            s_PictureGameIndex = i_IndexAlbum;
            s_RightAnswerIndex = s_Rnd.Next(0, 4);
            Command.InitGame(GetCurrentAlbum());
            s_Answers = new string[sr_AnswersCount];
            s_Answers[s_RightAnswerIndex] = Command.RightAnswer;
            placeAnswers();
        }

        internal static void ChooseRandomAlbums(out string o_Url1, out string o_Url2, out string o_Url3, out string o_Url4)
        {
            Command.AlbumsIndexerList.Clear();

            for (int i = 0; i < sr_MinNumOfAlbumsInGame; i++)
            {
                getRandomIndex(out int index);
                Command.AlbumsIndexerList.Add(index);
            }

            o_Url1 = Command.AlbumsGameList[Command.AlbumsIndexerList[0]].PictureAlbumURL;
            o_Url2 = Command.AlbumsGameList[Command.AlbumsIndexerList[1]].PictureAlbumURL;
            o_Url3 = Command.AlbumsGameList[Command.AlbumsIndexerList[2]].PictureAlbumURL;
            o_Url4 = Command.AlbumsGameList[Command.AlbumsIndexerList[3]].PictureAlbumURL;
        }

        internal static void Reset()
        {
            s_GamePoints = 0;
            Command = null;
            TypeGame = eTypeGame.eGameNotSet;
        }

        internal static void CreateGame(FacebookObjectCollection<Album> o_Albums)
        {
            setCommand();
            if(Command!= null)
            {
                Command.ExecuteGame(o_Albums);
            }
        }

        internal static Album GetCurrentAlbum()
        {
            return Command.AlbumsGameList[Command.AlbumsIndexerList[s_PictureGameIndex]];
        }

        internal static string GetPictureUrl()
        {
            return Command.AlbumsGameList[Command.AlbumsIndexerList[s_PictureGameIndex]].PictureAlbumURL;
        }

        internal static string GetNewPictureUrl()
        {
            getRandomIndex(out int index);
            Command.AlbumsIndexerList[s_PictureGameIndex] = index;

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

            if (UserAnswer.Equals(RightAnswer))
            {
                result = true;
            }

            return result;
        }

        private static void getRandomIndex(out int o_Index)
        {
            int numOfAlbums = Command.AlbumsGameList.Count;

            do
            {
                o_Index = s_Rnd.Next(0, numOfAlbums);
            }
            while (isIndexAlreadyAppear(o_Index));
        }

        private static bool isIndexAlreadyAppear(int i_IndexToCheck)
        {
            bool result = false;

            foreach (int albumIndex in Command.AlbumsIndexerList)
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

                if (!RightAnswer.Equals(s_Answers[i]))
                {
                    s_Answers[i] = Command.GetAnswer(albumIndex);
                    albumIndex++;
                }
            }
        }

        private static void setCommand()
        { 

            if (TypeGame == eTypeGame.eGameLocation)
            {
                Command = new ICommandGameByLocation();
            }

            if (TypeGame == eTypeGame.eGamePictureNum)
            {
                Command = new ICommandGameByNumbers();
            }
        }
    }
}
