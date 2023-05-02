using Figgle;


namespace ETBFTKlassenBibliothek
{
    public class ETBFTMenue
    {
        public static void ETMenue()
        {
            bool Exit = false;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("Elektrotechink"));

                //Konsolentitel wird geändert.
                Console.Title = "Elektrotechink";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Hauptmenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("");

                string HauptAusw;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Spannung als Energieaufteilung & Strom aus Ladungen je Zeit");
                Console.WriteLine("\t2 - Ohm'schesGesetz / Leistungsgesetz");
                Console.WriteLine("\t3 - Widerstand, Kondensator & Spule Berechnung");
                Console.WriteLine("\t4 - Spannungsfall & Leitungsquerschnitt berechnen\n");
                Console.WriteLine("");

                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        
                        break;

                    case "3":
                        Console.Clear();
                        
                        break;

                    case "4":
                        Console.Clear();
                        
                        break;

                    case "exit":
                        Exit = true;
                        break;
                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();
                        Console.SetCursorPosition(0, 0);
                        (int, int) cPosAM = Console.GetCursorPosition();

                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }

            } while (!Exit);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
        }
    }
}