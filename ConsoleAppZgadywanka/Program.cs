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
        static int Losuj(int min = 1, int max = 100)
        {
            if (min > max)
                {
                min = 1;
                max = 101;
            }
            Console.WriteLine($"Losuję {min} do {max} \n odgadnij ją");
            return (new Random().Next(min, max + 1));
        }

        static int Wczytajliczbe(string prompt)
        {
            bool poprawnie = false;
            int liczba = 0;

            while (!poprawnie)
            {
                string napis = "";
                Console.Write(prompt);
                try
                {
                    napis = Console.ReadLine();
                    if (napis.ToUpper() == "X")
                    {
                        Console.WriteLine("Aplikacja przerwana na polecenie uzytkownika");
                        Environment.Exit(1);
                    }

                    liczba = Convert.ToInt32(napis);
                    poprawnie = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("podałeś zbyt dużą liczbę - spróbuj jeszcze raz");
                    continue;
                    // throw new OverflowException(); //podaj dalej
                }

                catch (FormatException)
                {
                    Console.WriteLine("nie podałeś poprawnej liczby - koniec programu");
                    continue;
                }
            }
            return liczba;
        }
        static void Main()
        {
            // 1. Komputer losuje liczbę
            Console.WriteLine("podaj zakres losowania liczby do odgadnięcia");

            int min = Wczytajliczbe("podaj wartość od:");
            int max = Wczytajliczbe("podaj wartość do:");
            
            int wylosowana = (new Random()).Next(min, max);

#if DEBUG      
            Console.WriteLine("Tajne " + wylosowana);
#endif           

            Stopwatch stopper = Stopwatch.StartNew();
            int licznik = 0;
            bool trafiono = false;

            
            //Dopóki nie trafiono
            while (!trafiono)
            {
                // 2. Człowiek podaje propozycję
                int propozycja = Wczytajliczbe("Podaj swoją propozycję: ");


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
