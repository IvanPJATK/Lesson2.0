using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APBD_TASK2.Enum;

namespace APBD_TASK2.Models
{
    public class Student : User
    {
        public int YearOfStudies { get; set; }
        public int studentNumber { get; set; }

        public Student(string name, string surname, UserType type, int yearOfStudies, int studentNumber) : base(name, surname, type)
        {
            YearOfStudies = yearOfStudies;
            this.studentNumber = studentNumber;
        }
    }
}
