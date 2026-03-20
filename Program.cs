

using System.Runtime.Intrinsics.Arm;
using APBD_TASK2.Database;
using APBD_TASK2.Enum;
using APBD_TASK2.Models;

var db = Singleton.Instance;

var laptop = new Laptop("Asus Zenbook S14", 16, 14);
db.Equipment.Add(laptop);
Console.WriteLine("Added a laptop to equipment");
var student = new Student("John", "Doe", UserType.Student, 2);
db.Users.Add(student);