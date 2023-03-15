using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;
using System.Net.Http;
using System.Threading.Tasks;
using System.Data;

namespace PHBFTKlassenBibliothek
{
    internal class Feature8
    {
        public static void Volumrechner()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            var LogoName = "\tVolumenberechnung";
            var LogoDisplay = FiggleFonts.Slant.Render(LogoName);
            Console.WriteLine(LogoDisplay);
            while (true)

            {

                Console.WriteLine("Welchen Körper möchten Sie berechnen?\n");

                Console.WriteLine("\t1. Kegel");

                Console.WriteLine("\t2. Zylinder");

                Console.WriteLine("\t3. Würfel");

                Console.WriteLine("\t4. Beenden\n");

                Console.Write("Geben Sie Ihre Wahl ein (1-4): ");



                string auswahl = Console.ReadLine();

                
            


                switch (auswahl)

                {

                    case "1":
                        Console.Clear();


                        Console.WriteLine(FiggleFonts.Slant.Render("Volumenberechnung"));
                        
                        Console.WriteLine("Möchten Sie das Volumen oder den Radius berechnen?\n");

                        Console.WriteLine("\t1. Volumen");

                        Console.WriteLine("\t2. Radius\n");

                        Console.Write("Geben Sie Ihre Wahl ein (1-2): ");



                        string kegelAuswahl = Console.ReadLine();




                        if (kegelAuswahl == "1")

                        {

                            Console.Write("Geben Sie den Radius des Kegels ein: ");

                            double kegelRadius;

                            if (!double.TryParse(Console.ReadLine(), out kegelRadius))

                            {

                                Console.WriteLine("Ungültiger Radius. Bitte geben Sie eine Zahl ein.");

                                continue;

                            }

                            Console.Write("Geben Sie die Höhe des Kegels ein: ");

                            double kegelHoehe;

                            if (!double.TryParse(Console.ReadLine(), out kegelHoehe))

                            {

                                Console.WriteLine("Ungültige Höhe. Bitte geben Sie eine Zahl ein.");

                                continue;

                            }

                            double kegelVolumen = (Math.PI * Math.Pow(kegelRadius, 2) * kegelHoehe) / 3;

                            Console.WriteLine($"Das Volumen des Kegels beträgt {kegelVolumen:F2} Kubikzentimeter.");

                            Console.WriteLine("   /\\     ");

                            Console.WriteLine("  /  \\    ");

                            Console.WriteLine(" /    \\   ");

                            Console.WriteLine("/______\\  ");

                            Console.WriteLine("   |  |   ");

                            Console.WriteLine($"   |  |   Radius = {kegelRadius:F2}cm");

                            Console.WriteLine($"   |  |   Höhe = {kegelHoehe:F2}cm");

                        }

                        else if (kegelAuswahl == "2")

                        {

                            Console.Write("Geben Sie das Volumen des Kegels ein: ");

                            double kegelVolumen;

                            if (!double.TryParse(Console.ReadLine(), out kegelVolumen))

                            {

                                Console.WriteLine("Ungültiges Volumen. Bitte geben Sie eine Zahl ein.");

                                continue;

                            }

                            Console.Write("Geben Sie die Höhe des Kegels ein: ");

                            double kegelHoehe;

                            if (!double.TryParse(Console.ReadLine(), out kegelHoehe))

                            {

                                Console.WriteLine("Ungültige Höhe. Bitte geben Sie eine Zahl ein");

                            }

                            double kegelRadius = Math.Sqrt((3 * kegelVolumen) / (Math.PI * kegelHoehe));

                            Console.WriteLine($"Der Radius des Kegels beträgt {kegelRadius:F2} Zentimeter.");

                            Console.WriteLine("   /\\     ");

                            Console.WriteLine("  /  \\    ");

                            Console.WriteLine(" /    \\   ");

                            Console.WriteLine("/______\\  ");

                            Console.WriteLine("   |  |   ");

                            Console.WriteLine($"   |  |   Volumen = {kegelVolumen:F2} Kubikzentimeter");

                            Console.WriteLine($"   |  |   Höhe = {kegelHoehe:F2}cm");

                            Console.WriteLine($"   |  |   Radius = {kegelRadius:F2}cm");

                        }
                        else
                        {
                            Console.Clear();
                            Volumrechner();
                        }

                        break;





                    case "2":

                        Console.WriteLine("Möchten Sie das Volumen oder den Radius berechnen?");

                        Console.WriteLine("1. Volumen");

                        Console.WriteLine("2. Radius");

                        Console.Write("Geben Sie Ihre Wahl ein (1-2): ");



                        int zylinderAuswahl;

                        if (!int.TryParse(Console.ReadLine(), out zylinderAuswahl) || zylinderAuswahl < 1 || zylinderAuswahl > 2)

                        {

                            Console.WriteLine("Ungültige Wahl. Bitte geben Sie eine Zahl von 1 bis 2 ein.");

                            continue;

                        }



                        if (zylinderAuswahl == 1)

                        {

                            Console.Write("Geben Sie den Radius des Kegels ein: ");

                            double zylinderRadius;

                            if (!double.TryParse(Console.ReadLine(), out zylinderRadius))

                            {

                                Console.WriteLine("Ungültiger Radius. Bitte geben Sie eine Zahl ein.");

                                continue;

                            }

                            Console.Write("Geben Sie die Höhe des Kegels ein: ");

                            double zylinderHoehe;

                            if (!double.TryParse(Console.ReadLine(), out zylinderHoehe))

                            {

                                Console.WriteLine("Ungültige Höhe. Bitte geben Sie eine Zahl ein.");

                                continue;

                            }

                            double zylinderVolumen = Math.PI * Math.Pow(zylinderRadius, 2) * zylinderHoehe;

                            Console.WriteLine($"Das Volumen des Zylinders beträgt {zylinderVolumen:F2} Kubikzentimeter.");

                            Console.WriteLine(" ________ ");

                            Console.WriteLine("|        |");

                            Console.WriteLine("|        |");

                            Console.WriteLine("|        |");

                            Console.WriteLine("|        |");

                            Console.WriteLine("|        |");

                            Console.WriteLine("|________|");

                            Console.WriteLine($"  Radius = {zylinderRadius:F2} cm");

                            Console.WriteLine($"  Höhe = {zylinderHoehe:F2}  cm");

                        }

                        else if (zylinderAuswahl == 2)

                        {

                            Console.Write("Geben Sie das Volumen des Kegels ein: ");

                            double zylinderVolumen;

                            if (!double.TryParse(Console.ReadLine(), out zylinderVolumen))

                            {

                                Console.WriteLine("Ungültiges Volumen. Bitte geben Sie eine Zahl ein.");

                                continue;

                            }

                            Console.Write("Geben Sie die Höhe des Kegels ein: ");

                            double zylinderHoehe;

                            if (!double.TryParse(Console.ReadLine(), out zylinderHoehe))

                            {

                                Console.WriteLine("Ungültige Höhe. Bitte geben Sie eine Zahl ein");

                            }

                            double zylinderRadius = Math.Sqrt(zylinderVolumen / (Math.PI * zylinderHoehe));

                            Console.WriteLine($"Der Radius des Zylinders beträgt {zylinderRadius:F2}Zentimeter");

                            Console.WriteLine(" ________ ");

                            Console.WriteLine("|        |");

                            Console.WriteLine("|        |");

                            Console.WriteLine("|        |");

                            Console.WriteLine("|        |");

                            Console.WriteLine("|        |");

                            Console.WriteLine("|________|");

                            Console.WriteLine($"  Volumen = {zylinderVolumen:F2}  cm");

                            Console.WriteLine($"  Höhe = {zylinderHoehe:F2}  cm");

                        }



                        break;



                    case "3":

                        Console.WriteLine("Möchten Sie das Volumen oder die Kantenlänge berechnen?");

                        Console.WriteLine("1. Volumen");

                        Console.WriteLine("2. Kantenlänge");

                        Console.Write("Geben Sie Ihre Wahl ein (1-2): ");



                        int wuerfelAuswahl;

                        if (!int.TryParse(Console.ReadLine(), out wuerfelAuswahl) || wuerfelAuswahl < 1 || wuerfelAuswahl > 2)

                        {

                            Console.WriteLine("Ungültige Wahl. Bitte geben Sie eine Zahl von 1 bis 2 ein.");

                            continue;

                        }

                        if (wuerfelAuswahl == 1)

                        {

                            Console.Write("Geben Sie den Kantenlänge des Würfels ein: ");

                            double wuerfelKantenlaenge;

                            if (!double.TryParse(Console.ReadLine(), out wuerfelKantenlaenge))

                            {

                                Console.WriteLine("Ungültiger Radius. Bitte geben Sie eine Zahl ein.");

                                continue;

                            }

                            double wuerfelVolumen = Math.Pow(wuerfelKantenlaenge, 3);

                            Console.WriteLine($"Das Volumen des Würfels beträgt {wuerfelVolumen:F2} Kubikzentimeter.");

                            Console.WriteLine(" +--------+");

                            Console.WriteLine(" |        |");

                            Console.WriteLine(" |        |");

                            Console.WriteLine(" |        |");

                            Console.WriteLine(" |        |");

                            Console.WriteLine(" +--------+");

                        }

                        else if (wuerfelAuswahl == 2)

                        {



                            Console.Write("Geben Sie das Volumen des Würfels ein: ");

                            double wuerfelVolumen;

                            if (!double.TryParse(Console.ReadLine(), out wuerfelVolumen))

                            {

                                Console.WriteLine("Ungültige Kantenlaenge. Bitte geben Sie eine Zahl ein.");

                                continue;

                            }

                            double wuerfelKantenlaenge = Math.Pow(wuerfelVolumen, 1.0 / 3.0);

                            Console.WriteLine($"Die Kantenlänge des Würfels beträgt {wuerfelKantenlaenge:F2}Zentimeter");

                            Console.WriteLine(" +--------+");

                            Console.WriteLine(" |        |");

                            Console.WriteLine(" |        |");

                            Console.WriteLine(" |        |");

                            Console.WriteLine(" |        |");

                            Console.WriteLine(" +--------+");

                        }

                        break;

                    case "4":

                        Console.WriteLine("Auf Wiedersehen!");

                        return;



                    default:
                        Console.Clear();
                        

                        Console.WriteLine(FiggleFonts.Slant.Render("Volumenberechnung"));
                        Console.WriteLine("Ungültige Wahl.");
                        break;

                        Volumrechner();

                }



            }
        }

    }
}

