using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_TASK2.Exceptions
{
    public class AlreadyFinishedException(int reservationId)
        : Exception("Reservation with Id " + reservationId + " is already finished.");
}
