using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIBFTKlassenBibliothek
{
    class Feature19
    {
    
    public static void run()
        {
            string auswahlmenü;
            do

            {
                Console.Clear();
                Console.WriteLine("Immobilienrechner");
                Console.WriteLine("Menü");
                Console.WriteLine("Bitte wählen Sie den passenden Rechner für Sie");
                Console.WriteLine("1 - Kaufkostenrechner");
                Console.WriteLine("2 - Mietrenditenrechner (Brutto)");
                Console.WriteLine("3 - Kreditlaufzeitrechner");
                Console.WriteLine("4 - Zurück zum Sub-Menü");
                Console.WriteLine("5 - Exit--> Programm beenden");
                auswahlmenü = Console.ReadLine();
                if (auswahlmenü == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Kaufkostenrechner");
                    Console.WriteLine("Geben Sie den Kaufpreis der Immobilie ein:");
                    string Kaufpreisvar = Console.ReadLine();
                    double Kaufpreisdouble = Convert.ToDouble(Kaufpreisvar);

                    Console.WriteLine("Geben Sie die Marklerkosten in % ein");
                    string Marklerkostenvar = Console.ReadLine();
                    double Marklerkostendouble = Convert.ToDouble(Marklerkostenvar);

                    double Notarbetrag = Kaufpreisdouble * 0.015;

                    double Grundwerbesteuer = Kaufpreisdouble * 0.065;

                    double Marklergeld = Marklerkostendouble / 100 * Kaufpreisdouble;
                    double Gesamt = Kaufpreisdouble + Notarbetrag + Grundwerbesteuer + Marklergeld;
                    Console.WriteLine($"Ihr Gesamtpreis beträgt:{Gesamt}EUR");

                    Console.ReadLine();

                }
                else if (auswahlmenü == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Mietrenditenrechner");
                    Console.WriteLine("Geben Sie die Jahreskaltmiete ein:");

                    string Jahreskaltmiete = Console.ReadLine();
                    double mietedouble = Convert.ToDouble(Jahreskaltmiete);

                    Console.WriteLine("Geben Sie den Kaufpreis der Immobilie ein:");
                    string immo = Console.ReadLine();
                    double immodouble = Convert.ToDouble(immo);

                    double rendite = mietedouble / immodouble * 100;
                    Console.WriteLine($"Ihr Mietrendite beträgt {rendite}%");
                    Console.ReadLine();

                }
                else if (auswahlmenü == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Kreditlaufzeitrechner");
                    Console.WriteLine("Geben Sie die Kreditsumme ein:");
                    string Ksumme = Console.ReadLine();
                    double ksdouble = Convert.ToDouble(Ksumme);
                    Console.WriteLine("Geben Sie ihre Zinsen ein:");
                    string zsumme = Console.ReadLine();
                    double zsdouble = Convert.ToDouble(zsumme);
                    Console.WriteLine("Geben Sie den Zinssatz in Prozent ein:");
                    string psumme = Console.ReadLine();
                    double psdouble = Convert.ToDouble(psumme);
                    double t = zsdouble * 100 * 360 / (ksdouble * psdouble);
                    Console.WriteLine($"Ihre Kreditlaufzeit liegt bei {t} Monaten");
                    Console.ReadLine();
                }
                else if (auswahlmenü == "5")
                {
                    Environment.Exit(0);
                }
            }
            while (auswahlmenü != "4" || auswahlmenü != "5");

        }
    
    }
}
