using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MABFTKlassenBibliothek
{
    class Feature22
    {
        public static void flachenberechnung()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Flächenberechnung <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("Willkommen in der Unterkategorie Flächen- und Umfangberechnung!\n" +
                "Wählen sie eine Form aus, indem sie die zugehörige Zahl eingeben und Enter drücken.:\n" +
                "1 - Quadrat\n" +
                "2 - Rechteck\n" +
                "3 - Parallelogramm\n" +
                "4 - Trapez\n" +
                "5 - Dreieck\n" +
                "6 - Drachen\n" +
                "7 - Raute\n" +
                "8 - Drachenviereck\n" +
                "9 - Kreis\n" +
                "Tipp: mit der Eingabe des Wortes exit können sie das programm jederzeit verlassen.");
            string Smenu = Console.ReadLine();
            
            if (Smenu == "exit")
            {
                Environment.Exit(0);
            }

            int menu = Convert.ToInt32(Smenu);
            if (menu == 1)
            {
                Console.WriteLine("Geben sie die Länge oder die Breite ein.");
                string one = Console.ReadLine();
                if (one == "exit")
                {
                    Environment.Exit(0);
                }
                int oneQ = Convert.ToInt32(one);
                Console.WriteLine($"Die Fläche beträgt:{oneQ*oneQ}__²");
            }
            if (menu == 2)
            {
                Console.WriteLine("Geben sie die Länge ein.");
                string two = Console.ReadLine();
                if (two == "exit")
                {
                    Environment.Exit(0);
                }
                int twoQ = Convert.ToInt32(two);
            }
            if (menu == 3)
            {
                string three = Console.ReadLine();
                if (three == "exit")
                {
                    Environment.Exit(0);
                }
                int threeQ = Convert.ToInt32(three);
            }
            if (menu == 4)
            {
                string four = Console.ReadLine();
                if (four == "exit")
                {
                    Environment.Exit(0);
                }
                int fourQ = Convert.ToInt32(four);
            }
            if (menu == 5)
            {
                string five = Console.ReadLine();
                if (five == "exit")
                {
                    Environment.Exit(0);
                }
                int fiveQ = Convert.ToInt32(five);
            }
            if (menu == 6)
            {
                string six = Console.ReadLine();
                if (six == "exit")
                {
                    Environment.Exit(0);
                }
                int sixQ = Convert.ToInt32(six);
            }
            if (menu == 7)
            {
                
            }
            if (menu == 8)
            {

            }
            if (menu == 9)
            {

            }
            else if (menu <1 || menu >9 )
            {
                Console.WriteLine("Falsche Eingabe, bitte versuchen sie es nochmal");
            }





            Console.ReadLine();
        }
    }
}
