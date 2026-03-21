using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_TASK2.Models
{
    public class Mouse : Equipment
    {
        public string Size;
        public int MaxDPI;
        public Mouse(string name, string description, string size, int maxDPI) : base(name, description)
        {
            Size = size;
            MaxDPI = maxDPI;
        }
    }
}
