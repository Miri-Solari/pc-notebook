using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class University
    {
        private List<Student> _Students = new();

        public string AddStud(Student Stud)
        {
            if (Stud != null)
            {
                _Students.Add(Stud);
                return "Student added";
            }
            else { return "Try better, uncorrect data"; }
        }

        public Student? FindStud(string Name, string SecondName, long Id)
        {

            return Search(Name, SecondName, Id);
        }

        public Student? FindStud()
        {
            return Search();
        }

        public Student? FindStud(long Id)
        {
            return Search(Id: Id);
        }

        private Student? Search(string Name = "", string SecondName = "", long Id = 0)
        {
            // Предположим что все имена и фамилии уникальны
            if (_Students.Count > 0)
            {
                if (Id != 0)
                {
                    foreach (Student student in _Students)
                    {
                        if (student.GetId() == Id)
                        {
                            return student;
                        }
                    }
                }
                if (Name != "")
                {
                    foreach (Student student in _Students)
                    {
                        if (student.GetName() == Name)
                        {
                            return student;
                        }
                    }
                }
                if (SecondName != "")
                {
                    foreach (Student student in _Students)
                    {
                        if (student.GetSecondName() == SecondName)
                        {
                            return student;
                        }
                    }
                }
                
            }
            return null;
        }
    }
}
