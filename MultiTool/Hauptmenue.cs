using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace MultiTool
{
    internal class Hauptmenue
    {
        public static void HauptmenueAufruf()
        {
            bool Exit = false;

            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Hauptmenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("esc\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit der Software 'BFTMulti-Tool' sollen wiederkehrende oder besonders aufwendige\n" +
                                  "Aufgabenaus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben\n" +
                                  "ergeben sich aus den Problemstellungen aus dem Unterricht der Berufsfachschule für Technik.\n\n");

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

            } while (!Exit);


        }
    }
}