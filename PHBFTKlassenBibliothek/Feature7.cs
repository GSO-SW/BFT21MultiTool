using System;
using System.ComponentModel;
using Figgle;


PHBFTKlassenBibliothek.Feature7.Einfache_harmonische_Bewegung();

namespace PHBFTKlassenBibliothek
{
    internal class Feature7
    {
        public static void Einfache_harmonische_Bewegung()
        {


            //Exit

            int width = 1920;
            int height = 1080;

            Console.SetWindowSize(width, height);
            string input;
            
            
            do
            {



                Console.ForegroundColor = ConsoleColor.Red;
                var LogoName = "\tEinfache harmonische Bewegung";
                var LogoDisplay = FiggleFonts.Slant.Render(LogoName);
                Console.WriteLine(LogoDisplay);

                Console.WriteLine("Themas:\t\n \t1. Einfaches Pendel.\n \t2. Mass on a Spring.\n \t3. Simulation der Ausbreitung von Wellen");
                Console.WriteLine("Info: Sie Können jederzeit mit dem befehl 'exit' das programm beenden oder mit 'subexit' ins Submenu zurück.");

                Console.Write("Eingabe:");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Einfaches Pendel"));
                        Console.WriteLine("");
                        Console.WriteLine("====================================================================\n");
                        Console.WriteLine("Info: Hier berechnen sie ein Einfaches Pendel wenn eine bestimmte kraft wirkt unzwar die schwerkraft.");
                        Console.WriteLine("Sie können jederzeit mit dem befehl 'exit' das programm beenden oder mit dem befehl 'subexit' ins submenu zurück.\n");
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
                        }
                        Console.WriteLine("Wie viel Sekunden soll die zeitangabe betragen(in Sekunden)");
                        int sekunden;
                        while (!int.TryParse(Console.ReadLine(), out sekunden))
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Sekundenanzahl ein: ");
                        }
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        var LogoName2 = "\tEinfaches Pendel";
                        var LogoDisplay2 = FiggleFonts.Slant.Render(LogoName2);
                        Console.WriteLine(LogoDisplay2);
                        const double PI = 3.14159265359;

                        double amplitudeInRad = amplitude * PI / 180;
                        double phasenverschiebungInRad = phasenverschiebung * PI / 180;
                        double omega = 2 * PI * frequenz;
                        double zeit = 0;
                        double position = amplitude * Math.Sin(omega * zeit + phasenverschiebungInRad);

                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Einfache harmonische Bewegung:");
                        Console.WriteLine("Amplitude = " + amplitude + " m");
                        Console.WriteLine("Frequenz = " + frequenz + " Hz");
                        Console.WriteLine("Phasenverschiebung = " + phasenverschiebung + " Grad");
                        Console.WriteLine("Sekunden = " + sekunden + " s");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Zeit (s)\tPosition (m)");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Geben Sie 'exit' ein um das Programm zu beenden oder 'subexit' um zurück zum Submenu zu kommen...");
                        while (zeit < 1200)
                        {
                            zeit += sekunden;
                            position = amplitudeInRad * Math.Sin(omega * zeit + phasenverschiebungInRad);
                            Console.Write("zeit: {0:F1}s " + " \t\t " + "position: {1}m \n", zeit, position);


                        }
                        string eingabe = Console.ReadLine();
                        if (eingabe == "exit")
                        {
                            Console.WriteLine("Das Programm ist beendet...");
                            break;
                        }

                        Console.Clear();

                        break;


                    case "2":

                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Masse auf einer Feder"));
                        Console.WriteLine("====================================================================");
                        Console.WriteLine("Hier berechen sie, wenn eine kraft/Masse auf eine feder einwirkt und wie die feder sich verschiebt.");
                        Console.WriteLine("Sie können jederzeit mit dem befehl 'exit' das programm beenden oder mit dem befehl 'subexit' ins submenu zurück.");
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
                        }
                        Console.WriteLine("Wie viel Sekunden soll die zeitangabe betragen(in Sekunden)");
                        int sekunden2;
                        while (!int.TryParse(Console.ReadLine(), out sekunden2))
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Sekundenanzahl ein: ");
                        }
                        const double PI2 = 3.14159265359;
                        double omega2 = Math.Sqrt(federkonstante / masse);
                        double zeit2 = 0;
                        double position2 = auslenkung * Math.Cos(omega2 * zeit2);
                        double geschwindigkeit = -auslenkung * omega2 * Math.Sin(omega2 * zeit2);
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Mass on a Spring:");
                        Console.WriteLine("Federkonstante = " + federkonstante + " N/m");
                        Console.WriteLine("Masse = " + masse + " kg");
                        Console.WriteLine("Anfangsauslenkung = " + auslenkung + " m");
                        Console.WriteLine("Sekunden = " + sekunden2 + " s");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Zeit (s)\tPosition (m)\tGeschwindigkeit (m/s)");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Geben Sie 'exit' ein, um das Programm zu beenden, oder eine andere Taste, um fortzufahren...");
                        while (zeit2 < 1200)
                        {
                            Console.Write(zeit2 + "\t\t" + position2 + "\t\t" + geschwindigkeit + "\n");
                            zeit2 += 0.1;
                            position2 = auslenkung * Math.Cos(omega2 * zeit2);
                            geschwindigkeit = -auslenkung * omega2 * Math.Sin(omega2 * zeit2);


                        }
                        eingabe = Console.ReadLine();
                        if (eingabe == "exit")
                        {
                            Console.WriteLine("Das Programm ist beendet...");
                            break;
                        }

                        Console.Clear();
                        break;


                    case "3":

                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Simulation der Ausbreitung von Wellen"));
                        Console.WriteLine("====================================================================");
                        Console.WriteLine("Hier berechnen sie die dauer einer Simulation von der Ausbreitung von Wellen ");
                        Console.WriteLine("Sie können jederzeit mit dem befehl 'exit' das programm beenden oder mit dem befehl 'subexit' ins submenu zurück.");
                        Console.Write("Geben Sie die Wellenlänge in Metern ein: ");
                        double wellenlaenge = double.Parse(Console.ReadLine());
                        Console.Write("Geben Sie die Anzahl der Wellen ein: ");
                        double wellenanzahl = double.Parse(Console.ReadLine());
                        Console.Write("Geben Sie die Ausbreitungsgeschwindigkeit der Welle in m/s ein: ");
                        double ausbreitungsgeschwindigkeit = double.Parse(Console.ReadLine());
                        Console.Write("Geben Sie die Dauer der Simulation in Sekunden ein: ");
                        double dauer = double.Parse(Console.ReadLine());


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
                        Console.WriteLine("Simulation abgeschlossen. Geben sie 'exit' ein, um das Programm zu beenden oder 'subexit' ein um zum submenu zu kommen.");
                        eingabe = Console.ReadLine();
                        if (eingabe == "exit")
                        {
                            Console.WriteLine("Das Programm ist beendet...");
                            break;
                        }

                        Console.Clear();
                        break;

                    case "exit":
                        Console.Clear();
                        Console.WriteLine("Bye Bye...");
                        Environment.Exit(0);
                        break;

                    case "subexit":
                        return;
                        

                    default:
                        Console.WriteLine("Fehlereingabe");
                        Console.Clear();
                        break;
                }

            } while (input != "subexit");
            //Ende
        }
    }
}
