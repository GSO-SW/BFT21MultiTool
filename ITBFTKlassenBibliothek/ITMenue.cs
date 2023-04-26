using Figgle;
namespace ITBFTKlassenBibliothek

{
    public class ITMenue
    {
        public static void SubmenueAufruf()
        {
            bool Exit = false;
            Console.ForegroundColor = ConsoleColor.Cyan;


            do
            {


                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool | INFORMATIK"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool | INFORMATIK";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                    "                              >>> IT submenü <<<\n" +
                                    "------------------------------------------------------------------------------------\n\n");



                //Beschreibung der Software.
                //Console.WriteLine("\n\nMit der Software 'BFTMulti-Tool' sollen wiederkehrende oder besonders aufwendige\n" +
                //                 "Aufgabenaus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben\n" +
                //                "ergeben sich aus den Problemstellungen aus dem Unterricht der Berufsfachschule für Technik.\n\n");

                string HauptAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Bit und Byte Rechner");
                Console.WriteLine("\t2 - DPi Rechner");
                Console.WriteLine("\t3 - Sound- und Video Speicherrechner");
                Console.WriteLine("\t4 - Binärer Rechner");
                Console.WriteLine("\texit - Beendung des Programmes\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine()
                    .ToLower();

                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();


                        //Hier das Etechnikmenü aufrufen
                        Feature12.Feature_12();
                        break;

                    case "2":
                        Console.Clear();
                        Feature14.Feature_14();
                        break;

                    case "3":
                        Console.Clear();
                        Feature11.Feature_11();
                        break;

                    case "4":
                        Console.Clear();
                        Feature13.Feature_13();
                        break;


                    case "exit":
                        Exit = true;
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();

                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }

            } while (!Exit);

        }
    }
}