

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHBFTKlassenBibliothek
{
    internal class Feature9
    {
        internal static void PhysicFeature9()
        {
            Console.WriteLine("Welcome to Electronics Tools!");

            while (true)
            {
                Console.WriteLine("\nPlease select a tool to use:");
                Console.WriteLine("1. Ohm's Law Calculator");
                Console.WriteLine("2. Kirchhoff Simulator");
                Console.WriteLine("3. Circuit Diagram Creator");
                Console.Write("Enter your choice (1-3): ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            OhmsLawCalculator();
                            break;
                        case 2:
                            KirchhoffSimulator();
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
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
                    double spannung = double.Parse(Console.ReadLine());

                    Console.Write("Widerstand eingeben (Ω): ");
                    double widerstand = double.Parse(Console.ReadLine());

                    double strom = spannung / widerstand;

                    Console.WriteLine("Stromstärke (A) = " + strom);
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
                    double gesamtStromstaerke = double.Parse(Console.ReadLine());

                    Console.Write("Anzahl der Stromquellen eingeben: ");
                    int anzahlStromquellen = int.Parse(Console.ReadLine());

                    double[] stromstaerken = new double[anzahlStromquellen];

                    for (int i = 0; i < anzahlStromquellen; i++)
                    {
                        Console.Write("Stromstärke der Stromquelle " + (i + 1) + " eingeben (A): ");
                        stromstaerken[i] = double.Parse(Console.ReadLine());
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