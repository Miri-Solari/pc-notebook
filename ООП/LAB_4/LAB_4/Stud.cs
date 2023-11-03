using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    internal class Stud
    {
        internal string? Name { get; set; }

        private string _secondName = "";
        private int _age = 0;
        internal string SecondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }
        internal int Age
        {
            get { return _age; }
            set
            {
                if (value < 0) { value = 0; }
                _age = value;
            }
        }

        internal bool IsStudentDependOnAge
        {
            get { return Age < 25; }
        }

        internal string GetInfo()
        {
            return $"{Name} {SecondName} {Age} {IsStudentDependOnAge}";
        }

        internal string GetInfo(bool includeIntProperty)
        {
            if (includeIntProperty)
            {
                return $"{Name} {SecondName} {Age} {IsStudentDependOnAge}";
            }
            return $"{Name} {SecondName} {IsStudentDependOnAge}";
        }

    }
}
