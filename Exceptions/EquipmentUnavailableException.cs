using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_TASK2.Exceptions
{
    public class EquipmentUnavailableException(int roomId) 
        : Exception("Room with id " + roomId + " is not available.");
}
