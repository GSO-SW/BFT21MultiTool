using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBFTKlassenBibliothek
{
    class feat14
    {
        public static void dpi()
        {
            


        {
            static void Main(string[] args)
            {
                Console.WriteLine("Willkommen beim DPI-Rechner!");
                Console.WriteLine();

                while (true)
                {
                    int Breite = GetIntegerInput("Gib die Breite deines Bildschirms in Pixeln ein:");
                    if (Breite == -1) continue;

                    int Höhe = GetIntegerInput("Gib die Höhe deines Bildschirms in Pixeln ein:");
                    if (Höhe == -1) continue;

                    double size = GetDoubleInput("Gib die Größe deines Bildschirms in Zoll ein:");
                    if (size == -1) continue;

                    double dpi = Math.Sqrt(Breite * Breite + Höhe * Höhe) / size;
                    Console.WriteLine();
                    Console.WriteLine("Deine DPI sind: " + dpi);
                    Console.WriteLine();

                    Console.WriteLine("Möchtest du eine weitere Berechnung durchführen? (ja/nein)");
                    string input = Console.ReadLine().ToLower();
                    if (input == "nein")
                    {
                        break;
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Vielen Dank, dass du den DPI-Rechner benutzt hast!");
            }

            static int GetIntegerInput(string prompt)
            {
                int value;
                while (true)
                {
                    Console.Write(prompt + " ");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out value))
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte gib eine ganze Zahl ein.");
                        continue;
                    }
                    return value;
                }
            }

            static double GetDoubleInput(string prompt)
            {
                double value;
                while (true)
                {
                    Console.Write(prompt + " ");
                    string input = Console.ReadLine();
                    if (!double.TryParse(input, out value))
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
                        continue;
                    }
                    return value;
                }
            }
        }
    }
    }
}


 