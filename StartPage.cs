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
                        var tulemus = Alamfunktsioonid.KytuseKalkulaator();
                        
                        Console.WriteLine($"kui palju kütust: {tulemus.Item1:F2}");
                        Console.WriteLine($" reisi maksumus: {tulemus.Item2:F2}");
                        break;
                    
                    case "2":

                    break;
                    
                    case "3":

                    break;
                    
                    case "4":

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
