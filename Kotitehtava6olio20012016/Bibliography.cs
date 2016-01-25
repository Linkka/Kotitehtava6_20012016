using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava6olio20012016
{
    class Bibliography : Item
    {
        public string Type { get; set; }
        public int Pages { get; set; }

        // default constructor
        public Bibliography()
        {
        }
        public void BibliographyWrite()
        {
            Console.WriteLine("Bibliographical data : ");
            Console.WriteLine("- Type : " + Type);
            Console.WriteLine("- Name : " + Name);
            Console.WriteLine("- Condition : " + Condition);
            Console.WriteLine("- Amount : " + Amount);
            Console.WriteLine("- Pages : " + Pages);
        }


        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " " + Type + " " + Pages;
        }
    }
}
