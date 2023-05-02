using System;
using System.ComponentModel;
using System.Linq.Expressions;
using Figgle;

namespace PHBFTKlassenBibliothek
{
    internal class Feature7
    {
        public static void Einfache_harmonische_Bewegung()
        {


            //Exit

            string input;


            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                var LogoName = "\tEinfache Harmonische Bewegung";
                var LogoDisplay = FiggleFonts.Slant.Render(LogoName);
                Console.WriteLine(LogoDisplay);
                Console.WriteLine("");
                Console.WriteLine("Info: In diesem Abteil (Einfache Harmonische Bewegung) können sie 3 verschiedene Themen wählen die sie berechnen möchten,");
                Console.WriteLine("Sie Können jederzeit mit dem befehl 'exit' das programm beenden oder mit 'subexit' ins Submenu zurück.\n");
                Console.WriteLine("Themas:\t\n \t1. Einfaches Pendel.\n \t2. Mass on a Spring.\n \t3. Simulation der Ausbreitung von Wellen");


                Console.Write("Eingabe:");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        while (true)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine(FiggleFonts.Slant.Render("Einfaches Pendel"));
                                Console.WriteLine("");
                                Console.WriteLine("====================================================================\n");
                                Console.WriteLine("Info: Hier berechnen sie ein Einfaches Pendel wenn eine bestimmte Kraft wirkt unzwar die Schwerkraft,");
                                Console.WriteLine("Sie können jederzeit mit dem Befehl 'exit' das Programm beenden oder mit dem Befehl 'submenu' ins submenu zurück.\n");
                                Console.Write("Geben Sie die Amplitude (in Meter) ein: ");
                                string amplitudestr = Console.ReadLine();

                                if (amplitudestr.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Environment.Exit(0);
                                }
                                else if (amplitudestr.ToLower() == "submenu")
                                {
                                    Console.Clear();
                                    return;
                                }


                                double amplitude = Convert.ToDouble(amplitudestr);
                                Console.Write("Geben Sie die Frequenz (in Hertz) ein: ");

                                string frequenzstr = Console.ReadLine();

                                if (frequenzstr.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Environment.Exit(0);
                                }
                                else if (frequenzstr.ToLower() == "submenu")
                                {
                                    Console.Clear();
                                    return;
                                }

                                double frequenz = Convert.ToDouble(frequenzstr);

                                Console.Write("Geben Sie die Phasenverschiebung (in Grad) ein: ");

                                string phasenverschiebungstr = Console.ReadLine();


                                if (phasenverschiebungstr.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Environment.Exit(0);
                                }
                                else if (phasenverschiebungstr.ToLower() == "submenu")
                                {
                                    Console.Clear();
                                    return;
                                }

                                double phasenverschiebung = Convert.ToDouble(phasenverschiebungstr);
                                Console.WriteLine("Wie viel Sekunden soll die zeitangabe betragen(in Sekunden)");

                                string sekundenstr = Console.ReadLine();

                                if (sekundenstr.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Environment.Exit(0);
                                }
                                else if (sekundenstr.ToLower() == "submenu")
                                {
                                    Console.Clear();
                                    return;
                                }

                                int sekunden = Convert.ToInt32(sekundenstr);

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
                                Console.WriteLine("Geben Sie 'exit' ein um das Programm zu beenden oder 'submenu' um zurück zum Submenu zu kommen...");
                                while (zeit < 1200)
                                {
                                    zeit += sekunden;
                                    position = amplitudeInRad * Math.Sin(omega * zeit + phasenverschiebungInRad);
                                    Console.Write("zeit: {0:F1}s " + " \t\t " + "position: {1}m \n", zeit, position);


                                }
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
                                Console.WriteLine(FiggleFonts.Slant.Render("Masse auf einer Feder"));
                                Console.WriteLine("");
                                Console.WriteLine("====================================================================");
                                Console.WriteLine("Info: Hier berechen sie, wenn eine kraft/Masse die auf eine feder einwirkt und wie die feder sich verschiebt,");
                                Console.WriteLine("Sie können jederzeit mit dem Befehl 'exit' das Programm beenden oder mit dem Befehl 'submenu' ins submenu zurück.");
                                Console.Write("Geben Sie die Federkonstante (in N/m) ein: ");
                                string federkonstantestr = Console.ReadLine();

                                if (federkonstantestr.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Environment.Exit(0);
                                }
                                else if (federkonstantestr.ToLower() == "submenu")
                                {
                                    Console.Clear();
                                    return;
                                }

                                double federkonstante = Convert.ToDouble(federkonstantestr);

                                Console.WriteLine("Geben Sie die Masse (in kg) ein");
                                string massestr = Console.ReadLine();

                                if (massestr.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Environment.Exit(0);
                                }
                                else if (massestr.ToLower() == "submenu")
                                {
                                    Console.Clear();
                                    return;
                                }

                                double masse = Convert.ToDouble(massestr);

                                Console.Write("Geben Sie die Anfangsauslenkung (in Meter) ein: ");
                                string auslenkungstr = Console.ReadLine();

                                if (auslenkungstr.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Environment.Exit(0);
                                }
                                else if (auslenkungstr.ToLower() == "submenu")
                                {
                                    Console.Clear();
                                    return;
                                }

                                double auslenkung = Convert.ToDouble(auslenkungstr);

                                Console.WriteLine("Wie viel Sekunden soll die zeitangabe betragen(in Sekunden)");
                                string sekundenstr = Console.ReadLine();

                                if (sekundenstr.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Environment.Exit(0);
                                }
                                else if (sekundenstr.ToLower() == "submenu")
                                {
                                    Console.Clear();
                                    return;
                                }

                                double sekunden = Convert.ToDouble(sekundenstr);

                                const double PI2 = 3.14159265359;
                                double omega2 = Math.Sqrt(federkonstante / masse);
                                double zeit2 = 0;
                                double position2 = auslenkung * Math.Cos(omega2 * zeit2);
                                double geschwindigkeit = -auslenkung * omega2 * Math.Sin(omega2 * zeit2);
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("Masse auf einer Feder:");
                                Console.WriteLine("Federkonstante = " + federkonstante + " N/m");
                                Console.WriteLine("Masse = " + masse + " kg");
                                Console.WriteLine("Anfangsauslenkung = " + auslenkung + " m");
                                Console.WriteLine("Sekunden = " + sekunden + " s");
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("Zeit (s)\tPosition (m)\tGeschwindigkeit (m/s)");
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("Geben Sie 'exit' ein um das Programm zu beenden oder 'submenu' um ins submenu zurück zu kommen...");
                                while (zeit2 < 1200)
                                {
                                    Console.Write(zeit2 + "\t\t" + position2 + "\t\t" + geschwindigkeit + "\n");
                                    zeit2 += 0.1;
                                    position2 = auslenkung * Math.Cos(omega2 * zeit2);
                                    geschwindigkeit = -auslenkung * omega2 * Math.Sin(omega2 * zeit2);


                                }
                                
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
                                Console.WriteLine(FiggleFonts.Slant.Render("Simulation der Ausbreitung von Wellen"));
                                Console.WriteLine("");
                                Console.WriteLine("====================================================================");
                                Console.WriteLine("Info: Hier berechnen sie die dauer einer Simulation von der Ausbreitung von Wellen ");
                                Console.WriteLine("Sie können jederzeit mit dem Befehl 'exit' das Programm Beenden oder mit dem Befehl 'submenu' ins submenu zurück.");
                                Console.Write("Geben Sie die Wellenlänge in Metern ein: ");
                                string wellenlaengestr = Console.ReadLine();

                                if (wellenlaengestr.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Environment.Exit(0);
                                }
                                else if (wellenlaengestr.ToLower() == "submenu")
                                {
                                    Console.Clear();
                                    return;
                                }

                                double wellenlaenge = Convert.ToDouble(wellenlaengestr);

                                Console.Write("Geben Sie die Anzahl der Wellen ein: ");
                                string wellenanzahlstr = Console.ReadLine();

                                if (wellenanzahlstr.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Environment.Exit(0);
                                }
                                else if (wellenanzahlstr.ToLower() == "submenu")
                                {
                                    Console.Clear();
                                    return;
                                }

                                double wellenanzahl = Convert.ToDouble(wellenanzahlstr);

                                Console.Write("Geben Sie die Ausbreitungsgeschwindigkeit der Welle in m/s ein: ");
                                string ausbreitungsgeschwindigkeitstr = Console.ReadLine();

                                if (ausbreitungsgeschwindigkeitstr.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Environment.Exit(0);
                                }
                                else if (ausbreitungsgeschwindigkeitstr.ToLower() == "submenu")
                                {
                                    Console.Clear();
                                    return;
                                }

                                double ausbreitungsgeschwindigkeit = Convert.ToDouble(ausbreitungsgeschwindigkeitstr);

                                Console.Write("Geben Sie die Dauer der Simulation in Sekunden ein: ");
                                string dauerstr = Console.ReadLine();

                                if (dauerstr.ToLower() == "exit")
                                {
                                    Console.Clear();
                                    Environment.Exit(0);
                                }
                                else if (dauerstr.ToLower() == "submenu")
                                {
                                    Console.Clear();
                                    return;
                                }

                                double dauer = Convert.ToDouble(dauerstr);


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
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("Simulation abgeschlossen. Geben sie 'exit' ein, um das Programm zu beenden oder 'submenu' ein um zum submenu zu kommen...");


                                
                            }
                            catch (FormatException) { }
                        }
                    case "exit":
                        Console.Clear();
                        Console.WriteLine("Bye Bye...");
                        Environment.Exit(0);
                        break;

                    case "submenu":
                        Console.Clear();
                        return;


                    default:

                        Console.Clear();

                        break;
                }

            }

        }
    }
}
