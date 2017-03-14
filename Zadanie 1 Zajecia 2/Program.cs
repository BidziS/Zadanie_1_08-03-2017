using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_Zajecia_2
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeRover rangeRover = new RangeRover();
            RollsRoyce rollsRoyce = new RollsRoyce();
            AstonMartin astonMartin = new AstonMartin();

            Console.WriteLine(astonMartin.WypiszMarke());
            Console.WriteLine(astonMartin.WypiszSalon());

            Console.WriteLine(rollsRoyce.WypiszMarke());
            Console.WriteLine(rollsRoyce.WypiszSalon());

            Console.WriteLine(rangeRover.WypiszMarke());
            Console.WriteLine(rangeRover.WypiszSalon());

            Console.ReadLine();
        }
    }
}
