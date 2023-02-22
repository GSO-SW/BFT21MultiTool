using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



                do
                {
                    Console.WriteLine("1. Start");
                    Console.WriteLine("2. Exit");
                    Console.WriteLine("Choose an option (1 or 2): ");

                    int option = int.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        do
                        {

                            Console.WriteLine("Enter the first x coordinate: ");
                            x1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the first y coordinate: ");
                            y1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the second x coordinate: ");
                            x2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the second y coordinate: ");
                            y2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the third x coordinate: ");
                            x3 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the third y coordinate: ");
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
                            for (int x = start; x <= end; x += increment)
                            {
                                y = a * x * x + b * x + c;
                                Console.WriteLine(x + "\t" + y);
                            }
                        }
                    }
                    else
                    {
                        break;
                    }


                } while (true);
            
        }
    }
}
