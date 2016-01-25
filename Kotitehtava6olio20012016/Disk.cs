using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava6olio20012016
{
    class Disk : Item
    {
        public string Type { get; set; }

        // default constructor
        public Disk()
        {
        }

        public void DiskWrite()
        {
            Console.WriteLine("Disk data : ");
            Console.WriteLine("- Type : " + Type);
            Console.WriteLine("- Name : " + Name);
            Console.WriteLine("- Condition : " + Condition);
            Console.WriteLine("- Amount : " + Amount);
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " " + Type;
        }
    }

}
