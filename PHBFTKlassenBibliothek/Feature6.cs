using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHBFTKlassenBibliothek
{
    internal class Feature6
    {
        public static void Optik()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            var LogoName = "\tOptik";
            var LogoDisplay = FiggleFonts.Slant.Render(LogoName);
            Console.WriteLine(LogoDisplay);


            Console.WriteLine("Themas:\t\n \t1. Snelliussches Brechungsgesetz.\n \t2. Linsengleichung.\n \t3. Farbmischung");
            Console.Write("Eingabe:");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Snelliussches Brechungsgesetz"));

                    Console.Write("Geben Sie den Einfallswinkel in Grad ein: ");
                    double angleOfIncidence = double.Parse(Console.ReadLine());

                    Console.Write("Geben Sie den Brechungsindex des ersten Mediums ein: ");
                    double n1 = double.Parse(Console.ReadLine());

                    Console.Write("Geben Sie den Brechungsindex des zweiten Mediums ein: ");
                    double n2 = double.Parse(Console.ReadLine());

                    // Konvertieren des Einfallswinkels von Grad in Bogenmaß
                    double angleOfIncidenceRadians = angleOfIncidence * Math.PI / 180;

                    // Berechnen des Brechungswinkels mit Snells Gesetz
                    double angleOfRefractionRadians = Math.Asin((n1 / n2) * Math.Sin(angleOfIncidenceRadians));

                    // Konvertieren des Brechungswinkels von Bogenmaß in Grad
                    double angleOfRefraction = angleOfRefractionRadians * 180 / Math.PI;

                    // Ausgabe der Ergebnisse
                    Console.WriteLine("Einfallswinkel: {0:F2} Grad", angleOfIncidence);
                    Console.WriteLine("Brechungswinkel: {0:F2} Grad", angleOfRefraction);
                    Console.WriteLine("\nWenn Sie fertig sind drucken Sie bitte 'Enter'...");
                    Console.ReadKey();
                    PHBFTKlassenBibliothek.PHMenue.PHSubMenue();

                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Linsengleichung"));

                    Console.Write("Geben Sie die Brennweite der Linse ein (in mm): ");
                    double brennweite = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Geben Sie den Abstand des Objekts zur Linse ein (in mm): ");
                    double objektAbstand = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Geben Sie die Größe des Objekts ein (in mm): ");
                    double objektGröße = Convert.ToDouble(Console.ReadLine());

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
                    PHBFTKlassenBibliothek.PHMenue.PHSubMenue();
                    break;

                case "3":

                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Farbmischung"));

                    // Define colors and their intensities
                    string[] colors = { "rot", "grün", "blau" };
                    double[] intensities = new double[3];

                    // Prompt user to input color intensities
                    for (int i = 0; i < colors.Length; i++)
                    {
                        Console.Write("Geben Sie die Intensität von {0} ein (zwischen 0 und 1): ", colors[i]);
                        intensities[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    // Calculate resulting color
                    double red = intensities[0];
                    double green = intensities[1];
                    double blue = intensities[2];

                    Console.WriteLine("Ergebnisfarbe: ({0}, {1}, {2})", red, green, blue);

                    Console.WriteLine("\nWenn Sie fertig sind drucken Sie bitte 'Enter'...");
                    Console.ReadKey();
                    PHBFTKlassenBibliothek.PHMenue.PHSubMenue();

                    break;



            }
        }
    }
}
