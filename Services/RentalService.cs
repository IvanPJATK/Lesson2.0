using APBD_TASK2.Database;
using APBD_TASK2.Enum;
using APBD_TASK2.Interfaces;
using APBD_TASK2.Exceptions;
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
        private readonly List<ItemRental> _rentals = [];

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

        public int CreateReservation(User user, Equipment equipment, DateTime from, DateTime to)
        {
            if (equipment.Status != EquipmentStatus.Available)
            {
                throw new EquipmentUnavailableException(equipment.Id);
            }

            int activeUserReservations = _rentals.Count(reservation =>
                                            !reservation.IsFinished
                                            && reservation.User == user);

            if (activeUserReservations >= user.MaxAciveRentals)
            {
                throw new TooManyRentalsException(activeUserReservations);
            }

            bool reservationConflict = _rentals.Any(reservation =>
                                            !reservation.IsFinished
                                            && reservation.Equipment == equipment
                                            && reservation.Overlaps(from, to));

            if (reservationConflict)
            {
                throw new RentalConflictException(equipment.Id, from, to);
            }

            var newItemRental = new ItemRental(equipment, user, from, to);
            _rentals.Add(newItemRental);
            return newItemRental.Id;
        }

        public void CancelReservation(int reservationId)
        {
            var reservation = _rentals.FirstOrDefault(reservation => reservation.Id == reservationId);

            if (reservation is null)
            {
                throw new RentalNotFoundException(reservationId);
            }

            reservation.Finish();
        }

        public int FinishReservation(int reservationId, DateTime currentDate)
        {
            var reservation = _rentals.FirstOrDefault(reservation => reservation.Id == reservationId);
            int fee = 0;
            if (reservation is null)
            {
                throw new RentalNotFoundException(reservationId);
            }
            if (reservation.IsFinished)
            {
                throw new AlreadyFinishedException(reservationId);
            }
            if (reservation.To < currentDate)
            {
                fee += (currentDate - reservation.To).Days;
                fee *= 10;
            }
            reservation.Finish();
            return fee;
        }

        public List<ItemRental> GetUserReservations(User user)
        {
            return _rentals.Where(reservation => reservation.User == user && !reservation.IsFinished).ToList();
        }

        public List<ItemRental> GetAll()
        {
            return _rentals;
        }
    }
}
