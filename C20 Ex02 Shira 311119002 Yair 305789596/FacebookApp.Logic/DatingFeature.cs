using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Globalization;
using System.Threading;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    internal class DatingFeature
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
        internal User.eGender RequiredGender { get; set; }
        internal eAgeRange RequiredAgeRange { get; set; }

        internal DatingFeature()
        {
            createFeature();
        }

        internal void createFeature()
        {
            RequiredAgeRange = eAgeRange.eNoChoice;
        }

        internal int GetUserAge(string i_Birthday)
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

        internal bool AgeInRange(int o_Age, eAgeRange i_ChosenAgeRange)
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

        private bool isAgeInRange(int i_Min, int i_Max, int i_Age)
        {
            return i_Age >= i_Min && i_Age <= i_Max;
        }

        internal bool IsFriendMatchToUserRequests(User i_Friend)
        {
            bool isMatch = false;
            int age = GetUserAge(i_Friend.Birthday);

            if (i_Friend.Gender.Equals(RequiredGender) && AgeInRange(age, RequiredAgeRange))
            {
                if (i_Friend.RelationshipStatus.Equals(User.eRelationshipStatus.Single) || i_Friend.RelationshipStatus.Equals(User.eRelationshipStatus.None))
                {
                    isMatch = true;
                }
            }

            return isMatch;
        }

        internal void setRequiredGender(string i_Gender)
        {

        }

        internal void setAgeRange(eAgeRange i_AgeRange)
        {
            RequiredAgeRange = (eAgeRange)i_AgeRange;

        }

    }
}
