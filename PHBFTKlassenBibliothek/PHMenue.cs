using Figgle;
using System;
namespace PHBFTKlassenBibliothek
{
    public class PHMenue
    {
        public static void PHSubMenue()
        {
            Console.ForegroundColor = ConsoleColor.Red;



            bool Exit = false;
            
            do
            {
                Console.Clear();
                var LogoName = "\tPhysik";
                var LogoDisplay = FiggleFonts.Slant.Render(LogoName);

                Console.WriteLine(LogoDisplay);

                //Konsolentitel wird geändert.


                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                            Physik Engine 1.0\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Zu das Programm beendet schreiben sie:\t 'exit'\t");

                //Beschreibung der Software.
                Console.WriteLine("\n\nDiese Software ist ein umfassender Physik- und Ingenieur-Rechner, der Benutzern ermöglicht, eine Vielzahl von Berechnungen im \nZusammenhang mit Optik, einfacher harmonischer Bewegung, Volumen- und Oberflächenberechnungen sowie grundlegender \nSchaltkreisanalyse durchzuführen. \n\n");


                string HauptAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Main Themen:\n");
                Console.WriteLine("\t1 <-> Optik");
                Console.WriteLine("\t2 <-> Einfache harmonische Bewegung");
                Console.WriteLine("\t3 <-> Berechnen und umrechnen von Volumen und Oberflache");
                Console.WriteLine("\t4 <-> Einfache Schaltungen\n");

                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        Feature6.Optik();
                        break;

                    case "2":
                        Console.Clear();
                        Feature7.Einfache_harmonische_Bewegung();
                        break;

                    case "3":
                        Console.Clear();
                        Feature8.Volumrechner();
                        break;

                    case "4":
                        Console.Clear();
                        //Feature9
                        break;
                    case "mainmenu":
                        Console.Clear();
                        return;

                    case "exit":
                        Console.Clear();
                        Exit = true;
                        Environment.Exit(0);
                        break;
                   
                    default:
                        Console.Clear();
                        break;
                }
               
                
            } while (!Exit);
        }
    }
}