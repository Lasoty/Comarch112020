using System;
using System.IO;
using System.Windows.Forms;

namespace FileManipulator
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1. Zapisz dane do pliku");
                Console.WriteLine("2. Odczyt danych z pliku");

                if (int.TryParse(Console.ReadLine(), out int wybor))
                {
                    switch (wybor)
                    {
                        case 1:
                            string tekstDoZapisu = PokazEdytorTekstu();
                            ZapisDoPliku(tekstDoZapisu);
                            break;
                        case 2:
                            OdczytZPliku();
                            break;
                        default:
                            break;
                    }
                } 
            } while (true);
        }

        private static string PokazEdytorTekstu()
        {
            Console.Clear();
            return Console.ReadLine();
        }

        private static void OdczytZPliku()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki tekstowe (.txt)|*.txt|Wszystkie pliki |*.*";

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                //if (File.Exists(ofd.FileName))
                //{
                    try
                    {
                        string zawartoscPliku = File.ReadAllText(ofd.FileName);
                        PokazZawartosc(zawartoscPliku);
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("Nie znaleziono pliku o podanej nazwie.");

                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Ścieżka do pliku jest pusta.");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wystąpił błąd otwarcia pliku.");
                    }
                    finally
                    {
                        Console.WriteLine("Zakończono odczyt z pliku.");
                    }
                //}
            }
        }

        private static void PokazZawartosc(string zawartoscPliku)
        {
            Console.Clear();
            Console.WriteLine(zawartoscPliku);
            Console.ReadLine();
        }

        private static void ZapisDoPliku(string tekst)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pliki tekstowe (.txt)|*.txt";

            var result = sfd.ShowDialog();

            if (result == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, tekst);
            }
        }
    }
}
