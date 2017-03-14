using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_Zajecia_2
{
    class RollsRoyce:ISamochod
    {
        string marka = "RollsRoyce";
        string salon = "Salon RollsRoyce'a";

        public string WypiszMarke()
        {
            return marka;
        }

        public string WypiszSalon()
        {
            return salon;
        }
    }
}
