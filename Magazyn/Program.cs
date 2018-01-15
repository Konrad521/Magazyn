using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwę magazynu: ");
            string nazwa = Console.ReadLine();

            Magazyn m = Magazyn.Odczytaj(nazwa);

            while(m == null)
            {
                Console.WriteLine("Brak magazynu. Podaj nazwę jeszcze raz"); 
                nazwa = Console.ReadLine();
            }

            bool koniec = false;

            while (!koniec)
            {
                Console.WriteLine("Wybierz opcję: ");
                Console.WriteLine("1. Pokaż magazyn");
                Console.WriteLine("2. Dodaj narzędzie");
                Console.WriteLine("3. Usuń narzędzie");
                Console.WriteLine("4. Wyjdź z programu");

                string opcja = Console.ReadLine();

                switch (opcja)
                {
                    case "1":
                        Console.Write(m.ToString());
                        break;
                    case "2":
                        DodajNarzedzie(m);
                        break;
                    case "3":
                        UsunNarzedzie(m);
                        break;
                    default:
                        koniec = true;
                        break;
                }
            }

            m.Zapisz();
        }

        private static void UsunNarzedzie(Magazyn m)
        {
            Console.WriteLine("Podaj Nr Seryjny do usunięcia");
            int numer = Int32.Parse(Console.ReadLine());
            m.Usun(numer);
        }

        private static void DodajNarzedzie(Magazyn m)
        {
            Console.WriteLine("Podaj numer seryjny: ");
            int NrSeryjny = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj nazwę: ");
            string Nazwa = Console.ReadLine();
            Console.WriteLine("Podaj cenę: ");
            decimal Cena = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Podaj opis: ");
            string Opis = Console.ReadLine();

            Narzedzie n = new Narzedzie(NrSeryjny, Nazwa, Cena, Opis);
            m.Dodaj(n);
        }
    }
}
