using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APBD_TASK2.Enum;

namespace APBD_TASK2.Models
{
    internal class Lecturer : User
    {
        public int Salary { get; set; }
        public string Subject { get; set; }
        public Lecturer(string name, string surname, UserType type, int salary, string subject) : base(name, surname, type)
        {
            Salary = salary;
            Subject = subject;
        }
    }
}
