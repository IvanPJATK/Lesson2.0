using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_TASK2.Models
{
    public class Laptop : Equipment
    {
        public Laptop(string name, int ram, int screensize) : base(name)
        {
            RAMGb = ram;
            ScreenSize = screensize;
        }
        public int RAMGb { set; get; }
        public int ScreenSize{get; set;}

    }
}
