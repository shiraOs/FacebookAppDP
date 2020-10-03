using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public static class DatingFeature
    {
        private static readonly List<Func<User, bool>> r_MatchStrategies = new List<Func<User, bool>>();
        private static User.eGender? m_RequiredGender;
        private static eAgeRange? m_RequiredAgeRange;

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
                return m_RequiredGender;
            }

            set
            {
                if(m_RequiredGender == null)
                {
                    r_MatchStrategies.Add(matchByGender);
                }

                m_RequiredGender = value;
                if(m_RequiredGender == null)
                {
                    r_MatchStrategies.Remove(matchByGender);
                }
            }
        }

        public static eAgeRange? RequiredAgeRange
        {
            get
            {
                return m_RequiredAgeRange;
            }

            set
            {
                if (m_RequiredAgeRange == null)
                {
                    r_MatchStrategies.Add(matchByAge);
                }

                m_RequiredAgeRange = value;
                if (m_RequiredAgeRange == null)
                {
                    r_MatchStrategies.Remove(matchByAge);
                }
            }
        }

        public static void RestartFeature()
        {
            r_MatchStrategies.Clear();
            m_RequiredGender = null;
            m_RequiredAgeRange = null;
        }

        public static bool IsFriendMatchToUserRequests(User i_Friend)
        {
            bool isMatch = false;

            if (isFriendSingle(i_Friend))
            {
                isMatch = true;
                foreach (Func<User, bool> strategy in r_MatchStrategies)
                {
                    if(strategy.Invoke(i_Friend) == false)
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
            if (RequiredGender == null)
            {
                return true;
            }

            return i_Friend.Gender.Equals(RequiredGender);
        }

        private static bool matchByAge(User i_Friend)
        { 
            if(RequiredAgeRange == null)
            {
                return true;
            }

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
