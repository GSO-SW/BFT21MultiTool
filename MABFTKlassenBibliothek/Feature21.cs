using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MABFTKlassenBibliothek
{
    class Feature21
    {
        public static void Polynom()
        {
            string menu;
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Polynom <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

            Console.WriteLine("1. Programm starten");
            Console.WriteLine("2. Zurück zum Mathemenü");
            Console.Write(">");
            menu = Console.ReadLine();

            if(menu == "1") { 
            Console.WriteLine("Geben Sie die Koeffizienten des Polynoms in aufsteigender Reihenfolge des Grades an: ");
            string[] coefficients = Console.ReadLine().Split();
            int[] polynomialCoefficients = new int[coefficients.Length];
            for (int i = 0; i < coefficients.Length; i++)
            {
                polynomialCoefficients[i] = int.Parse(coefficients[i]);
            }

            Console.WriteLine("Geben Sie den Wert von x ein: ");
            int x = int.Parse(Console.ReadLine());

            int result = CalculatePolynomialValue(polynomialCoefficients, x);
            Console.WriteLine("Der Wert des Polynoms ist: " + result);

            Console.WriteLine("\nDarstellung des Polynomgraphen:");
            DrawCoordinateSystem();
            DrawPolynomialGraph(polynomialCoefficients, x);
            Console.ReadKey(true);
            }
            else if(menu == "2")
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\tSie werden nun zum Mathemenü geleitet!");
                Thread.Sleep(1000);
                Console.Clear();
                MABFTKlassenBibliothek.MAMenue.MASubMenue();
            }
        }

        static int CalculatePolynomialValue(int[] coefficients, int x)
        {
            int result = 0;
            for (int i = 0; i < coefficients.Length; i++)
            {
                result += (int)Math.Pow(x, i) * coefficients[i];
            }
            return result;
        }

        static void DrawCoordinateSystem()
        {
            Console.WriteLine("+-------------+");
            for (int i = 10; i >= -10; i--)
            {
                Console.Write("|");
                for (int j = -10; j <= 10; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write("+");
                    }
                    else if (i == 0)
                    {
                        Console.Write("-");
                    }
                    else if (j == 0)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("+-------------+");
        }

        static void DrawPolynomialGraph(int[] coefficients, int x)
        {
            for (int i = -10; i <= 10; i++)
            {
                int y = CalculatePolynomialValue(coefficients, i);
                Console.SetCursorPosition(10 + i, 10 - y);
                Console.Write("*");
            }
        }
    }
}
