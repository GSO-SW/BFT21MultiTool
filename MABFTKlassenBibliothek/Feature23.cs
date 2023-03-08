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
        public static void quadratischefunktionen()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Quadratische Funktionen <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

            double linearity;
            double x1;
            double y1;
            double x2;
            double y2;
            double x3;
            double y3;
            double a;
            double b;
            double c;
            double y;
            double x;
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
                        x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Gib den erste y Koordinat ein : ");
                        y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Gib den zweite x Koordinat ein : ");
                        x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Gib den zweite y Koordinat ein : ");
                        y2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Gib den dritten x Koordinat ein : ");
                        x3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Gib den dritten z Koordinat ein:");
                        y3 = int.Parse(Console.ReadLine());

                        // Linearity Test
                        linearity = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

                        if (linearity == 0)
                        {
                            Console.WriteLine("Die 3 punkte sind linear.");
                        }

                    } while (linearity == 0);

                    if (linearity != 0)
                    {
                        // Calculation of the function
                        a = (x1 * (y2 - y3) + x2 * (y1 - y3) + x3 * (y3 - y1)) / linearity;
                        b = (x1 * x1 * (y3 - y2) + x2 * x2 * (y1 - y3) + x3 * x3 * (y2 - y1)) / linearity;
                        c = (x1 * x1 * (x2 * y3 - x3 * y2) + x2 * x2 * (x3 * y1 - x1 * y3) + x3 * x3 * (x1 * y2 - x2 * y1)) / linearity;

                        Console.WriteLine("The quadratic function is: y = " + a + "x^2 + " + b + "x + " + c);

                        // Table of solutions
                        Console.WriteLine("Enter the starting value of x: ");
                        int start = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the ending value of x: ");
                        int end = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the increment value of x: ");
                        int increment = int.Parse(Console.ReadLine());
                        Console.WriteLine("x\ty");
                        for (x = start; x <= end; x += increment)
                        {
                            y = a * x * x + b * x + c;
                            Console.WriteLine(x + "\t" + y);
                        }




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



