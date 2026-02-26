using System;
using System.Collections.Generic;
using System.Text;

namespace Kontroltöö
{
    internal class Alamfunktsioonid
    {
        
        public static void KytuseKalkulaator()
        {
            Console.WriteLine("Palun sisesta oma läbitud teepikkus (km):");
            double teepikkus = int.Parse(Console.ReadLine());
            Console.WriteLine("Mis on sinu kütuse liitri hind?");
            float hind = float.Parse(Console.ReadLine());
            teepikkus = 100;
            double kütusekulu = hind * teepikkus;
            double reisimaksumus = teepikkus * kütusekulu;
            Console.WriteLine($"Kütusekulu: {kütusekulu}, Reisimaksumus: {reisimaksumus}");
            

        }
        
        public static Tuple<double, double> ArvutaPalk(double töötuskindlustus, double Kogumispension)
        {
            Console.WriteLine("kui palju sa teenid?");
            int palk = int.Parse(Console.ReadLine());

            if (palk < 1200)
            {
                Console.WriteLine("Sul on tulumaksuvaba miinimum");
            }
            else if (palk > 1200)
            {
                float tulumaks = palk * 0.8f;
                töötuskindlustus = tulumaks * 0.016f;
                Kogumispension = töötuskindlustus * 0.02f;
                
            }
            return Tuple.Create(töötuskindlustus, Kogumispension);
        }   
        






    }
}
