

using System.Runtime.Intrinsics.Arm;
using APBD_TASK2.Database;
using APBD_TASK2.Enum;
using APBD_TASK2.Models;
using APBD_TASK2.Services;

var db = Singleton.Instance;

var laptop = new Laptop("Asus Zenbook S14", 16, 14);
var mouse = new Mouse("Razer Basilisk V2", "Nicely shaped wired mouse", "Big", 20000);
var keyborad = new Keyboard("Logitech G515 Lightspeed","A low profile mechanical keyboard", "TKL", "English, Ukrainian");

var student213 = new Student("John", "Doe", UserType.Student, 2, 213);
var student110 = new Student("Maria", "Schwarzenegger", UserType.Student, 1, 110);
var student404 = new Student("Jack", "Septiceye", UserType.Student, 4, 404);
var lecturer = new Lecturer("Lech", "Krzyżanowski", UserType.Lecturer, 5000, "PE");

var rentalService = new RentalService();

rentalService.AddUser(student213);
rentalService.AddUser(student110);
rentalService.AddUser(student404);
rentalService.AddUser(lecturer);

rentalService.AddEquipment(laptop);
rentalService.AddEquipment(mouse);
rentalService.AddEquipment(keyborad);

//A correct rental operation
int reservationId = rentalService.CreateReservation(student213, laptop, new DateTime(2026, 3, 2), new DateTime(2026, 3, 12));
rentalService.setEquipmentStatus(laptop.Id, EquipmentStatus.Rented); //example with conflict will work without this too, just a different exception will be thrown
Console.WriteLine(student213.Name + " has rented a " + laptop.Name);

//An attempted invalid operation
//Console.WriteLine("Lecturer: " + lecturer.Name + " tried to rent a " + laptop.Name + " laptop");
//rentalService.CreateReservation(lecturer, laptop, new DateTime(2026, 3, 4), new DateTime(2026, 3, 8));

//A return completed on time
int penalty = rentalService.FinishReservation(reservationId, new DateTime(2026, 3, 11));
Console.WriteLine(student213.Name + " has returned a " + laptop.Name + " with " + penalty + " penalty");

//A delayed return that leads to a penalty
int reservationId2 = rentalService.CreateReservation(student404, keyborad, new DateTime(2026, 3, 6), new DateTime(2026, 3, 7));
Console.WriteLine(student404.Name + " has rented a " + keyborad.Name);
int penalty2 = rentalService.FinishReservation(reservationId2, new DateTime(2026, 3, 12));
Console.WriteLine(student404.Name + " has returned a " + keyborad.Name + " with " + penalty2 + " penalty");

//Displaying a final report of the system state
int reservationId3 = rentalService.CreateReservation(student110, mouse, new DateTime(2026, 3, 11), new DateTime(2026, 3, 21));

List<ItemRental> rentals = rentalService.GetAll();
for(int i = 0; i < rentals.Count; i++)
{
    Console.WriteLine(rentals[i].ToString());
}