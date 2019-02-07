using System;
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

            //Dopóki nie trafiono
            // 2. Człowiek podaje propozycję
            Console.Write("Podaj propozycję: ");
            int propozycja = Convert.ToInt32(Console.ReadLine());

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
            }

            //koniec dopóki

            // 4. Zakończenie gry
        }
    }
}
