using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava6olio20012016
{
    class Device : Item
    {
        public string Manufacturer { get; set; }
        public string Color { get; set; }

        // default constructor
        public Device()
        {
        }
        public void DeviceWrite()
        {
            Console.WriteLine("Device data : ");
            Console.WriteLine("- Manufacturer : " + Manufacturer);
            Console.WriteLine("- Name : " + Name);
            Console.WriteLine("- Color : " + Color);
            Console.WriteLine("- Condition : " + Condition);
            Console.WriteLine("- Amount : " + Amount);
        }
        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " " + Manufacturer + " " + Color;
        }
    }
}
