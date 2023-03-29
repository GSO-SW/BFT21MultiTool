

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PHBFTKlassenBibliothek
{
    class Feature9
    {
        public static void einfacheschaltung()
        {
            Console.WriteLine("Wilkommen im Bereich Einfache Schaltungen!");

            while (true)
            {
                Console.WriteLine("Bitte wählen sie ein Thema:");
                Console.WriteLine("1. Ohmischer Gesetz Rechner");
                Console.WriteLine("2. Kirchhoff Simulator");
                Console.Write("Bitte treffen sie eine Wahl (1-2): ");

                try
                {
                    string c = Console.ReadLine();
                    if (c == "exit")
                    {
                        Environment.Exit(0);
                    }
                    int choice = int.Parse(c);

                    switch (choice)
                    {
                        case 1:
                            OhmsLawCalculator();
                            break;
                        case 2:
                            KirchhoffSimulator();
                            break;
                        default:
                            Console.WriteLine("Fehler, bitte versuchen sie erneut.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Falsche Eingabe, geben sie eine Zahl ein.");
                }
            }
        }






        static void OhmsLawCalculator()
        {
            Console.WriteLine("Willkommen beim Ohmschen Gesetz Rechner!");

            while (true)
            {
                try
                {
                    Console.Write("Spannung eingeben (V): ");
                    string s = Console.ReadLine();
                    if (s == "exit")
                    {
                        Environment.Exit(0);
                    }
                    double spannung = double.Parse(s);

                    Console.Write("Widerstand eingeben (Ω): ");
                    string w = Console.ReadLine();
                    if (w == "exit")
                    {
                        Environment.Exit(0);
                    }
                    double widerstand = double.Parse(w);

                    double strom = spannung / widerstand;

                    Console.WriteLine("Stromstärke (A) = " + strom);
                    Thread.Sleep(2000);
                    Console.WriteLine("Bitte drücken sie die Taste ENTER");
                    Console.ReadLine();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Der Widerstand darf nicht null sein. Bitte geben Sie einen von null verschiedenen Wert ein.");
                }
            }
        }

        static void KirchhoffSimulator()
        {
            Console.WriteLine("Willkommen beim Kirchhoff-Simulator!");

            while (true)
            {
                try
                {
                    Console.Write("Gesamtstromstärke eingeben (A): ");
                    string gS = Console.ReadLine();
                    if (gS == "exit")
                    {
                        Environment.Exit(0);
                    }
                    double gesamtStromstaerke = double.Parse(gS);

                    Console.Write("Anzahl der Stromquellen eingeben: ");
                    string aS = Console.ReadLine();
                    if (aS == "exit")
                    {
                        Environment.Exit(0);
                    }
                    int anzahlStromquellen = int.Parse(aS);

                    double[] stromstaerken = new double[anzahlStromquellen];

                    for (int i = 0; i < anzahlStromquellen; i++)
                    {
                        Console.Write("Stromstärke der Stromquelle " + (i + 1) + " eingeben (A): ");
                        string ss = Console.ReadLine();
                        stromstaerken[i] = double.Parse(ss);
                    }

                    double summeStromstaerken = 0;

                    for (int i = 0; i < anzahlStromquellen; i++)
                    {
                        summeStromstaerken += stromstaerken[i];
                    }

                    if (summeStromstaerken != gesamtStromstaerke)
                    {
                        throw new Exception("Die Summe der Stromstärken der Stromquellen stimmt nicht mit der Gesamtstromstärke überein.");
                    }

                    Console.WriteLine("Die Simulation war erfolgreich.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }              

}