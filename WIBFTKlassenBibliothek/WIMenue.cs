using System.Security.Cryptography.X509Certificates;
using Figgle;

namespace WIBFTKlassenBibliothek
{
    public class WIMenue
    {
        public static void WISubMenue()
        {
            Console.Clear();
            //ASCII art Logo wird erzeugt.
            Console.WriteLine
                (FiggleFonts.Slant.Render("BFTMultiTool"));

            //Konsolentitel wird geändert.
            Console.Title = "BFTMultiTool";

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                          >>> Submenü Wirtschaft <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");

            Console.WriteLine("esc\t->\tbeendet das Programm");

            //Beschreibung der Software.
            Console.WriteLine("\n\nDas Submenü Wirtschaft soll verschiedene Rechner zur Verfügung stellen,\n" +
                               " die das berechnen wirtschaftlicher Aspekte erleichtern. Zudem soll die eingebaute Möglichkeit,\n" +
                               " Ergebnisse zwischenzuspeichern, das schnelle Benutzen mehrerer Funktionen,\n" +
                               " in zusammenhang miteinander, erleichtern.\n\n");


            ConsoleKeyInfo HauptAusw;


            //Eingabeaufforderung 
            Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
            Console.WriteLine("\te - Elektrotechnik");
            Console.WriteLine("\ti - Informatik");
            Console.WriteLine("\tm - Mathematik");
            Console.WriteLine("\tp - Physik");
            Console.WriteLine("\tw - Wirtschaft");
            HauptAusw = Console.ReadKey(true);

            switch (HauptAusw.Key)
            {
                case ConsoleKey.E:
                    Console.Clear();
                    //Hier das Etechnikmenü aufrufen
                    break;

                case ConsoleKey.I:
                    Console.Clear();
                    //Hier das Informationstechnikmenü aufrufen
                    break;

                case ConsoleKey.M:
                    Console.Clear();
                    //Hier das Mathematikmenü aufrufen
                    break;

                case ConsoleKey.P:
                    Console.Clear();
                    //Hier das Physikmenü aufrufen
                    break;

                case ConsoleKey.W:
                    Console.Clear();
                    //Hier das Wirtschaftsmenü aufrufen
                    break;

                case ConsoleKey.Escape:
                    Exit = true;
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
        public class Saves
        {
            double[] doubles;
            public static void save(decimal data)
            {

            }
            public static decimal load()
            {
                return 0;
            }
        }
    }
}