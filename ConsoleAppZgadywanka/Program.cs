using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppZgadywanka
{

    /// <summary>
    /// Gra Za dużo za mało. Komputer losuje liczbę z podanego zakresu.
    /// Człowiek odgaduje wylosowaną liczbę podając swoje propozycje.
    /// Komputer odpowiada: ZA DUŻO. ZA MAŁO, TRAFIONO
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Komputer losuje liczbę od 1 do 100
            int wylosowana = (new Random()).Next(1, 101);
            Console.WriteLine(wylosowana);
            Console.WriteLine("Wylosowałem liczbę od 1 do 100 \n odgadnij ją");

            Stopwatch stopper = Stopwatch.StartNew();
            int licznik = 0;
            bool trafiono = false;

            
            //Dopóki nie trafiono
            while (!trafiono)
            {
                int propozycja = 0;

                // 2. Człowiek podaje propozycję
                Console.Write("Podaj propozycję: ");

                try
                {
                   propozycja = Convert.ToInt32(Console.ReadLine());
                }
                catch(OverflowException)
                {
                    Console.WriteLine(  "podałeś zbyt dużą liczbę - koniec programu");
                    break;
                }

                catch(FormatException)
                {
                    Console.WriteLine("pnie podałeś poprawnej liczby - koniec programu");
                    continue;
                }

                // 3. Komputer ocenia propozycję
                if (propozycja < wylosowana)
                {
                    Console.WriteLine("ZA MAŁO");
                }
                else if (propozycja > wylosowana)
                {
                    Console.WriteLine("ZA DUŻO");
                }
                else
                {
                     Console.WriteLine("TRAFIONO");
                    trafiono = true;
                }
                licznik++;
                

            }//koniec dopóki
            stopper.Stop();

            // 4. Zakończenie gry


            Console.WriteLine("Koniec gry");
            Console.WriteLine($"wykonano {licznik} ruchów");
            Console.WriteLine($"czas gry = {stopper.Elapsed}");
        }
    }
}
