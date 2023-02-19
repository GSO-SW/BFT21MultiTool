using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math.Distances;
using Accord.Statistics.Kernels;

namespace MABFTKlassenBibliothek
{
    public class MAMenue
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;
        public static void MASubMenue()
        {
            do {

                int time = DateTime.Now.Hour;
                Console.Title = "Mathematik";
                string[] menuItems = { "1 -> Polynom", "2 -> Flächenberechnung", "3 -> Quadratische Funktionen", "4 -> Lineare Funktionen", "5 -> Zurück ins Hauptmenü"};
                int selectedItem = 0;
                Console.CursorVisible = false;
                
               
                bool hauptmenue;


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
                Thread.Sleep(1000);

                if(time >= 0 && time < 12)
                {
                    Console.WriteLine("Guten Morgen! Es ist jetzt grade " + DateTime.Now.ToString("HH:mm") + " Uhr!\n");
                    Thread.Sleep(1000);
                }
                else if(time >= 12 && time < 18)
                {
                    Console.WriteLine("Guten Nachmittag! Es ist jetzt grade " + DateTime.Now.ToString("HH:mm") + " Uhr!\n");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Guten Abend! Es ist jetzt grade " + DateTime.Now.ToString("HH:mm") + " Uhr!\n");
                    Thread.Sleep(1000);

                }


                do 
                {
                    Console.Clear();
                    Console.WriteLine("Bitte wähle ein Thema:");

                    for (int i = 0; i < menuItems.Length; i++)
                    {
                        if(i == selectedItem)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                        }
                        Console.WriteLine(menuItems[i]);
                        Console.ResetColor();
                    }

                    hauptmenue = false;
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    if(keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        selectedItem--;
                        if(selectedItem < 0)
                        {
                            selectedItem = menuItems.Length - 1;
                        }
                    }else if(keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        selectedItem++;
                        if(selectedItem >= menuItems.Length)
                        {
                            selectedItem = 0;
                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine($"Du hast: {menuItems[selectedItem]} gewählt");

                        if (selectedItem == 0)
                        {
                            Console.Clear();
                            Feature21.Polynom();
                        }
                        else if (selectedItem == 1)
                        {
                            Console.Clear();
                            Feature22.flaechenberechnung();
                        }
                        else if (selectedItem == 2)
                        {
                            Console.Clear();
                            Feature23.quadratischefunktionen();
                        }
                        else if(selectedItem == 3)
                        {
                            Console.Clear();
                            Feature24.linearefunktionen();
                        }
                        else if (selectedItem == 4)
                        {
                            Console.Clear();
                            hauptmenue = true;
                        }
                    }
                }while(!hauptmenue);
                
            } while (true);
        }
    }
}