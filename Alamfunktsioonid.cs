using System;
using System.Collections.Generic;
using System.Text;

namespace Kontroltöö
{
    internal class Alamfunktsioonid
    {
        
        public static Tuple<double, double> KytuseKalkulaator()
        {
            Console.WriteLine("Palun sisesta oma läbitud teepikkus (km):");
            int teepikkus = int.Parse(Console.ReadLine());
            Console.WriteLine("Mis on sinu kütuse liitri hind?");
            float hind = float.Parse(Console.ReadLine());
            teepikkus = 100;
            double kütusekulu = hind * teepikkus;
            double reisimaksumus = teepikkus * kütusekulu;
            
            return Tuple.Create(kütusekulu, reisimaksumus);

        }
        
        public static string HindaIsikukood()
        {
            Console.WriteLine("Sisesta oma isikukood");
             int isikukood = int.Parse(Console.ReadLine());
            if (isikukood.Length < 11 )
            {

            }
        }






    }
}
