using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_Zajecia_2
{
    class RangeRover:ISamochod
    {
        string marka = "RangeRover";
        string salon = "Salon RangeRovera";

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
