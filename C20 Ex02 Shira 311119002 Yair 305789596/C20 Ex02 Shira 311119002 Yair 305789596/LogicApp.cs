using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    internal class LogicApp
    {
        internal enum eAgeRange
        {
            eFiftheenTilEighteen,
            eNineteenTilTweenythree,
            eTweenyFourTilThirty,
            eThirtyTilFourty,
            eFourtyPlus,
            eNoChoice
        }

        internal static readonly Size sr_BigFormSize = new Size(815, 725);
        internal static readonly Size sr_SmallFormSize = new Size(815, 300);
        internal static readonly List<Album> sr_AlbumGame = new List<Album>();
        internal static readonly List<int> sr_AlbumIndexers = new List<int>();
        internal static readonly List<string> sr_AlbumsLocations = new List<string>();
        internal static readonly int sr_NumOfAlbumsInGame = 4;
        internal static readonly FacadePictureGame sr_FacadePictureGame = new FacadePictureGame();

        internal static readonly string sr_AppID = "1163211064078938";
        internal static readonly string[] sr_Permissions =
        {
                "public_profile",
                "user_birthday",
                "user_gender",
                "user_friends",
                "user_location",
                "user_photos",
                "user_posts"
        };

        internal static void CreateFacadePictureGame()
        {
            sr_FacadePictureGame.BuildGame(GetAlbum());
        }

        internal static Random s_Rnd = new Random();

        internal static int PictureGameIndex { get; set; }

        internal static User.eGender RequiredGender { get; set; }

        internal static eAgeRange RequiredAgeRange { get; set; }

        internal static int GetUserAge(string i_Birthday)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            string format = "d";
            DateTime birthdayDate = DateTime.ParseExact(i_Birthday, format, provider);
            DateTime todayDate = DateTime.Today;
            int age = todayDate.Year - birthdayDate.Year;

            if (birthdayDate.Date > todayDate.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        internal static bool IsFeatureOpen(Size i_FormSize)
        {
            return i_FormSize == sr_BigFormSize;
        }

        internal static bool AgeInRange(int o_Age, eAgeRange i_ChosenAgeRange)
        {
            bool inRange = false;

            switch (i_ChosenAgeRange)
            {
                case eAgeRange.eFiftheenTilEighteen:
                    inRange = isAgeInRange(15, 18, o_Age);
                    break;
                case eAgeRange.eNineteenTilTweenythree:
                    inRange = isAgeInRange(19, 23, o_Age);
                    break;
                case eAgeRange.eTweenyFourTilThirty:
                    inRange = isAgeInRange(24, 30, o_Age);
                    break;
                case eAgeRange.eThirtyTilFourty:
                    inRange = isAgeInRange(30, 40, o_Age);
                    break;
                case eAgeRange.eFourtyPlus:
                    inRange = isAgeInRange(40, 100, o_Age);
                    break;
            }

            return inRange;
        }

        private static bool isAgeInRange(int i_Min, int i_Max, int i_Age)
        {
            return i_Age >= i_Min && i_Age <= i_Max;
        }

        internal static bool IsFriendMatchToUserRequests(User i_Friend)
        {
            bool isMatch = false;
            int age = GetUserAge(i_Friend.Birthday);

            if (i_Friend.Gender.Equals(RequiredGender) && AgeInRange(age, RequiredAgeRange))
            {
                if (i_Friend.RelationshipStatus.Equals(User.eRelationshipStatus.Single))
                {
                    isMatch = true;
                }
            }

            return isMatch;
        }

        internal static void ChooseRandomAlbums(out string o_Url1, out string o_Url2, out string o_Url3, out string o_Url4)
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

        internal static string CheckPropertyStr(string i_Property)
        {
            string checkedProperty = string.Empty;

            if (!string.IsNullOrEmpty(i_Property))
            {
                checkedProperty = i_Property;
            }

            return checkedProperty;
        }

        internal static void ReplaceAlbumIndex()
        {
            getRandomIndex(out int index);
            sr_AlbumIndexers[PictureGameIndex] = index;
        }

        internal static void LoadPicture(object i_Sender, string i_PictureUrl)
        {
            PictureBox currPictureBox = i_Sender as PictureBox;
            if (!string.IsNullOrEmpty(i_PictureUrl))
            {
                currPictureBox.LoadAsync(i_PictureUrl);
            }
            else
            {
                currPictureBox.Image = null;
            }
        }

        internal static Album GetAlbum()
        {
            return sr_AlbumGame[sr_AlbumIndexers[PictureGameIndex]];
        }

        internal static string GetNewPictureUrl()
        {
            return sr_AlbumGame[sr_AlbumIndexers[PictureGameIndex]].PictureAlbumURL;
        }
    }
}