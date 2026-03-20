

using System.Runtime.Intrinsics.Arm;
using APBD_TASK2.Database;
using APBD_TASK2.Enum;
using APBD_TASK2.Models;
using APBD_TASK2.Services;

var db = Singleton.Instance;

var laptop = new Laptop("Asus Zenbook S14", 16, 14);
var student = new Student("John", "Doe", UserType.Student, 2);
var rentalService = new RentalService();
rentalService.AddUser(student);
Console.WriteLine("Added a student " + student.Name + " to equipment");
rentalService.AddEquipment(laptop);
Console.WriteLine("Added a laptop " +laptop.Name+ " to equipment");
rentalService.CreateReservation(student, laptop, new DateTime(2026, 3, 2), new DateTime(2026, 3, 12));
rentalService.setEquipmentStatus(laptop.Id, EquipmentStatus.Rented);
Console.WriteLine("Student: " + student.Name + " has rented a " + laptop.Name + " laptop");
rentalService.CancelReservation(1);
Console.WriteLine("Rental has been canceled");