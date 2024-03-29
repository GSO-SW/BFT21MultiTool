﻿using System.Security.Cryptography.X509Certificates;
using Figgle;

namespace WIBFTKlassenBibliothek
{
    public class WIMenue
    {
        public static void WISubMenue()
        {
            bool Exit = false;
            while (Exit == false)
            {
                Console.Clear();
                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                          >>> Submenü Wirtschaft <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nDas Submenü Wirtschaft soll verschiedene Rechner zur Verfügung stellen,\n" +
                                   " die das berechnen wirtschaftlicher Aspekte erleichtern. Zudem soll die eingebaute Möglichkeit,\n" +
                                   " Ergebnisse zwischenzuspeichern, das schnelle Benutzen mehrerer Funktionen,\n" +
                                   " in zusammenhang miteinander, erleichtern.\n\n");


                string HauptAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - EinheitenUmrechner");
                Console.WriteLine("\t2 - Lohnsteuerberrechnung");
                Console.WriteLine("\t3 - ZinsBerrechnung");
                Console.WriteLine("\t4 - ImmobilienBerrechnung");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        Feature20.run();
                        break;

                    case "2":
                        Console.Clear();
                        Feature18.run();
                        break;

                    case "3":
                        Console.Clear();
                        Feature17.run();
                        break;

                    case "4":
                        Console.Clear();
                        Feature19.run();
                        break;

                    case "exit":
                        Exit = true;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
