using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBFTKlassenBibliothek
{
    internal class Feature12
    {
        public Feature12()
        {
            Console.WriteLine("Willkommen bei der Byte-Konvertierung!");
            Console.WriteLine("------------------------------------");

            bool exit = false;
            while (!exit)
            {
                // Menü anzeigen
                Console.WriteLine("Was möchtest du tun?");
                Console.WriteLine("1) Bit -> Byte");
                Console.WriteLine("2) Kbit -> Byte");
                Console.WriteLine("3) Mbit -> Byte");
                Console.WriteLine("4) Gbit -> Byte");
                Console.WriteLine("5) Tbit -> Byte");
                Console.WriteLine("6) Wechsel zwischen Normal und Windows Rechnung");
                Console.WriteLine("7) Exit");
                Console.Write("Auswahl: ");

                string input = Console.ReadLine();

                // Prüfen, welche Option ausgewählt wurde
                switch (input)
                {
                    case "1":
                        ConvertBitsToBytes();
                        break;
                    case "2":
                        ConvertKilobitsToBytes();
                        break;
                    case "3":
                        ConvertMegabitsToBytes();
                        break;
                    case "4":
                        ConvertGigabitsToBytes();
                        break;
                    case "5":
                        ConvertTerabitsToBytes();
                        break;
                    case "6":
                        ToggleCalculationMode();
                        break;
                    case "7":
                        exit = true;
                        break;
                    case "a l e n d":
                        Console.WriteLine("Werde umgeleitet...");
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte wähle eine Option aus dem Menü.");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Auf Wiedersehen!");
        }

        // Konvertierung von Bit zu Byte
        static void ConvertBitsToBytes()
        {
            Console.Write("Bitte gib die Anzahl der Bits ein: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int bits))
            {
                double bytes = (double)bits / 8;
                Console.WriteLine("{0} Bit entsprechen {1:N2} Byte.", bits, bytes);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte gib eine ganze Zahl ein.");
            }
        }

        // Konvertierung von Kilobit zu Byte
        static void ConvertKilobitsToBytes()
        {
            Console.Write("Bitte gib die Anzahl der KiloBits ein: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int kbits))
            {
                double bytes = (double)kbits * 125;
                Console.WriteLine("{0} KiloBit entsprechen {1:N2} Byte.", kbits, bytes);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte gib eine ganze Zahl ein.");
            }
        }

        // Konvertierung von Megabit zu Byte
        static void ConvertMegabitsToBytes()
        {
            Console.Write("Bitte gib die Anzahl der MegaBits ein: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int mbits))
            {
                double bytes = (double)mbits * 125000;
                Console.WriteLine("{0} MegaBit entsprechen {1:N2} Byte.", mbits, bytes);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte gib eine ganze Zahl ein.");
            }
        }



    
    }
}
