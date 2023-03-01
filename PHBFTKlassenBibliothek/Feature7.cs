using System;
using System.ComponentModel;
using Figgle;

namespace PHBFTKlassenBibliothek
{
    internal class Feature7
    {
        public static void Einfache_harmonische_Bewegung()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            var LogoName = "\tEinfache harmonische Bewegung";
            var LogoDisplay = FiggleFonts.Slant.Render(LogoName);
            Console.WriteLine(LogoDisplay);
            Console.WriteLine("Themas:\t\n \t1. Einfaches Pendel.\n \t2. Mass on a Spring.\n \t3. Simulation der Ausbreitung von Wellen");

            Console.Write("Eingabe:");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Einfaches Pendel"));
                    Console.WriteLine("====================================================================");

                    Console.Write("Geben Sie die Amplitude (in Meter) ein: ");
                    double amplitude;
                    while (!double.TryParse(Console.ReadLine(), out amplitude))
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Amplitude ein: ");
                    }
                    Console.Write("Geben Sie die Frequenz (in Hertz) ein: ");
                    double frequenz;
                    while (!double.TryParse(Console.ReadLine(), out frequenz))
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Frequenz ein: ");
                    }
                    Console.Write("Geben Sie die Phasenverschiebung (in Grad) ein: ");
                    double phasenverschiebung;
                    while (!double.TryParse(Console.ReadLine(), out phasenverschiebung))
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Phasenverschiebung ein: ");
                    }             // Berechnung der einfachen harmonischen Bewegung
                    const double PI = 3.14159265359;
                    double amplitudeInRad = amplitude * PI / 180;
                    double phasenverschiebungInRad = phasenverschiebung * PI / 180;
                    double omega = 2 * PI * frequenz;
                    double zeit = 0;
                    double position = amplitude * Math.Sin(omega * zeit + phasenverschiebungInRad);             // Ausgabe
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Einfache harmonische Bewegung:");
                    Console.WriteLine("Amplitude = " + amplitude + " m");
                    Console.WriteLine("Frequenz = " + frequenz + " Hz");
                    Console.WriteLine("Phasenverschiebung = " + phasenverschiebung + " Grad");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Zeit (s)\tPosition (m)");
                    Console.WriteLine("----------------------------------");             // Schleife zur Berechnung und Ausgabe der Position
                    while (true)
                    {
                        Console.Write(zeit + "\t\t" + position + "\n");
                        zeit += 0.1;
                        position = amplitude * Math.Sin(omega * zeit + phasenverschiebungInRad);                 // Abfrage, ob der Benutzer das Programm beenden möchte
                        Console.WriteLine("Drücken Sie 'q', um das Programm zu beenden, oder eine andere Taste, um fortzufahren...");
                        string eingabe = Console.ReadLine();
                        if (eingabe == "q")
                        {
                            break;
                        }
                    }             // Löschen der Konsole
                    Console.Clear();

                    break;


                case "2":

                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Mass on a Spring"));
                    Console.WriteLine("====================================================================");

                    // Eingabeaufforderungen
                    Console.Write("Geben Sie die Federkonstante (in N/m) ein: ");
                    double federkonstante;
                    while (!double.TryParse(Console.ReadLine(), out federkonstante))
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Federkonstante ein: ");
                    }
                    Console.Write("Geben Sie die Masse (in kg) ein: ");
                    double masse;
                    while (!double.TryParse(Console.ReadLine(), out masse))
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Masse ein: ");
                    }
                    Console.Write("Geben Sie die Anfangsauslenkung (in Meter) ein: ");
                    double auslenkung;
                    while (!double.TryParse(Console.ReadLine(), out auslenkung))
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Auslenkung ein: ");
                    }             // Berechnung der Bewegung der Masse an der Feder
                    const double PI2 = 3.14159265359;
                    double omega2 = Math.Sqrt(federkonstante / masse);
                    double zeit2 = 0;
                    double position2 = auslenkung * Math.Cos(omega2 * zeit2);
                    double geschwindigkeit = -auslenkung * omega2 * Math.Sin(omega2 * zeit2);             // Ausgabe
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Mass on a Spring:");
                    Console.WriteLine("Federkonstante = " + federkonstante + " N/m");
                    Console.WriteLine("Masse = " + masse + " kg");
                    Console.WriteLine("Anfangsauslenkung = " + auslenkung + " m");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Zeit (s)\tPosition (m)\tGeschwindigkeit (m/s)");
                    Console.WriteLine("----------------------------------");             // Schleife zur Berechnung und Ausgabe der Position und Geschwindigkeit
                    while (true)
                    {
                        Console.Write(zeit2 + "\t\t" + position2 + "\t\t" + geschwindigkeit + "\n");
                        zeit2 += 0.1;
                        position2 = auslenkung * Math.Cos(omega2 * zeit2);
                        geschwindigkeit = -auslenkung * omega2 * Math.Sin(omega2 * zeit2);                 // Abfrage, ob der Benutzer das Programm beenden möchte
                        Console.WriteLine("Drücken Sie 'q', um das Programm zu beenden, oder eine andere Taste, um fortzufahren...");
                        string eingabe = Console.ReadLine();
                        if (eingabe == "q")
                        {
                            break;
                        }
                    }

                    Console.Clear();
                    break;
                  

                case "3":

                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Simulation der Ausbreitung von Wellen"));
                    Console.WriteLine("====================================================================");

                    Console.Write("Geben Sie die Wellenlänge in Metern ein: ");
                    double wellenlaenge = double.Parse(Console.ReadLine());
                    Console.Write("Geben Sie die Anzahl der Wellen ein: ");
                    double wellenanzahl = double.Parse(Console.ReadLine());
                    Console.Write("Geben Sie die Ausbreitungsgeschwindigkeit der Welle in m/s ein: ");
                    double ausbreitungsgeschwindigkeit = double.Parse(Console.ReadLine());
                    Console.Write("Geben Sie die Dauer der Simulation in Sekunden ein: ");
                    double dauer = double.Parse(Console.ReadLine());

                    // Simulation durchführen und Ergebnisse auf der Konsole ausgeben
                    Console.WriteLine();
                    Console.WriteLine("Durchführung der Simulation...");
                    Console.WriteLine();

                    for (double zeit3 = 0.0; zeit3 < dauer; zeit3 += 0.01)
                    {
                        double position3 = 0.0;
                        for (int i = 1; i <= wellenanzahl; i++)
                        {
                            double wellenposition = (i * wellenlaenge) - (ausbreitungsgeschwindigkeit * zeit3);
                            position3 += Math.Sin((2 * Math.PI * wellenposition) / wellenlaenge);
                        }
                        Console.WriteLine($"Zeit: {zeit3:F2} s  Position: {position3:F2}");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Simulation abgeschlossen. Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
                    Console.ReadKey();

                    Console.Clear();
                    break;
                   

                default:
                    Einfache_harmonische_Bewegung();
                    break;
            }
            
        }
    }
}

