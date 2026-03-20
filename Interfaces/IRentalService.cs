using APBD_TASK2.Database;
using APBD_TASK2.Enum;
using APBD_TASK2.Models;

namespace APBD_TASK2.Interfaces;

public interface IRentalService
{
    void AddUser(User user);
    void AddEquipment(Equipment equipment);
    List<Equipment> GetAllEquipment();
    List<Equipment> GetAvailableEquipment();
    void setEquipmentStatus(int equipmentId, EquipmentStatus status);
    void CreateReservation(User user, Equipment equipment, DateTime from, DateTime to);
    void CancelReservation(int reservationId);
    int FinishReservation(int reservationId, DateTime currentDate);
    List<ItemRental> GetUserReservations(User user);
    List<ItemRental> GetAll();
}
