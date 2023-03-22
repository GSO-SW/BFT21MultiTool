using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETBFTKlassenBibliothek
{
    internal class Feature1
    {
        public static void Feature_1()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            double spannung = 0, widerstand = 0, zeit = 0;
            double strom = 0, energie = 0, ladung = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Was möchtest du berechnen? Gib eine der folgenden Optionen ein:\n\n" +
                                  "1. Stromstärke\n\n" +
                                  "2. Energieverbrauch\n\n" +
                                  "3. Ladungsmenge in Zeit\n\n" +
                                  "Oder gib 'exit' zum Beenden ein.");

                string auswahl = Console.ReadLine();

                if (auswahl == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Beende das Programm");
                    break;
                }

                Console.Clear();
                Console.WriteLine("Bitte gib die folgenden Werte ein:\n");

                try
                {
                    Console.Write("Spannung in Volt: ");
                    spannung = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
                    Console.ReadKey();
                    continue;
                }

                try
                {
                    Console.Write("Widerstand in Ohm: ");
                    widerstand = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
                    Console.ReadKey();
                    continue;
                }

                if (auswahl == "1")
                {
                    strom = spannung / widerstand;
                    Console.WriteLine("\nStromstärke: {0} Ampere", strom);
                }
                else if (auswahl == "2")
                {
                    strom = spannung / widerstand;
                    energie = spannung * strom;
                    Console.WriteLine("\nEnergieverbrauch: {0} Joule", energie);
                }
                else if (auswahl == "3")
                {
                    try
                    {
                        Console.Write("Zeit in Sekunden: ");
                        zeit = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
                        Console.ReadKey();
                        continue;
                    }

                    strom = spannung / widerstand;
                    ladung = strom * zeit;
                    Console.WriteLine("\nLadungsmenge: {0} Coulomb", ladung);
                }
                else
                {
                    Console.WriteLine("\nUngültige Eingabe. Bitte versuche es erneut.");
                    continue;
                }

                Console.WriteLine("\nDrücke eine beliebige Taste, um fortzufahren.");
                Console.ReadKey();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadLine();
        }
    }
}