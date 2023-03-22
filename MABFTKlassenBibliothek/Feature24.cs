using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MABFTKlassenBibliothek
{
    class Feature24
    {
        public static void linearefunktionen()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Lineare Funktionen <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
            string menu;


            while (true)
            {
                Console.WriteLine("1. Programm starten");
                Console.WriteLine("2. Programm beenden");
                menu = Console.ReadLine();

                if (menu == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Willkommen zum Lineare Funktionen Programm!");

                    double m, b, x, y;
                    Console.Write("Bitte geben Sie den Wert von m ein: ");
                    m = double.Parse(Console.ReadLine());
                    Console.Write("Bitte geben Sie den Wert von b ein: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Bitte geben Sie den Wert von x ein: ");
                    x = double.Parse(Console.ReadLine());

                    y = m * x + b;
                    Console.WriteLine("Der Wert von y ist: " + y);

                    Console.WriteLine("Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (menu == "2")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
