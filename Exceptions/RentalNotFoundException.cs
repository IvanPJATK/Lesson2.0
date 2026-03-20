using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_TASK2.Exceptions
{
    public class RentalNotFoundException(int renatlId)
    : Exception("Reservation with id " + renatlId + " not found");
}
