using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_TASK2.Models
{
    public class Keyboard : Equipment
    {
        public string Format;
        public string Language_supported;
        public string Brand;
        public Keyboard(string name, string description, string format, string language_supported, string brand) : base(name, description)
        {
            Format = format;
            Language_supported = language_supported;
            Brand = brand;
        }
    }
}
