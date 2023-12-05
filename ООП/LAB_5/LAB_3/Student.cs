using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class Student : Human
    {
        private long _idStud;
        private string _nameStud = string.Empty;
        private string _secondNameStud = string.Empty;
        private int _Age;
        private float _AvgPoint;

        public Student(string name, string secondName, int age, float avgPoint, DateTime birdthDate, int hieght, bool marry)
            :base (name, secondName, birdthDate, hieght, marry)
        {

            if (CheckCorr.Check(name, secondName, age, avgPoint))
            {
                _idStud = Convert.ToInt32(DateTime.Now.Ticks);
                _nameStud = name;
                _secondNameStud = secondName;
                _Age = age;
                _AvgPoint = avgPoint;
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Try better, uncorrect data");
                throw new Exception("Invalid data");
            }
        }

        public string GetName() { return _nameStud;}

        public int GetAge() { return _Age; }

        public string GetSecondName() { return _secondNameStud;}

        public float GetAvgPoint() { return _AvgPoint;}

        public long GetIdStud() { return _idStud;}

        public string TryToChangeName(string Name)
        {
            if (CheckCorr.Check(Name))
            {
                _nameStud = Name;
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
                _secondNameStud = SecondName;
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
