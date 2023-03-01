using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace PHBFTKlassenBibliothek
{
    internal class Feature8
    {
        public static void Volumrechner()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            var LogoName = "\tVolumenrechner";
            var LogoDisplay = FiggleFonts.Slant.Render(LogoName);
            Console.WriteLine(LogoDisplay);
            
            Console.WriteLine("\nWählen Sie eine Form:");
            Console.WriteLine("\t \n1. Kegel");
            Console.WriteLine("\t \n2. Zylinder");
            Console.WriteLine("\t \n3. Würfel\n");
            Console.Write("Geben Sie Ihre Wahl ein (1-3): "); 
            int auswahl = int.Parse(Console.ReadLine()); 
            
            switch (auswahl)

            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Volumenrechner"));

                    Console.WriteLine("\nMöchten Sie das Volumen oder den Radius berechnen?");
                    Console.WriteLine("\t \n1. Volumen");
                    Console.WriteLine("\t \n2. Radius\n"); 
           
                    Console.Write("Geben Sie Ihre Wahl ein (1-2): "); 
                    int kegelAuswahl = int.Parse(Console.ReadLine()); 
                    if (kegelAuswahl == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Volumenrechner"));

                        Console.Write("Geben Sie den Radius der Basis ein: ");
                        double kegelRadius = double.Parse(Console.ReadLine());
                        Console.Write("Geben Sie die Höhe des Kegels ein: ");
                        double kegelHoehe = double.Parse(Console.ReadLine());
                        double kegelVolumen = (1.0 / 3.0) * Math.PI * Math.Pow(kegelRadius, 2) * kegelHoehe;
                        Console.WriteLine($"Das Volumen des Kegels beträgt {kegelVolumen:F2} Kubik-Einheiten.");
                    }
                    else if (kegelAuswahl == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Volumenrechner"));

                        Console.Write("Geben Sie das Volumen des Kegels ein: ");
                        double kegelVolumen = double.Parse(Console.ReadLine());
                        Console.Write("Geben Sie die Höhe des Kegels ein: ");
                        double kegelHoehe = double.Parse(Console.ReadLine());
                        double kegelRadius = Math.Sqrt(3.0 * kegelVolumen / (Math.PI * kegelHoehe));
                        Console.WriteLine($"Der Radius des Kegels beträgt {kegelRadius:F2} Einheiten.");
                    }
                    else
                    {
                        Console.WriteLine("\nUngültige Wahl.");
                    }
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Volumenrechner"));

                    Console.WriteLine("\nMöchten Sie das Volumen oder den Radius berechnen?");
                    Console.WriteLine("\t \n1. Volumen");
                    Console.WriteLine("\t \n2. Radius\n");
                    Console.Write("Geben Sie Ihre Wahl ein (1-2): "); 
                    int zylinderAuswahl = int.Parse(Console.ReadLine()); 
                    if (zylinderAuswahl == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Volumenrechner"));

                        Console.Write("Geben Sie den Radius der Basis ein: ");
                        double zylinderRadius = double.Parse(Console.ReadLine());
                        Console.Write("Geben Sie die Höhe des Zylinders ein: ");
                        double zylinderHoehe = double.Parse(Console.ReadLine());
                        double zylinderVolumen = Math.PI * Math.Pow(zylinderRadius, 2) * zylinderHoehe;
                        Console.WriteLine($"Das Volumen des Zylinders beträgt {zylinderVolumen:F2} Kubik-Einheiten.");
                    }
                    else if (zylinderAuswahl == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Volumenrechner"));

                        Console.Write("Geben Sie das Volumen des Zylinders ein: ");
                        double zylinderVolumen = double.Parse(Console.ReadLine());
                        Console.Write("Geben Sie die Höhe des Zylinders ein: ");
                        double zylinderHoehe = double.Parse(Console.ReadLine());
                        double zylinderRadius = Math.Sqrt(zylinderVolumen / (Math.PI * zylinderHoehe));
                        Console.WriteLine($"Der Radius des Zylinders beträgt {zylinderRadius:F2} Einheiten.");
                    }
                    else
                    {
                        Console.WriteLine("\nUngültige Wahl.");
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Volumenrechner"));
                    Console.WriteLine("\nMöchten Sie das Volumen oder die Kantenlänge berechnen?");
                    Console.WriteLine("\t \n1. Volumen");
                    Console.WriteLine("\t \n2. Kantenlänge\n");
                    Console.Write("Geben Sie Ihre Wahl ein (1-2): "); 
                    int wuerfelAuswahl = int.Parse(Console.ReadLine()); 
                    if (wuerfelAuswahl == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Volumenrechner"));

                        Console.Write("Geben Sie die Kantenlänge des Würfels ein: ");
                        double wuerfelKantenlaenge = double.Parse(Console.ReadLine());
                        double wuerfelVolumen = Math.Pow(wuerfelKantenlaenge, 3);
                        Console.WriteLine($"Das Volumen des Würfels beträgt {wuerfelVolumen:F2} Kubik-Einheiten.");
                    }
                    else if (wuerfelAuswahl == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Volumenrechner"));

                        Console.Write("Geben Sie das Volumen des Würfels ein: ");
                        double wuerfelVolumen = double.Parse(Console.ReadLine());
                        double wuerfelKantenlaenge = Math.Pow(wuerfelVolumen, 1.0 / 3.0);
                        Console.WriteLine($"Die Kantenlänge des Würfels beträgt {wuerfelKantenlaenge:F2} Einheiten.");
                    }
                    else
                    {
                        Console.WriteLine("\nUngültige Wahl.");
                    }
                    break;
                default:
                    Console.WriteLine("\n Ungültige Wahl.");
                    break;
            }
            Console.WriteLine("Drücken Sie eine beliebige Taste, um das Programm zu beenden...");
            
            Console.ReadKey();
            Console.Clear();
        }
    }

}

