using Figgle;
using System;
namespace PHBFTKlassenBibliothek
{
    public class PHMenue
    {
        public static void PHSubMenue()
        {
            Console.ForegroundColor= ConsoleColor.Red;
            
            

            bool Exit = false;
            do { 
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
                Console.WriteLine("\n\n To do.\n\n");


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
                            
                            break;

                        case "2":
                            Console.Clear();
                            //Hier das Informationstechnikmenü aufrufen
                            break;

                        case "3":
                            Console.Clear();
                            Feature8.Volumrechner();
                            break;

                        case "4":
                            Console.Clear();
                            //Hier das Physikmenü aufrufen
                            break;

                        case "5":
                            Console.Clear();
                            //Hier das Wirtschaftsmenü aufrufen
                            break;

                        case "":
                            Exit = true;
                            break;
                        default:
                            Console.Clear();
                            break;
                    }
            }while(!Exit);
        }
    }
}