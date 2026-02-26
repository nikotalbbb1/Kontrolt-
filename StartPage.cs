using System;
using System.Collections.Generic;
using System.Text;

namespace Kontroltöö
{
    internal class StartPage
    {
        public static void Main(string[] args)
        {
            bool tööta = true;

            while (tööta)
            {
                Console.WriteLine("Vali tegevus:\r\n1 - Kütuse kalkulaator\r\n2 - Isikukoodi analüüs\r\n3 - Täringumäng\r\n4 - Palgaarvestus\r\n0 - Välju\r\n");
                string valik = Console.ReadLine();
                switch (valik)
                {
                    case "1":
                        Alamfunktsioonid.KytuseKalkulaator();
                    break;
                        
                    case "2":
                        
                    
                    case "3":
                        
                    break;
                    
                    case "4":
                        var tulemus = Alamfunktsioonid.ArvutaPalk(0, 0);
                        Console.WriteLine("Töötuskindlustus: " + tulemus.Item1);
                        Console.WriteLine("Kogumispension: " + tulemus.Item2);
                        break;

                        break;
                    case "0":
                        tööta = false;
                        Console.WriteLine("Nägemist!");
                        break;

                }

            }
        }
    }
}
