using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_TASK2.Models
{
    public class ItemRental(Equipment equipment, User user, DateTime from, DateTime to)
    {
        private static int _nextId = 1;

        public int Id { get; set; } = _nextId++;
        public Equipment Equipment { get; set; } = equipment;
        public User User { get; set; } = user;
        public DateTime From { get; set; } = from >= to ? throw new ArgumentException("Invalid time range") : from;
        public DateTime To { get; set; } = to;
        public bool IsFinished { get; private set; } = false;

        public void Finish()
        {
            IsFinished = true;
        }

        public bool Overlaps(DateTime from, DateTime to)
        {
            return !(From > to || from > To);
        }
    }
}
