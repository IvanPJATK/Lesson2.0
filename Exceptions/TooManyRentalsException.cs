using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_TASK2.Exceptions
{
    public class TooManyRentalsException(int userId) 
        : Exception("Too many active reservations for user " + userId);
}