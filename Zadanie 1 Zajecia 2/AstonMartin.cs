using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_Zajecia_2
{
    class AstonMartin :ISamochod
    {
        string marka = "AstonMartin";
        string salon = "Salon Astona";

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
