using System;

namespace TeacherLib
{
    public class Teacher
    {
        private int _salary;
        private string _name;
        public static readonly double Pi = Math.PI;

        public Teacher(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Adress { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 2) throw new ArgumentException();
                _name = value;
            }
        }

        public int Salary
        {
            get => _salary;
            set
            {
                //if (value <= 0 || value >= 1000000) throw new ArgumentOutOfRangeException();
                //_salary = value;
                if (0 < value && value < 1000000) _salary = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            return Name + " " + Salary;
        }
    }
}
