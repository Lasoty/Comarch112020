using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ponow;
            do
            {
                PokazMenu();

                Console.Write("Wybierz opcję: ");
                string wyborString = Console.ReadLine();
                int wyborInt;
                int.TryParse(wyborString, out wyborInt);

                Console.Clear();
                int x = 0, y = 0;
                bool dobryX = false, dobryY = false;
                float wynik = default;
                bool pokazWynik = true;

                if (wyborInt > 0 && wyborInt <= 5)
                {
                    Console.Write("Podak pierwszą liczbę: ");
                    dobryX = int.TryParse(Console.ReadLine(), out x);

                    Console.Write("Podak drugą liczbę: ");
                    dobryY = int.TryParse(Console.ReadLine(), out y);
                }

                if (dobryX && dobryY)
                {
                    switch (wyborInt)
                    {
                        case 1:
                            wynik = Dodawanie(x, y);
                            break;
                        case 2:
                            wynik = x - y;
                            break;
                        case 3:
                            wynik = x * y;
                            break;
                        case 4:
                            wynik = x / (float)y;
                            break;
                        case 5:
                            wynik = x % y;
                            break;
                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wprowadzona wartość jest nieprawidłowa.");
                            Console.ResetColor();
                            pokazWynik = false;
                            break;
                    }
                }
                else
                {
                    pokazWynik = false;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wprowadzona wartość X lub Y jest nieprawidłowa.");
                    Console.ResetColor();
                    Console.ReadLine();
                }

                Console.Clear();
                if (pokazWynik)
                {
                    Console.WriteLine("Wynik operacji to: " + wynik);
                    Console.ReadLine();
                    Console.Clear();
                }

                Console.Write("Czy chcesz wykonać kolejną operację? [T | n]");
                ponow = Console.ReadKey().Key != ConsoleKey.N;
            } while (ponow);
        }

        private static float Dodawanie(int x, int y)
        {
            return x + y;
        }

        private static void PokazMenu()
        {
            Console.Clear();
            Console.WriteLine("KALKULATOR v1.0");
            Console.WriteLine("MENU: ");
            Console.WriteLine("  1. Dodawanie");
            Console.WriteLine("  2. Odejmowanie");
            Console.WriteLine("  3. Mnożenie");
            Console.WriteLine("  4. Dzielenie");
            Console.WriteLine("  5. Modulo");
        }
    }
}
