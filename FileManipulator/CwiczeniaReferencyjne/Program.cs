using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczeniaReferencyjne
{
    class Program
    {
        static void Main(string[] args)
        {
            Kolor kolor;
            kolor.Nazwa = "czerwony";
            kolor.Rodzaj = TypKoloru.Metalic;

            Samochod ford = new Samochod();
            ford.Kolor = kolor;
            Console.WriteLine(ford.Kolor);

            Samochod skoda = new Samochod();
            skoda.Kolor.Nazwa = "Niebieski";
            Console.WriteLine(ford.Kolor);

            ZmienKolor(skoda, "zielony");
            Console.WriteLine(ford.Kolor);

            //Samochod vw = null;
            //vw.LiczbaDrzwi = 4;

            Osobowy citroen = new Osobowy();
            citroen.LiczbaMiejscSiedzacych = 5;
            Console.WriteLine("Liczba miejsc siedzących: " + citroen.LiczbaMiejscSiedzacych);

            Samochod cytryna = citroen;
            cytryna.Kolor.Nazwa = "czarny";

            ZmienKolor(citroen, "czarny");

            Osobowy cytryna2 = (Osobowy)cytryna;
            Console.WriteLine(cytryna2.Kolor.Nazwa);

            ZatankujAuto(ford);
            ZatankujAuto(citroen);
            ZatankujAuto(skoda);
        }

        private static void ZmienKolor(Samochod samochod, string kolor)
        {
            samochod.Kolor.Nazwa = kolor;
        }

        private static void ZatankujAuto(ISamochod samochod)
        {
            samochod.Zatankuj(40);
        }
    }
}
