using APBD_TASK2.Database;
using APBD_TASK2.Interfaces;
using APBD_TASK2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_TASK2.Services
{
    internal class RentalService : IRentalService
    {
        public void AddEquipment(Equipment equipment)
        {
            var db = Singleton.Instance;
            db.Equipment.Add(equipment);
        }

        public void AddUser(User user)
        {
            var db = Singleton.Instance;
            db.Users.Add(user);
        }

        public List<Equipment> GetAvailableEquipment()
        {
            throw new NotImplementedException();
        }

        public List<Equipment> GetAllEquipment()
        {
            var db = Singleton.Instance;
            return db.Equipment;
        }
    }
}
