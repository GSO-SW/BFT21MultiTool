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

                        }while (!double.TryParse(input1, out x1)) {
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
                        } while (!double.TryParse(input2, out x2)) {
                          Console.WriteLine("Falsche Eingabe");
                          Console.WriteLine("Drücken um neu einzugeben");
                          Console.ReadKey();
                          Console.Clear();
                        }








                    Console.WriteLine("Falsche Eingabe");
                             Console.WriteLine("Du wirst zu Menü geleitet");
                             Thread.Sleep(2000);
                               
                             Console.WriteLine("Gib den zweite x Koordinat ein : ");
                             flag1 = double.TryParse(Console.ReadLine(), out x2);
                                 
                             Console.WriteLine("Falsche Eingabe");
                             Console.WriteLine("Du wirst zu Menü geleitet");
                             Thread.Sleep(2000);
                                   
                               
                             Console.WriteLine("Gib den zweite y Koordinat ein : ");
                             flag1 = double.TryParse(Console.ReadLine(), out y2);
                                     
                             Console.WriteLine("Falsche Eingabe");
                             Console.WriteLine("Du wirst zu Menü geleitet");
                             Thread.Sleep(2000);
                             Console.Clear();
                                    
                             Console.WriteLine("Gib den dritten x Koordinat ein : ");
                             flag1 = double.TryParse(Console.ReadLine(), out x3); if (flag1 == false)
                                         
                             Console.WriteLine("Falsche Eingabe");
                             Console.WriteLine("Du wirst zu Menü geleitet");
                             Thread.Sleep(2000);
                                          
                             Console.WriteLine("Gib den dritten z Koordinat ein:");
                             flag1 = double.TryParse(Console.ReadLine(), out y3); if (flag1 == false)
                                          
                             Console.WriteLine("Falsche Eingabe");
                             Console.WriteLine("Du wirst zu Menü geleitet");
                             Thread.Sleep(2000);
                             Console.Clear();
                                             
                                                   
                    } while (linearity == 0);

                    if (linearity != 0)
                    {
                        // Calculation of the function
                        a = (x1 * (y2 - y3) + x2 * (y1 - y3) + x3 * (y3 - y1)) / linearity;
                        b = (x1 * x1 * (y3 - y2) + x2 * x2 * (y1 - y3) + x3 * x3 * (y2 - y1)) / linearity;
                        c = (x1 * x1 * (x2 * y3 - x3 * y2) + x2 * x2 * (x3 * y1 - x1 * y3) + x3 * x3 * (x1 * y2 - x2 * y1)) / linearity;

                        Console.WriteLine("The quadratic function is: y = " + a + "x^2 + " + b + "x + " + c);

                        

                    }
                }
                else if (option == 2)
                {
                    break;
                }

            } while (true);
        }
    }
}



