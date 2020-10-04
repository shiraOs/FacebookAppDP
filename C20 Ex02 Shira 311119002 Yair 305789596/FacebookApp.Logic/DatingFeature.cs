using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public static class DatingFeature
    {
        private static readonly List<Func<User, bool>> sr_MatchStrategies = new List<Func<User, bool>>();
        private static User.eGender? s_RequiredGender;
        private static eAgeRange? s_RequiredAgeRange;

        public enum eAgeRange
        {
            eFiftheenTilEighteen,
            eNineteenTilTweenythree,
            eTweenyFourTilThirty,
            eThirtyTilFourty,
            eFourtyPlus
        }

        public static User.eGender? RequiredGender 
        { 
            get
            {
                return s_RequiredGender;
            }

            set
            {
                setStrategy(value, s_RequiredGender, matchByGender);
                s_RequiredGender = value;
            }
        }

        public static eAgeRange? RequiredAgeRange
        {
            get
            {
                return s_RequiredAgeRange;
            }

            set
            {
                setStrategy(value, s_RequiredAgeRange, matchByAge);
                s_RequiredAgeRange = value;
            }
        }
        
        private static void setStrategy(object i_NewValue, object i_OldValue, Func<User, bool> i_Strategy)
        {
            if (i_NewValue == null)
            {
                sr_MatchStrategies.Remove(i_Strategy);
            }
            else if (i_OldValue == null)
            {
                sr_MatchStrategies.Add(i_Strategy);
            }
        }

        public static void RestartFeature()
        {
            sr_MatchStrategies.Clear();
            s_RequiredGender = null;
            s_RequiredAgeRange = null;
        }

        public static bool IsFriendMatchToUserRequests(User o_Friend)
        {
            bool isMatch = false;

            if (isFriendSingle(o_Friend))
            {
                isMatch = true;
                foreach (Func<User, bool> strategy in sr_MatchStrategies)
                {
                    if(strategy.Invoke(o_Friend) == false)
                    {
                        isMatch = false;
                        break;
                    }
                }
            }

            return isMatch;
        }

        private static bool isAgeInRange(int i_Min, int i_Max, int i_Age)
        {
            return i_Age >= i_Min && i_Age <= i_Max;
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

        private static bool matchByGender(User i_Friend)
        {
            return i_Friend.Gender.Equals(RequiredGender);
        }

        private static bool matchByAge(User i_Friend)
        {
            return isAgeInRequiredAgeRange(Utils.GetUserAge(i_Friend.Birthday), RequiredAgeRange);
        }

        private static bool isFriendSingle(User i_Friend)
        {
            return i_Friend.RelationshipStatus.Equals(User.eRelationshipStatus.Single) || i_Friend.RelationshipStatus.Equals(User.eRelationshipStatus.None);
        }

        public static User.eGender? ParseGender(string i_Text)
        {
            User.eGender? result = null;
            if (i_Text.Equals("Male"))
            {
                result = User.eGender.male;
            }

            if (i_Text.Equals("Female"))
            {
                result = User.eGender.female;
            }

            return result;
        }
    }
}
