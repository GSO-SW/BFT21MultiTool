using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace MABFTKlassenBibliothek
{
    class Feature23
    {
#pragma warning disable 
        public static void quadratischefunktionen()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Quadratische Funktionen <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

           
            double x1, y1, x2, y2, x3, y3, a, b, c, y, x, linearity;
            bool flag1;
            bool flag2;
            int option;



            do
            {
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Exit");
                Console.WriteLine("Choose an option (1 or 2): ");
                flag1 = (int.TryParse(Console.ReadLine(), out option));
                if (flag1 == true && option < 0)
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.WriteLine("Du wirst zu Menü geleitet");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else if (flag1 == true && option > 2)
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.WriteLine("Du wirst zu Menü geleitet");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else if (flag1 == false)
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.WriteLine("Du wirst zu Menü geleitet");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                if (option == 1)
                {
                    do
                    {

                        Console.WriteLine("Gib den erste x Koordinat ein : ");
                        string input1 = Console.ReadLine();
                        if (input1.ToLower() == "Exit")
                        {
                            Environment.Exit(0);

                        } while (!double.TryParse(input1, out x1))
                        {
                            Console.WriteLine("Falsche Eingabe");
                            Console.WriteLine("Drücken um neu einzugeben");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        Console.WriteLine("Gib den erste y Koordinat ein : ");
                        string input2 = Console.ReadLine();
                        if (input2.ToLower() == "Exit")
                        {
                            Environment.Exit(0);
                        }
                        while (!double.TryParse(input2, out y1))
                        {

                            Console.WriteLine("Falsche Eingabe");
                            Console.WriteLine("Drücken um neu einzugeben");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        Console.WriteLine("Gib den zweite x Koordinat ein : ");
                        string input3 = Console.ReadLine();
                        if (input3.ToLower() == "Exit")
                        {
                            Environment.Exit(0);
                        }
                        while (!double.TryParse(input3, out x2))
                        {

                            Console.WriteLine("Falsche Eingabe");
                            Console.WriteLine("Drücken um neu einzugeben");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        Console.WriteLine("Gib den zweite y Koordinat ein : ");
                        string input4 = Console.ReadLine();
                        if (input4.ToLower() == "Exit")
                        {
                            Environment.Exit(0);
                        } while (!double.TryParse(input4, out y2))
                        {

                            Console.WriteLine("Falsche Eingabe");
                            Console.WriteLine("Drücken um neu einzugeben");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        Console.WriteLine("Gib den Dritte x Koordinat ein : ");
                        string input5 = Console.ReadLine();
                        if (input5.ToLower() == "Exit")
                        {
                            Environment.Exit(0);
                        } while (!double.TryParse(input5, out x3))
                        {

                            Console.WriteLine("Falsche Eingabe");
                            Console.WriteLine("Drücken um neu einzugeben");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        Console.WriteLine("Gib den dritten z Koordinat ein:");
                        string input6 = Console.ReadLine();
                        if (input6.ToLower() == "Exit")
                        {
                            Environment.Exit(0);
                        } while (!double.TryParse(input6, out y3))
                        {

                            Console.WriteLine("Falsche Eingabe");
                            Console.WriteLine("Drücken um neu einzugeben");
                            Console.ReadKey();
                            Console.Clear();

                        }

                        
                        // Linearity s
                        linearity = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

                        if (linearity == 0)
                        {
                            Console.WriteLine("Die 3 punkte sind linear.");
                            Console.WriteLine("Drücken um neu einzugeben.");
                            Console.ReadKey(0);

                        }


                        if (linearity != 0)
                        {
                            // Calculation of the function
                            a = (x1 * (y2 - y3) + x2 * (y1 - y3) + x3 * (y3 - y1)) / linearity;
                            b = (x1 * x1 * (y3 - y2) + x2 * x2 * (y1 - y3) + x3 * x3 * (y2 - y1)) / linearity;
                            c = (x1 * x1 * (x2 * y3 - x3 * y2) + x2 * x2 * (x3 * y1 - x1 * y3) + x3 * x3 * (x1 * y2 - x2 * y1)) / linearity;

                            Console.WriteLine("Der Quadratische Funktion ist: y = " + a + "x^2 + " + b + "x + " + c);
                            Thread.Sleep(3500);

                        }

                    } while (linearity == 0);

                }  else if (option == 2)
                {
                   break;
                }

            } while (true);
        }
    }
}



