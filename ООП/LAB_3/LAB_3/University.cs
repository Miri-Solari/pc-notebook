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
        private List<long> _idCount = new();

        public string AddStud(Student Stud)
        {
            if (Stud != null)
            {
                _Students.Add(Stud);
                _idCount.Add(Stud.GetIdStud());
                return "Student added";
            }
            else { return "Try better, uncorrect data"; }
        }

        public Student? FindStud(string Name, string SecondName, long Id)
        {

            return Search(Name, SecondName, Id);
        }

        public Human? FindHuman(int id)
        {
            if (_Students.Count > 0)
            {
                if (id != 0)
                {
                    foreach (Student Human in _Students)
                    {
                        if (Human.GetId() == id)
                        {
                            return Human;
                        }
                    }
                }
            }
            return null;
        }

        public Student? FindStud()
        {
            return Search();
        }

        public Student? FindStud(long Id)
        {
            return Search(id: Id);
        }

        private Student? Search(string name = "", string secondName = "", long id = 0)
        {
            // Предположим что все имена и фамилии уникальны
            if (_Students.Count > 0)
            {
                if (id != 0)
                {
                    foreach (Student student in _Students)
                    {
                        if (student.GetIdStud() == id)
                        {
                            return student;
                        }
                    }
                }
                if (name != "")
                {
                    foreach (Student student in _Students)
                    {
                        if (student.GetName() == name)
                        {
                            return student;
                        }
                    }
                }
                if (secondName != "")
                {
                    foreach (Student student in _Students)
                    {
                        if (student.GetSecondName() == secondName)
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
