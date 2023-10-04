using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class Student
    {
        private long _id;
        private string _Name = string.Empty;
        private string _SecondName = string.Empty;
        private int _Age;
        private float _AvgPoint;

        public Student(string Name, string SecondName, int Age, float AvgPoint)
        {
            if (CheckCorr.Check(Name, SecondName, Age, AvgPoint))
            { 
                _id = Convert.ToInt32(DateTime.Now.Ticks);
                _Name = Name;
                _SecondName = SecondName;
                _Age = Age;
                _AvgPoint = AvgPoint;
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Try better, uncorrect data");
                throw new Exception("Invalid data");
            }
        }

        public string GetName() { return _Name;}

        public int GetAge() { return _Age; }

        public string GetSecondName() { return _SecondName;}

        public float GetAvgPoint() { return _AvgPoint;}

        public long GetId() { return _id;}

        public string TryToChangeName(string Name)
        {
            if (CheckCorr.Check(Name))
            {
                _Name = Name;
                return "Name changed";
            }
            else
            {
                return "Try better, uncorrect data";
            }
        }

        public string TryToChangeSecondName(string SecondName)
        {
            if (CheckCorr.Check(SecondName))
            {
                _SecondName = SecondName;
                return "Second name changed";
            }
            else
            {
                return "Try better, uncorrect data";
            }
        }

        public string TryToCahngeAge(int age)
        {
            if (CheckCorr.Check(age))
            {
                _Age = age;
                return "Age changed";
            }
            else
            {
                return "Try better, uncorrect data";
            }
        }

        public string TryToChangeAvgPoint(float AvgPoint)
        {
            if (CheckCorr.Check(AvgPoint))
            {
                _AvgPoint = AvgPoint;
                return "AvgPoint changed";
            }
            else
            {
                return "Try better, uncorrect data";
            }
        }
    }
}
