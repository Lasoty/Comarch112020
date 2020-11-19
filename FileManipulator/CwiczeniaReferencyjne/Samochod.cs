using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczeniaReferencyjne
{
    public class Samochod : ISamochod, IDisposable
    {
        public Kolor Kolor;
        internal float SrednieSpalanie;

        public int LiczbaDrzwi { get; set; }

        public void Dispose()
        {
        }

        public void Uruchom()
        {

        }


        internal void Zatankuj(int iloscPaliwa)
        {

        }

        void ISamochod.Zatankuj(int iloscPaliwa)
        {
            throw new NotImplementedException();
        }
    }
}
