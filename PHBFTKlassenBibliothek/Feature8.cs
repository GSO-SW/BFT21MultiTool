
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;
using System.Threading;
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
            Console.WriteLine("Das ist eine Programm-Anwendung, die es Benutzern ermöglicht, das Volumen und den Radius verschiedener dreidimensionaler Formen zu berechnen,\neinschließlich eines Kegels, Zylinders und Würfels. Sie können \"exit\" eingeben, um das gesamte Programm zu beenden, oder \nSie können \"submenu\" eingeben, um jederzeit zum Untermenü zurückzukehren!\n");


            Console.WriteLine("Welchen Körper möchten Sie berechnen?\n");

            Console.WriteLine("\t1. Kegel");

            Console.WriteLine("\t2. Zylinder");

            Console.WriteLine("\t3. Würfel");

            Console.WriteLine("\t4. Beenden\n");

            Console.Write("Geben Sie Ihre Wahl ein (1-4): ");



            string auswahl = Console.ReadLine();


            if (auswahl.ToLower() == "exit")
            {
                Console.Clear();
                Console.WriteLine("Good Bye!");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            else if (auswahl.ToLower() == "submenu")
            {
                return;
            }


            while (true)
            {

                switch (auswahl)

                {

                    case "1":
                        while (true)
                        {
                            try
                            {
                                Console.Clear();


                                Console.WriteLine(FiggleFonts.Slant.Render("Volumenberechnung"));

                                Console.WriteLine("Möchten Sie das Volumen oder den Radius berechnen?\n");

                                Console.WriteLine("\t1. Volumen");

                                Console.WriteLine("\t2. Radius\n");

                                Console.Write("Geben Sie Ihre Wahl ein (1-2): ");



                                string kegelAuswahl = Console.ReadLine();

                                if (kegelAuswahl.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Good Bye!");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                                else if (kegelAuswahl.ToLower() == "submenu")
                                {
                                    //PHBFTKlassenBibliothek.PHMenue.PHSubMenue();
                                    return;
                                }

                                int kegelAuswahlD = Convert.ToInt32(kegelAuswahl);

                                if (kegelAuswahlD == 1)

                                {

                                    Console.Write("\nGeben Sie den Radius des Kegels ein(in cm): ");

                                    string kegelRadius = Console.ReadLine();

                                    if (kegelRadius.ToLower() == "exit")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Good Bye!");
                                        Thread.Sleep(2000);
                                        Environment.Exit(0);
                                    }
                                    else if (kegelRadius.ToLower() == "submenu")
                                    {
                                        return;
                                    }


                                    double kegelRadius_DB = Convert.ToDouble(kegelRadius);


                                    Console.Write("Geben Sie die Höhe des Kegels ein(in cm): ");

                                    string khoehe = Console.ReadLine();

                                    if (khoehe.ToLower() == "exit")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Good Bye!");
                                        Thread.Sleep(2000);
                                        Environment.Exit(0);
                                    }
                                    else if (khoehe.ToLower() == "submenu")
                                    {
                                        return;
                                    }

                                    double kegelHoehe = Convert.ToDouble(khoehe);


                                    double kegelVolumen = (Math.PI * Math.Pow(kegelRadius_DB, 2) * kegelHoehe) / 3;

                                    Console.WriteLine($"\nDas Volumen des Kegels beträgt {kegelVolumen:F2} Kubikzentimeter.");

                                    Console.WriteLine("   /\\     ");

                                    Console.WriteLine("  /  \\    ");

                                    Console.WriteLine(" /    \\   ");

                                    Console.WriteLine("/______\\  ");

                                    Console.WriteLine("      ");

                                    Console.WriteLine($"          Radius = {kegelRadius:F2}cm");

                                    Console.WriteLine($"          Höhe = {kegelHoehe:F2}cm");
                                    Console.WriteLine("Drücken Sie 'Enter', um fortzufahren...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Volumrechner();
                                }

                                else if (kegelAuswahlD == 2)

                                {

                                    Console.Write("\nGeben Sie das Volumen des Kegels ein(in cm): ");
                                    string kegelVolumen = Console.ReadLine();
                                    double kegelVolumen_C = Convert.ToDouble(kegelVolumen);

                                    if (kegelVolumen.ToLower() == "exit")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Good Bye!");
                                        Thread.Sleep(2000);
                                        Environment.Exit(0);
                                    }
                                    else if (kegelVolumen.ToLower() == "submenu")
                                    {
                                        return;
                                    }


                                    Console.Write("Geben Sie die Höhe des Kegels ein(in cm): ");
                                    string kegelHoehe = Console.ReadLine();

                                    if (kegelHoehe.ToLower() == "exit")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Good Bye!");
                                        Thread.Sleep(2000);
                                        Environment.Exit(0);
                                    }
                                    else if (kegelHoehe.ToLower() == "submenu")
                                    {
                                        return;
                                    }

                                    double kegelHoehe_C = Convert.ToDouble(kegelHoehe);

                                    double kegelRadius = Math.Sqrt((3 * kegelVolumen_C) / (Math.PI * kegelHoehe_C));

                                    Console.WriteLine($"\nDer Radius des Kegels beträgt {kegelRadius:F2} Zentimeter.");

                                    Console.WriteLine("   /\\     ");

                                    Console.WriteLine("  /  \\    ");

                                    Console.WriteLine(" /    \\   ");

                                    Console.WriteLine("/______\\  ");

                                    Console.WriteLine("    ");

                                    Console.WriteLine($"          Volumen = {kegelVolumen_C:F2} Kubikzentimeter");

                                    Console.WriteLine($"          Höhe = {kegelHoehe_C:F2}cm");

                                    Console.WriteLine($"          Radius = {kegelRadius:F2}cm");
                                    Console.WriteLine("Drücken Sie 'Enter', um fortzufahren...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Volumrechner();
                                }

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Erorr cant input correct");
                            }



                        }
                        break;



                    case "2":
                        while (true)
                        {
                            try
                            {
                                Console.Clear();


                                Console.WriteLine(FiggleFonts.Slant.Render("Volumenberechnung"));

                                Console.WriteLine("Möchten Sie das Volumen oder den Radius berechnen?\n");

                                Console.WriteLine("\t1. Volumen");

                                Console.WriteLine("\t2. Radius\n");

                                Console.Write("Geben Sie Ihre Wahl ein (1-2): ");



                                string zylinderAuswahl = Console.ReadLine();

                                if (zylinderAuswahl.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Good Bye!");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                                else if (zylinderAuswahl.ToLower() == "submenu")
                                {
                                    return;
                                }

                                int zylinderAuswahlD = Convert.ToInt32(zylinderAuswahl);

                                if (zylinderAuswahlD == 1)

                                {

                                    Console.Write("Geben Sie den Radius des Zylinder ein(in cm): ");


                                    string zylinderRadius = Console.ReadLine();

                                    if (zylinderAuswahl.ToLower() == "exit")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Good Bye!");
                                        Thread.Sleep(2000);
                                        Environment.Exit(0);
                                    }
                                    else if (zylinderAuswahl.ToLower() == "submenu")
                                    {
                                        return;
                                    }

                                    double zylinderRadius_C = Convert.ToDouble(zylinderRadius);

                                    Console.Write("Geben Sie die Höhe des Zylinder ein(in cm): ");
                                    string zylinderHoehe = Console.ReadLine();

                                    if (zylinderAuswahl.ToLower() == "exit")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Good Bye!");
                                        Thread.Sleep(2000);
                                        Environment.Exit(0);
                                    }
                                    else if (zylinderAuswahl == "subMenu".ToLower())
                                    {
                                        return;
                                    }

                                    double zylinderHoehe_C = Convert.ToDouble(zylinderHoehe);



                                    double zylinderVolumen = Math.PI * Math.Pow(zylinderRadius_C, 2) * zylinderHoehe_C;

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

                                    Console.WriteLine("Drücken Sie 'Enter', um fortzufahren...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Volumrechner();
                                }

                                else if (zylinderAuswahlD == 2)

                                {

                                    Console.Write("Geben Sie das Volumen des Zylinder ein(in cm): ");
                                    string zylinderVolumen = Console.ReadLine();

                                    if (zylinderVolumen.ToLower() == "exit")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Good Bye!");
                                        Thread.Sleep(2000);
                                        Environment.Exit(0);
                                    }
                                    else if (zylinderVolumen.ToLower() == "submenu")
                                    {
                                        return;
                                    }

                                    double zylinderVolumen_C = Convert.ToDouble(zylinderVolumen);



                                    Console.Write("Geben Sie die Höhe des Zylinder ein(in cm): ");
                                    string zylinderHoehe = Console.ReadLine();

                                    if (zylinderHoehe.ToLower() == "exit")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Good Bye!");
                                        Thread.Sleep(2000);
                                        Environment.Exit(0);
                                    }
                                    else if (zylinderHoehe.ToLower() == "submenu")
                                    {
                                        return;
                                    }

                                    double zylinderHoehe_C = Convert.ToDouble(zylinderHoehe);



                                    double zylinderRadius = Math.Sqrt(zylinderVolumen_C / (Math.PI * zylinderHoehe_C));

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

                                    Console.WriteLine("Drücken Sie 'Enter', um fortzufahren...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Volumrechner();
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error Input incorrect!");
                            }

                        }

                        break;



                    case "3":
                        while (true)
                        {
                            try
                            {
                                Console.Clear();


                                Console.WriteLine(FiggleFonts.Slant.Render("Volumenberechnung"));


                                Console.WriteLine("Möchten Sie das Volumen oder die Kantenlänge berechnen?\n");

                                Console.WriteLine("\t1. Volumen\n");

                                Console.WriteLine("\t2. Kantenlänge\n");

                                Console.Write("Geben Sie Ihre Wahl ein (1-2): ");



                                string wuerfelAuswahl = Console.ReadLine();

                                if (wuerfelAuswahl.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Good Bye!");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                                else if (wuerfelAuswahl.ToLower() == "subMenu")
                                {
                                    return;
                                }

                                int wuerfelAuswahlD = Convert.ToInt32(wuerfelAuswahl);

                                if (wuerfelAuswahlD == 1)

                                {

                                    Console.Write("Geben Sie den Kantenlänge des Würfels ein(in cm): ");


                                    string wkl = Console.ReadLine();

                                    if (wkl.ToLower() == "exit")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Good Bye!");
                                        Thread.Sleep(2000);
                                        Environment.Exit(0);
                                    }
                                    else if (wkl.ToLower() == "subMenu")
                                    {
                                        return;
                                    }

                                    double wklc = Convert.ToDouble(wkl);

                                    double wv = Math.Pow(wklc, 3);

                                    Console.WriteLine($"Das Volumen des Würfels beträgt {wv:F2} Kubikzentimeter.");

                                    Console.WriteLine(" +--------+");

                                    Console.WriteLine(" |        |");

                                    Console.WriteLine(" |        |");

                                    Console.WriteLine(" |        |");

                                    Console.WriteLine(" |        |");

                                    Console.WriteLine(" +--------+");
                                    Console.WriteLine("Drücken Sie 'Enter', um fortzufahren...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                }

                                else if (wuerfelAuswahlD == 2)

                                {

                                    Console.Write("Geben Sie das Volumen des Würfels ein(in cm): ");

                                    string wuerfelVolumen = Console.ReadLine();

                                    if (wuerfelVolumen.ToLower() == "exit")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Good Bye!");
                                        Thread.Sleep(2000);
                                        Environment.Exit(0);
                                    }
                                    else if (wuerfelVolumen.ToLower() == "subMenu")
                                    {
                                        return;
                                    }

                                    double wuerfelVolumen_C = Convert.ToDouble(wuerfelVolumen);

                                    double wuerfelKantenlaenge2 = Math.Pow(wuerfelVolumen_C, 1.0 / 3.0);

                                    Console.WriteLine($"Die Kantenlänge des Würfels beträgt {wuerfelKantenlaenge2:F2}Zentimeter");

                                    Console.WriteLine(" +--------+");

                                    Console.WriteLine(" |        |");

                                    Console.WriteLine(" |        |");

                                    Console.WriteLine(" |        |");

                                    Console.WriteLine(" |        |");

                                    Console.WriteLine(" +--------+");
                                    Console.WriteLine("Drücken Sie 'Enter', um fortzufahren...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;
                                }

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error, the Input is not in correct format!");
                            }
                        }

                        break;

                    case "4":

                        Console.WriteLine("Auf Wiedersehen!");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;



                    default:
                        Console.Clear();
                        return;



                }
            }

        }

    }
}


