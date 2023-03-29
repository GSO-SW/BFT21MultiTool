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
                Console.WriteLine("Willkommen zum DPI-Rechner!");
                Console.WriteLine("Mit diesem Tool sind Sie in der Lage die dots per inch (DPI) zu Reschnen");
                Console.WriteLine("Die DPI Reschnen Sie in dem Sie einmal Die Pixel in der Breite, sowie Höhe angeben und zu letzt Die Göße Ihres Bildschirms in Zoll");
                Console.WriteLine();

                    while (true)
                {
                        Console.WriteLine("Gib die Breite deines Bildschirms in Pixeln ein:");
                        int Breite = Convert.ToInt32(Console.ReadLine());
                    if (Breite == -1) continue;

                        Console.WriteLine("Gib die Höhe deines Bildschirms in Pixeln ein:");
                        int Höhe = Convert.ToInt32(Console.ReadLine());
                    if (Höhe == -1) continue;

                        Console.WriteLine("Gib die Größe deines Bildschirms in Zoll ein:");
                        double size = Convert.ToInt32(Console.ReadLine());
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

           
        }
    }
    }
}


 