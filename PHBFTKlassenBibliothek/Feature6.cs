using Figgle;
using System;
using Figgle;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace PHBFTKlassenBibliothek
{
    internal class Feature6
    {
        public static void Optik()
        {
            do
            {

                Console.ForegroundColor = ConsoleColor.Red;
                var LogoName = "\tOptik";
                var LogoDisplay = FiggleFonts.Slant.Render(LogoName);
                Console.WriteLine(LogoDisplay);

                Console.WriteLine("Die Software ist eine umfassende Optik-Rechner, der Benutzern ermöglicht, eine Vielzahl von Berechnungen im \nZusammenhang mit Snelliussches Brechungsgesetz, Linsengleichung und Farbmischung durchzuführen.\n\nSie können \"exit\" eingeben, um das gesamte Programm zu beenden, oder \nSie können \"submenu\" eingeben, um jederzeit zum Untermenü zurückzukehren!");

                Console.WriteLine("\nThemas:\t\n \t1. Snelliussches Brechungsgesetz.\n \t2. Linsengleichung.\n \t3. Farbmischung\n");

                Console.Write("Eingabe:");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        while (true)
                        {
                            try
                            {

                                Console.Clear();
                                Console.WriteLine(FiggleFonts.Slant.Render("Snelliussches Brechungsgesetz"));
                                Console.WriteLine("Dieses C#-Programm ermöglicht es dem Benutzer, den Brechungswinkel basierend auf dem Snellschen Gesetz zu berechnen.");
                                Console.Write("\nGeben Sie den Einfallswinkel in Grad ein: ");

                                string AngelofInc = Console.ReadLine();

                                if (AngelofInc.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Good Bye!");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                                else if (AngelofInc.ToLower() == "submenu")
                                {
                                    return;
                                }

                                double angleOfIncidence = Convert.ToDouble(AngelofInc);

                                


                                Console.Write("Geben Sie den Brechungsindex des ersten Mediums ein: ");

                                string n1_str = Console.ReadLine();

                                if (n1_str.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Good Bye!");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                                else if (n1_str.ToLower() == "submenu")
                                {
                                    return;
                                }

                                double n1 = Convert.ToDouble(n1_str);

                                


                                Console.Write("Geben Sie den Brechungsindex des zweiten Mediums ein: ");

                                string n2str = Console.ReadLine();

                                if (n2str.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Good Bye!");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                                else if (n2str.ToLower() == "submenu")
                                {
                                    return;
                                }

                                double n2 = Convert.ToDouble(n2str);

                                // Konvertieren des Einfallswinkels von Grad in Bogenmaß
                                double angleOfIncidenceRadians = angleOfIncidence * System.Math.PI / 180;

                                // Berechnen des Brechungswinkels mit Snells Gesetz
                                double angleOfRefractionRadians = System.Math.Asin((n1 / n2) * System.Math.Sin(angleOfIncidenceRadians));

                                // Konvertieren des Brechungswinkels von Bogenmaß in Grad
                                double angleOfRefraction = angleOfRefractionRadians * 180 / System.Math.PI;

                                // Ausgabe der Ergebnisse
                                Console.WriteLine("\nEinfallswinkel: {0:F2} Grad", angleOfIncidence);
                                Console.WriteLine("Brechungswinkel: {0:F2} Grad", angleOfRefraction);
                                Console.WriteLine("\nWenn Sie fertig sind drucken Sie bitte 'Enter'...");
                                Console.ReadKey();
                            }
                            catch (FormatException) { }
                        }


                    case "2":
                        while (true)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine(FiggleFonts.Slant.Render("Linsengleichung"));
                                Console.WriteLine("Die Software \"Linsengleichung\" ist ein C#-Programm, das es dem Benutzer ermöglicht, die grundlegenden Eigenschaften von Linsen zu berechnen\n");

                                Console.Write("Geben Sie die Brennweite der Linse ein (in mm): ");

                                string brennweit = Console.ReadLine();

                                if (brennweit.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Good Bye!");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                                else if (brennweit.ToLower() == "submenu")
                                {
                                    return;
                                }

                                double brennweite = Convert.ToDouble(brennweit);


                                Console.Write("Geben Sie den Abstand des Objekts zur Linse ein (in mm): ");

                                string objectabstand = Console.ReadLine();

                                if (objectabstand.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Good Bye!");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                                else if (objectabstand.ToLower() == "submenu")
                                {
                                    return;
                                }


                                double objektAbstand = Convert.ToDouble(objectabstand);

                                

                                Console.Write("Geben Sie die Größe des Objekts ein (in mm): ");

                                string objectgrose = Console.ReadLine();

                                if (objectabstand.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Good Bye!");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                                else if (objectabstand.ToLower() == "submenu")
                                {
                                    return;
                                }

                                double objektGröße = Convert.ToDouble(objectgrose);

                                


                                // Berechnung der Bildparameter mit Hilfe der Linsengleichung
                                double bildAbstand = 1 / ((1 / brennweite) - (1 / objektAbstand));
                                double vergrößerung = bildAbstand / objektAbstand;
                                double bildGröße = objektGröße * vergrößerung;

                                // Berechnung der Bildorientierung
                                bool istAufDemKopf = (objektAbstand < brennweite);

                                // Anzeige der Ergebnisse
                                Console.WriteLine("Abstand des Objekts: {0} mm", objektAbstand);
                                Console.WriteLine("Größe des Objekts: {0} mm", objektGröße);
                                Console.WriteLine("Abstand des Bilds: {0} mm", bildAbstand);
                                Console.WriteLine("Größe des Bilds: {0} mm", bildGröße);
                                Console.WriteLine("Bildorientierung: {0}", istAufDemKopf ? "Auf dem Kopf" : "Richtig herum");

                                Console.WriteLine("\nWenn Sie fertig sind drucken Sie bitte 'Enter'...");
                                Console.ReadKey();

                            }
                            catch (FormatException) { }
                        }

                    case "3":
                        while (true)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine(FiggleFonts.Slant.Render("Linseneigenschaftenrechner"));
                                Console.WriteLine("Der \"Linseneigenschaftenrechner\" ist ein C#-Programm, das für optische Berechnungen von Linseneigenschaften wie Brennweite, Objektabstand, Bildabstand, Vergrößerung und Linsenleistung verwendet wird\n");

                                Console.Write("Geben Sie die Brennweite der Linse ein (in Metern): ");

                                string brennweit = Console.ReadLine();

                                if (brennweit.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Good Bye!");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                                else if (brennweit.ToLower() == "submenu")
                                {
                                    return;
                                }

                                double brennweite = Convert.ToDouble(brennweit);
                               

                                Console.Write("Geben Sie den Objektabstand ein (in Metern): ");

                                string objectabstand = Console.ReadLine();

                                if (objectabstand.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Good Bye!");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                }
                                else if (objectabstand.ToLower() == "submenu")
                                {
                                    return;
                                }

                                double objektabstand = Convert.ToDouble(brennweit);

                                // Berechnung der Bildweite und Vergrößerung
                                double bildweite = 1 / ((1 / brennweite) - (1 / objektabstand));
                                double vergroesserung = -bildweite / objektabstand;

                                // Berechnung der Linsestärke
                                double linsestaerke = 1 / brennweite;

                                Console.WriteLine("\nLinseneigenschaften:");
                                Console.WriteLine("Brennweite: {0} m", brennweite);
                                Console.WriteLine("Objektabstand: {0} m", objektabstand);
                                Console.WriteLine("Bildweite: {0} m", bildweite);
                                Console.WriteLine("Vergrößerung: {0:F2}", vergroesserung);
                                Console.WriteLine("Linsestärke: {0:F2} Dioptrien", linsestaerke);

                                Console.WriteLine("\nWenn Sie fertig sind drucken Sie bitte 'Enter'...");
                                Console.ReadKey();

                            }catch (FormatException) { }    

                        }

                    case "exit":
                        Environment.Exit(0);
                        break;

                    case "submenu":
                        Console.Clear();
                        return;

                    default:
                        Console.Clear();
                        break;


                }

            } while (true);
        }
    }
}
