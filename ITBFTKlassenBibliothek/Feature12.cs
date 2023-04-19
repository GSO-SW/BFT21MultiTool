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
            bool menuOpen = true;

            while (menuOpen)
            {
                Console.WriteLine("Bitte geben Sie den zu konvertierenden Wert ein (zum Beenden 'exit' eingeben):");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    menuOpen = false;
                    continue;
                }

                if (!double.TryParse(input, out double value))
                {
                    Console.WriteLine("Ungültiger Wert, bitte geben Sie eine gültige Zahl ein.");
                    continue;
                }

                Console.WriteLine("Bitte geben Sie die Einheit ein (bit/kbit/Mbit/Gbit/Tbit):");
                string unit = Console.ReadLine();

                if (unit.ToLower() != "bit" && unit.ToLower() != "kbit" && unit.ToLower() != "mbit" && unit.ToLower() != "gbit" && unit.ToLower() != "tbit")
                {
                    Console.WriteLine("Ungültige Einheit, bitte geben Sie eine der folgenden Einheiten ein: bit, kbit, Mbit, Gbit, Tbit.");
                    continue;
                }

                Console.WriteLine("Bitte wählen Sie die Basis (2 für Windows oder 10 für Normal):");
                string basisInput = Console.ReadLine();

                if (!int.TryParse(basisInput, out int basis) || (basis != 2 && basis != 10))
                {
                    Console.WriteLine("Ungültige Basis, bitte geben Sie entweder 2 (für Windows) oder 10 (für Normal) ein.");
                    continue;
                }

                double bytes = 0;

                switch (unit.ToLower())
                {
                    case "bit":
                        bytes = value / (basis == 2 ? 8 : 10);
                        break;
                    case "kbit":
                        bytes = value * 1024 / (basis == 2 ? 8 : 10);
                        break;
                    case "mbit":
                        bytes = value * 1024 * 1024 / (basis == 2 ? 8 : 10);
                        break;
                    case "gbit":
                        bytes = value * 1024 * 1024 * 1024 / (basis == 2 ? 8 : 10);
                        break;
                    case "tbit":
                        bytes = value * 1024 * 1024 * 1024 * 1024 / (basis == 2 ? 8 : 10);
                        break;
                }

                Console.WriteLine("Das entspricht:");
                Console.WriteLine($"{bytes:N2} Bytes");
                Console.WriteLine($"{bytes / 1024:N2} Kilobytes");
                Console.WriteLine($"{bytes / (1024 * 1024):N2} Megabytes");
                Console.WriteLine($"{bytes / (1024 * 1024 * 1024):N2} Gigabytes");
                Console.WriteLine($"{bytes / (1024 * 1024 * 1024 * 1024):N2} Terabytes");
            }






        }
    }
}
