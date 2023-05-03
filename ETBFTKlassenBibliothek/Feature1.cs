using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETBFTKlassenBibliothek
{
    internal class Feature1
    {
        public static void Feature_1()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            double spannung = 0, widerstand = 0, zeit = 0; double strom = 0, energie = 0, ladung = 0; string sspannung;
            string wwiderstand; string zzeit;


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Was  möchtest  du  berechnen?  Gib  eine  der  folgenden  Optionen  ein:\n\n" + "1.  Stromstärke\n\n" +
                "2. Energieverbrauch\n\n" + "3.  Ladungsmenge  in  Zeit\n\n" +
                "gib  'exit'  zum  Beenden  ein.\n\n" +
                "oder  gib  'subexit'  ein,  um  ins  Hauptmenue  zu  kommen."); string auswahl = Console.ReadLine();
                if (auswahl == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Beende  das  Programm"); Environment.Exit(0);
                    break;
                }
                else if (auswahl == "subexit")
                {
                    ETBFTMenue.ETMenue(); break;
                }

                Console.Clear();
                Console.WriteLine("Bitte  gib  die  folgenden  Werte  ein:\n");

                try
                {
                    Console.Write("Spannung  in  Volt:  \n\n" +
                    "gib  'exit'  zum  Beenden  ein.\n\n" +
                    "oder  gib  'subexit'  ein,  um  ins  Hauptmenue  zu  kommen.");


                    sspannung = (Console.ReadLine()); if (sspannung == "exit")
                    {
                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine();
                        Environment.Exit(0);
                    }
                    else if (sspannung == "subexit")
                    {
                        ETBFTMenue.ETMenue(); break;
                    }
                    spannung = double.Parse(sspannung);
                }
                catch (FormatException)
                {




                }
                try
                {

                    Console.WriteLine("Ungültige  Eingabe.  Bitte  gib  eine  Zahl  ein."); Console.ReadKey();
                    continue;



                    Console.Write("Widerstand  in  Ohm:  \n\n" +
                    "gib  'exit'  zum  Beenden  ein.\n\n" +
                    "oder  gib  'subexit'  ein,  um  ins  Hauptmenue  zu  kommen.");


                    wwiderstand = (Console.ReadLine()); if (wwiderstand == "exit")
                    {

                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine();
                        Environment.Exit(0);
                    }
                    else if (wwiderstand == "subexit")
                    {
                        ETBFTMenue.ETMenue(); break;
                    }
                    widerstand = double.Parse(wwiderstand);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige  Eingabe.  Bitte  gib  eine  Zahl  ein."); Console.ReadKey();
                    continue;
                }

                if (auswahl == "1")
                {
                    strom = spannung / widerstand; Console.WriteLine("\nStromstärke:  {0}  Ampere", strom);
                }
                else if (auswahl == "2")
                {
                    strom = spannung / widerstand; energie = spannung * strom;
                    Console.WriteLine("\nEnergieverbrauch:  {0}  Joule", energie);
                }
                else if (auswahl == "3")
                {

                    try
                    {



                        Console.Write("Zeit  in  Sekunden:  \n\n" +
                        "gib  'exit'  zum  Beenden  ein.\n\n" +
                        "oder  gib  'subexit'  ein,  um  ins  Hauptmenue  zu  kommen.");


                        zzeit = (Console.ReadLine()); if (zzeit == "exit")
                        {

                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine();
                            Environment.Exit(0);

                        }
                        else if (zzeit == "subexit")
                        {
                            ETBFTMenue.ETMenue(); break;
                        }
                        zeit = double.Parse(zzeit);
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("Ungültige  Eingabe.  Bitte  gib  eine  Zahl  ein."); Console.ReadKey();
                        continue;
                    }





                }


                else
                {


                }


                strom = spannung / widerstand; ladung = strom * zeit;
                Console.WriteLine("\nLadungsmenge:  {0}  Coulomb", ladung);





                Console.WriteLine("\nUngültige  Eingabe.  Bitte  versuche  es  erneut."); continue;


                Console.WriteLine("\nDrücke  eine  beliebige  Taste,  um  fortzufahren."); Console.ReadKey();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.ReadLine();
        }
    }
}
