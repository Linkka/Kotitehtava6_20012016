using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava6olio20012016
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one Person object
            Bibliography book = new Bibliography();
            book.Type = "Kirja";
            book.Name = "Raamattu";
            book.Condition = "Ok";
            book.Amount = 1;
            book.Pages = 1000;

            Bibliography magazine = new Bibliography();
            magazine.Type = "Lehti";
            magazine.Name = "Aku Ankka";
            magazine.Condition = "Uusi";
            magazine.Amount = 10;
            magazine.Pages = 50;

            Disk cd = new Disk();
            cd.Type = "CD-Levy";
            cd.Name = "Hiren's Boot CD";
            cd.Condition = "Hyva";
            cd.Amount = 1;

            Disk dvd = new Disk();
            dvd.Type = "DVD-Levy";
            dvd.Name = "Leffoja";
            dvd.Condition = "Hyva";
            dvd.Amount = 15;

            Disk bluray = new Disk();
            bluray.Type = "Bluray-Levy";
            bluray.Name = "Leffoja";
            bluray.Condition = "Hyva";
            bluray.Amount = 6;

            Device phone = new Device();
            phone.Manufacturer = "Microsoft";
            phone.Name = "Lumia 640";
            phone.Color = "Orange";
            phone.Condition = "Hyva";
            phone.Amount = 1;

            Device tablet = new Device();
            tablet.Manufacturer = "ASUS";
            tablet.Name = "N/A";
            tablet.Color = "Silver";
            tablet.Condition = "Hyva";
            tablet.Amount = 1;

            Device laptop = new Device();
            laptop.Manufacturer = "N/A";
            laptop.Name = "N/A";
            laptop.Color = "N/A";
            laptop.Condition = "N/A";
            laptop.Amount = 1;



            // do something methods
            book.BibliographyWrite();
            Console.ReadLine();
            magazine.BibliographyWrite();
            Console.ReadLine();
            cd.DiskWrite();
            Console.ReadLine();
            dvd.DiskWrite();
            Console.ReadLine();
            bluray.DiskWrite();
            Console.ReadLine();
            phone.DeviceWrite();
            Console.ReadLine();
            tablet.DeviceWrite();
            Console.ReadLine();
            laptop.DeviceWrite();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
        }
    }

}
