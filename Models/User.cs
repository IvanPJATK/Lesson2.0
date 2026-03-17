using APBD_TASK2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_TASK2.Models
{
    public class User
    {
        public static int _nextId = 1;

        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public UserType UserType { get; set; }

        public int MaxAciveRentals => UserType switch
        {
            UserType.Student => 2,
            UserType.Employee => 5,
            _ => 0
        };
        public User() 
        {
            Id = _nextId++;
        }
    }
}
