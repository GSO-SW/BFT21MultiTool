using System;
using System.Threading.Channels;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;

namespace MABFTKlassenBibliothek
{
    public class MAMenue
    {
        public static void MASubMenue()
        {
            do {
                int time = DateTime.Now.Hour;
                Console.Title = "Mathematik";
                ConsoleKeyInfo keyPressed = Console.ReadKey();


                Console.Clear();
                Console.WriteLine(@" /$$      /$$  /$$$$$$  /$$$$$$$$ /$$   /$$ /$$$$$$$$ /$$      /$$  /$$$$$$  /$$$$$$$$ /$$$$$$ /$$   /$$");
                Console.WriteLine(@"| $$$    /$$$ /$$__  $$|__  $$__/| $$  | $$| $$_____/| $$$    /$$$ /$$__  $$|__  $$__/|_  $$_/| $$  /$$/");
                Console.WriteLine(@"| $$$$  /$$$$| $$  \ $$   | $$   | $$  | $$| $$      | $$$$  /$$$$| $$  \ $$   | $$     | $$  | $$ /$$/ ");
                Console.WriteLine(@"| $$ $$/$$ $$| $$$$$$$$   | $$   | $$$$$$$$| $$$$$   | $$ $$/$$ $$| $$$$$$$$   | $$     | $$  | $$$$$/  ");
                Console.WriteLine(@"| $$  $$$| $$| $$__  $$   | $$   | $$__  $$| $$__/   | $$  $$$| $$| $$__  $$   | $$     | $$  | $$  $$  ");
                Console.WriteLine(@"| $$\  $ | $$| $$  | $$   | $$   | $$  | $$| $$      | $$\  $ | $$| $$  | $$   | $$     | $$  | $$\  $$ ");
                Console.WriteLine(@"| $$ \/  | $$| $$  | $$   | $$   | $$  | $$| $$$$$$$$| $$ \/  | $$| $$  | $$   | $$    /$$$$$$| $$ \  $$");
                Console.WriteLine(@"|__/     |__/|__/  |__/   |__/   |__/  |__/|________/|__/     |__/|__/  |__/   |__/   |______/|__/  \__/");
                Thread.Sleep(1000);

                Console.WriteLine("\n\n------------------------------------------------------------------------------------\n" +
                                   "                              >>> Mathematik <<<\n" +
                                   "------------------------------------------------------------------------------------\n\n");

                if(time >= 0 && time < 12)
                {
                    Console.WriteLine("Guten Morgen! Es ist jetzt grade " + DateTime.Now.ToString("HH:mm") + " Uhr!\n");
                }
                else if(time >= 12 && time < 18)
                {
                    Console.WriteLine("Guten Nachmittag! Es ist jetzt grade " + DateTime.Now.ToString("HH:mm") + " Uhr!\n");
                }
                else
                {
                    Console.WriteLine("Guten Abend! Es ist jetzt grade " + DateTime.Now.ToString("HH:mm") + " Uhr!\n");
                }


                Console.WriteLine("----------Menü----------");
                Console.WriteLine("1 -> Polynom");
                Console.WriteLine("2 -> Flächenberechnung");
                Console.WriteLine("3 -> Quadratische Funktionen");
                Console.WriteLine("4 -> Lineare Funktionen");
                Console.WriteLine("5 -> Zurück ins Hauptmenü");
                Console.WriteLine("(Bitte wählen Sie irgendein Themenbereich mit deinen Pfeiltasten und drücke ENTER wenn du es gewählt hast)");
                Console.WriteLine("------------------------");
                Console.Write("> ");
                string menu = Console.ReadLine();

                if (menu == "1")
                {
                    Console.Clear();
                    Feature21.Polynom();
                }
                else if(menu == "2")
                {
                    Console.Clear();
                    Feature22.flaechenberechnung();
                }
                else if(menu == "3")
                {
                    Console.Clear();
                    Feature23.quadratischefunktionen();
                }
                else if(menu == "4")
                {
                    Console.Clear();
                    Feature24.linearefunktionen();
                }
                else if (menu == "5")
                {
                    Console.Clear();
                    break;
                }
                else if (menu.StartsWith("test"))

                {
                    Console.WriteLine("Comming Soon");
                    Console.ReadKey();
                }
            } while (true);
        }
    }
}