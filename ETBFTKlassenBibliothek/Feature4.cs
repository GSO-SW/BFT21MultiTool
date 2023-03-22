using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETBFTKlassenBibliothek
{
    internal class Feature4
    {
        public static void Feature_4()
        {
            bool exit = false;
            while (!exit)
            {
                int auswahl;
                double quellspannung, widerstand, strom, spannungsabfall;
                Console.Clear();
                Console.WriteLine("Was möchten Sie berechnen:");
                Console.WriteLine("1. Spannungsteiler");
                Console.WriteLine("2. Leistungsbilanz");
                Console.WriteLine("Geben Sie 'exit' ein, um das Programm zu beenden.");

                string eingabe = Console.ReadLine();

                if (eingabe.ToLower() == "exit")
                {
                    exit = true;
                    break;
                }

                if (int.TryParse(eingabe, out auswahl))
                {
                    switch (auswahl)
                    {
                        case 1:
                            Console.WriteLine("Sie haben 'Spannungsteiler' gewählt.");
                            Console.WriteLine("Bitte geben Sie die Quellspannung in Volt ein:");
                            quellspannung = double.Parse(Console.ReadLine());
                            Console.WriteLine("Bitte geben Sie den Widerstand R1 in Ohm ein:");
                            double r1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Bitte geben Sie den Widerstand R2 in Ohm ein:");
                            double r2 = double.Parse(Console.ReadLine());
                            spannungsabfall = quellspannung * (r2 / (r1 + r2));
                            Console.WriteLine("Der Spannungsabfall beträgt: " + spannungsabfall + " Volt");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Sie haben 'Leistungsbilanz' gewählt.");
                            Console.WriteLine("Bitte geben Sie die Quellspannung in Volt ein:");
                            quellspannung = double.Parse(Console.ReadLine());
                            Console.WriteLine("Bitte geben Sie den Strom in Ampere ein:");
                            strom = double.Parse(Console.ReadLine());
                            Console.WriteLine("Bitte geben Sie den Widerstand in Ohm ein:");
                            widerstand = double.Parse(Console.ReadLine());
                            spannungsabfall = quellspannung - (strom * widerstand);
                            Console.WriteLine("Der Spannungsabfall beträgt: " + spannungsabfall + " Volt");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Ungültige Auswahl!");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe!");
                }
            }
        }
    }
}





        

    



