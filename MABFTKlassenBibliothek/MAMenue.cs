using System;
using System.Threading.Channels;

namespace MABFTKlassenBibliothek
{
    public class MAMenue
    {
        public static void MASubMenue()
        {
            do {
                Console.Title = "Mathematik";

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

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                   "                              >>> Mathematik <<<\n" +
                                   "------------------------------------------------------------------------------------\n\n");


                Console.WriteLine("----------Menü----------");
                Console.WriteLine("1. Polynom");
                Console.WriteLine("2. Flächenberechnung");
                Console.WriteLine("3. Quadratische Funktionen");
                Console.WriteLine("4. Lineare Funktionen");
                Console.WriteLine("(Bitte wählen Sie irgendein Themenbereich)");
                Console.WriteLine("------------------------");
                Console.Write("> ");
                int menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    Console.Clear();
                    Feature21.Polynom();
                }
                else if(menu == 2)
                {
                    Console.Clear();
                    Feature22.flaechenberechnung();
                }
                else if(menu == 3)
                {
                    Console.Clear();
                    Feature23.quadratischefunktionen();
                }
                else if(menu == 4)
                {
                    Console.Clear();
                    Feature24.linearefunktionen();
                }
            } while (true);
        }
    }
}