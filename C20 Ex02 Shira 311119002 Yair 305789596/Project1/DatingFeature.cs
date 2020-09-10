using System;
using FacebookWrapper.ObjectModel;
using System.Globalization;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public static class DatingFeature
    {
        public enum eAgeRange
        {
            eFiftheenTilEighteen,
            eNineteenTilTweenythree,
            eTweenyFourTilThirty,
            eThirtyTilFourty,
            eFourtyPlus
        }
        public static User.eGender? RequiredGender { get; set; }
        public static eAgeRange? RequiredAgeRange { get; set; }

        public static void ResetFeature()
        {
            RequiredAgeRange = null;
            RequiredGender = null;
        }

        public static bool IsFriendMatchToUserRequests(User i_Friend)
        {
            bool isMatch = false;
            int age = getUserAge(i_Friend.Birthday);

            if(RequiredAgeRange == null || RequiredGender == null)
            {
                throw new Exception("Required Age or Required Gender is missing");
            }

            if (i_Friend.Gender.Equals(RequiredGender) && isAgeInRequiredAgeRange(age, RequiredAgeRange))
            {
                if (i_Friend.RelationshipStatus.Equals(User.eRelationshipStatus.Single) || i_Friend.RelationshipStatus.Equals(User.eRelationshipStatus.None))
                {
                    isMatch = true;
                }
            }

            return isMatch;
        }

        private static bool isAgeInRange(int i_Min, int i_Max, int i_Age)
        {
            return i_Age >= i_Min && i_Age <= i_Max;
        } 

        private static int getUserAge(string i_Birthday)
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


        private static bool isAgeInRequiredAgeRange(int o_Age, eAgeRange? i_ChosenAgeRange)
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


    }
}
