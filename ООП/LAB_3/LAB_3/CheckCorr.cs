using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LAB_3
{
    internal partial class CheckCorr
    {
        [GeneratedRegex("^[\\p{L}]+$")]
        private static partial Regex GenRegex();
        public static bool Check()
        {
            return false;
        }

        public static bool Check(string Name, string SecondName, int Age, float AvgPoint) 
        {
            return Check(Name) & Check(SecondName) & Check(Age) & Check(AvgPoint);
        }

        public static bool Check(string Name)
        {
            return GenRegex().IsMatch(Name);
        }

        public static bool Check(int Age)
        {
            return Age >= 11 & Age <= 140;
        }

        public static bool Check(float AvgPoint) 
        {
            return AvgPoint <= 5f & AvgPoint >= 0f;
        }

        public static bool Check(string Name, string SecondName)
        {
            return Check(Name) & Check(SecondName);
        }

        public static bool Check(string Name, int Age)
        {
            return Check(Name) & Check(Age);
        }

        public static bool Check(string Name, float AvgPoint)
        {
            return Check(Name) & Check(AvgPoint);
        }

        public static bool Check(string Name, string SecondName, float AvgPoint)
        {
            return Check(Name) & Check(SecondName) & Check(AvgPoint);
        }

        public static bool Check(string Name, string SecondName, int Age)
        {
            return Check(Name) & Check(SecondName) & Check(Age);
        }

        public static bool Check(string Name, int Age, float AvgPoint)
        {
            return Check(Name) & Check(Age) & Check(AvgPoint);
        }

        public static bool Check(int Age, float AvgPoint)
        {
            return Check(Age) & Check(AvgPoint);
        }
    }
}
