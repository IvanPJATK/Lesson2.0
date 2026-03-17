

using APBD_TASK2.Database;
using APBD_TASK2.Models;

var db = Singleton.Instance;

var laptop = new Laptop("Asus Zenbook S14", 16, 14);
db.Equipment.Add(laptop);