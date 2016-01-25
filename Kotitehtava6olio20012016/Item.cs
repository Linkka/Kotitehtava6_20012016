using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava6olio20012016
{
    class Item
    {
        public string Name { get; set; }
        public string Condition { get; set; }
        public int Amount { get; set; }


        // return Item data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return Name + " " + Condition + " " + Amount;
        }
    }

}
