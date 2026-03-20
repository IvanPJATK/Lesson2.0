using APBD_TASK2.Database;
using APBD_TASK2.Enum;
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
            var db = Singleton.Instance;
            List<Equipment> AvailableEquipment = new();
            for(int i = 0; i < db.Equipment.Count; i++)
            {
                if (db.Equipment[i].Status.Equals(EquipmentStatus.Available))
                {
                    AvailableEquipment.Add(db.Equipment[i]);
                }
            }
            return AvailableEquipment;
        }

        public List<Equipment> GetAllEquipment()
        {
            var db = Singleton.Instance;
            return db.Equipment;
        }

        public void setEquipmentStatus(int equipmentId, EquipmentStatus status)
        {
            var db = Singleton.Instance;
            for (int i = 0; i < db.Equipment.Count; i++)
            {
                if (db.Equipment[i].Id.Equals(equipmentId))
                {
                    db.Equipment[i].Status = status;
                }
            }
        }
    }
}
