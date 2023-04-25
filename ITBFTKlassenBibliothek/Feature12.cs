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


            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.WriteLine("Bitte wählen Sie eine Option:");
                Console.WriteLine("1. Bit zu Byte Konvertierung");
                Console.WriteLine("2. Windows Rechnung");
                Console.WriteLine("3. Programm beenden");

                int selectedOption;
                if (!int.TryParse(Console.ReadLine(), out selectedOption))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Zahl zwischen 1 und 3.");
                    continue;
                }

                switch (selectedOption)
                {
                    case 1:
                        ConvertBitToByte();
                        break;
                    case 2:
                        WindowsCalculation();
                        break;
                    case 4:
                        Console.WriteLine("Werde umgeleitet...");
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                        break;
                    case 3:
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Zahl zwischen 1 und 3.");
                        break;
                }



                static void ConvertBitToByte()
                {
                    Console.WriteLine("Bitte geben Sie die Bit-Zahl ein:");
                    double bitNumber;
                    if (!double.TryParse(Console.ReadLine(), out bitNumber))
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                        return;
                    }

                    Console.WriteLine("Bitte wählen Sie die Byte-Einheit:");
                    Console.WriteLine("1. Bit  -> Byte");
                    Console.WriteLine("2. Kbit -> Byte");
                    Console.WriteLine("3. Mbit -> Byte");
                    Console.WriteLine("4. Gbit -> Byte");
                    Console.WriteLine("5. TBit -> Byte");

                    int selectedUnit;
                    if (!int.TryParse(Console.ReadLine(), out selectedUnit) || selectedUnit < 1 || selectedUnit > 5)
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Zahl zwischen 1 und 5.");
                        return;
                    }

                    double byteNumber;
                    switch (selectedUnit)
                    {
                        case 1:
                            byteNumber = bitNumber / 8;
                            Console.WriteLine($"{bitNumber} Bit entspricht {byteNumber} Byte.");
                            break;
                        case 2:
                            byteNumber = bitNumber / 8 * 1000;
                            Console.WriteLine($"{bitNumber} KBit entspricht {byteNumber} Byte.");
                            break;
                        case 3:
                            byteNumber = bitNumber / 8 * 1000 * 1000;
                            Console.WriteLine($"{bitNumber} MBit entspricht {byteNumber} Byte.");
                            break;
                        case 4:
                            byteNumber = bitNumber / 8 * 1000 * 1000 * 1000;
                            Console.WriteLine($"{bitNumber} GBit entspricht {byteNumber} Byte.");
                            break;
                        case 5:
                            byteNumber = bitNumber / 8 * 1000 * 1000 * 1000 * 1000;
                            Console.WriteLine($"{bitNumber} TBit entspricht {byteNumber} Byte.");
                            break;
                        default:
                            Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Zahl zwischen 1 und 5.");
                            break;
                    }

                    int SelectedUnit;
                    if (!int.TryParse(Console.ReadLine(), out SelectedUnit) || SelectedUnit < 1 || SelectedUnit > 4)
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Zahl zwischen 1 und 5.");
                        return;
                    }
                    Console.WriteLine("Bitte wählen Sie die Byte-Einheit:");
                    Console.WriteLine("1. Überspringen ");
                    Console.WriteLine("2. Byte -> KByte");
                    Console.WriteLine("3. Byte -> MByte");
                    Console.WriteLine("4. Byte -> GByte");
                    Console.WriteLine("5. Byte -> TByte");
                    double Summe = 0;
                    switch (SelectedUnit)
                    {
                        case 1:
                            Console.ReadLine();
                            break;
                        case 2:
                            Summe = byteNumber / 1000;
                            Console.WriteLine($"{byteNumber} Byte entspricht {Summe} KByte.");
                            break;
                        case 3:
                            Summe = byteNumber / 1000 / 1000;
                            Console.WriteLine($"{byteNumber} Byte entspricht {Summe} MByte.");
                            break;
                        case 4:
                            Summe = byteNumber / 1000 / 1000 / 1000;
                            Console.WriteLine($"{byteNumber} Byte entspricht {Summe} GByte.");
                            break;
                        case 5:
                            Summe = byteNumber / 1000 / 1000 / 1000 / 1000;
                            Console.WriteLine($"{byteNumber} Byte entspricht {Summe} TByte.");
                            break;
                        default:
                            Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Zahl zwischen 1 und 5.");
                            break;
                    }
                }



                static void WindowsCalculation();
                {
                    Console.WriteLine("Bitte geben Sie die Bit-Zahl ein:");
                    double IbitNumber;
                    if (!double.TryParse(Console.ReadLine(), out IbitNumber))
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                        return;
                    }

                    Console.WriteLine("Bitte wählen Sie die Byte-Einheit:");
                    Console.WriteLine("1. Bit  -> Byte");
                    Console.WriteLine("2. Kibit -> Byte");
                    Console.WriteLine("3. Mibit -> Byte");
                    Console.WriteLine("4. Gibit -> Byte");
                    Console.WriteLine("5. TiBit -> Byte");

                    int SelectedUnit;
                    if (!int.TryParse(Console.ReadLine(), out SelectedUnit) || SelectedUnit < 1 || SelectedUnit > 5)
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Zahl zwischen 1 und 5.");
                        return;
                    }

                    double byteNumber;
                    switch (SelectedUnit)
                    {
                        case 1:
                            byteNumber = IbitNumber / 8;
                            Console.WriteLine($"{IbitNumber} Bit entspricht {byteNumber} Byte.");
                            break;
                        case 2:
                            byteNumber = IbitNumber / 8 * 1024;
                            Console.WriteLine($"{IbitNumber} KiBit entspricht {byteNumber} Byte.");
                            break;
                        case 3:
                            byteNumber = IbitNumber / 8 * 1024 * 1024;
                            Console.WriteLine($"{IbitNumber} MiBit entspricht {byteNumber} Byte.");
                            break;
                        case 4:
                            byteNumber = IbitNumber / 8 * 1024 * 1024 * 1024;
                            Console.WriteLine($"{IbitNumber} GiBit entspricht {byteNumber} Byte.");
                            break;
                        case 5:
                            byteNumber = IbitNumber / 8 * 1024 * 1024 * 1024 * 1024;
                            Console.WriteLine($"{IbitNumber} TiBit entspricht {byteNumber} Byte.");
                            break;
                        default:
                            Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Zahl zwischen 1 und 5.");
                            break;
                    }

                    int selectedUnit;
                    if (!int.TryParse(Console.ReadLine(), out SelectedUnit) || SelectedUnit < 1 || SelectedUnit > 4)
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Zahl zwischen 1 und 5.");
                        return;
                    }
                    Console.WriteLine("Bitte wählen Sie die Byte-Einheit:");
                    Console.WriteLine("1. Überspringen ");
                    Console.WriteLine("2. Byte -> KiByte");
                    Console.WriteLine("3. Byte -> MiByte");
                    Console.WriteLine("4. Byte -> GiByte");
                    Console.WriteLine("5. Byte -> TiByte");
                    double Summe = 0;
                    switch (selectedUnit)
                    {
                        case 1:
                            Console.ReadLine();
                            break;
                        case 2:
                            Summe = byteNumber / 1024;
                            Console.WriteLine($"{byteNumber} Byte entspricht {Summe} KiByte.");
                            break;
                        case 3:
                            Summe = byteNumber / 1024 / 1024;
                            Console.WriteLine($"{byteNumber} Byte entspricht {Summe} MiByte.");
                            break;
                        case 4:
                            Summe = byteNumber / 1024 / 1024 / 1024;
                            Console.WriteLine($"{byteNumber} Byte entspricht {Summe} GiByte.");
                            break;
                        case 5:
                            Summe = byteNumber / 1024 / 1024 / 1024 / 1024;
                            Console.WriteLine($"{byteNumber} Byte entspricht {Summe} TiByte.");
                            break;
                        default:
                            Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Zahl zwischen 1 und 5.");
                            break;
                    }

                }

                Console.WriteLine("Wollen sie das Program wiederholen ?");
                Console.WriteLine("1. nein ");
                Console.WriteLine("2. ja ");
                int Aita;
                switch (Aita)
                {
                    case 1:
                         exitProgram = true;
                         break;
                    case 2:
                         exitProgram = false;
                         break;
                }
                
            }

        }
    }
}

