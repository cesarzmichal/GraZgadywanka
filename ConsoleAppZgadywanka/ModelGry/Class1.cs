using System;

namespace ModelGry
{
    public class Gra    
    {
        int wylosowana;
        int zakresOd;
        int zakresDo;

        //historia

        //konstruktor domyślny
        public Gra()
        {
            zakresOd = 1;
            zakresDo = 100;
            wylosowana = (new Random()).Next(zakresOd, zakresDo + 1);
            // historia = pusta;
        
        }

        // konstruktor ogólny
        public Gra (int min, int max)
        {
            zakresOd = min;
            zakresDo = max;
            wylosowana = (new Random()).Next(zakresOd, zakresDo + 1);
            // historia = pusta;
        }
    }
}
