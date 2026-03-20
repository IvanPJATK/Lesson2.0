using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_TASK2.Exceptions
{
    public class RentalConflictException(int roomId, DateTime from, DateTime to)
        : Exception("Room " + roomId + " is already reserved for the period from " + from + " to " + to);
}
