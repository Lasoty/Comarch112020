using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczeniaReferencyjne
{
    interface ISamochod
    {
        int LiczbaDrzwi { get; set; }

        void Zatankuj(int iloscPaliwa);
    }
}
