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

            // Variablendeklaration
            double x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, a, b, c, y, x, linearity;
            bool flag1, Validinput1 = true, Validinput2 = true, Validinput3 = true, Validinput4 = true, Validinput5 = true, Validinput6 = true;
            int menu;
            string input1, input2, input3, input4, input5, input6;




            do
            {
                //Menu
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Exit");
                Console.WriteLine("Wählen Sie bitte eine Option (1 oder 2): ");               
                flag1 = (int.TryParse(Console.ReadLine(), out menu)); // Überprüfung der Benutzereingabe
                if (flag1 == true && menu <1) // Überprüft der Benutzereingabe menu kleiner als 1
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.WriteLine("Drücken um neu einzugeben");
                    Console.ReadKey();
                    Console.Clear();
                    
                }else if (flag1 == true && menu > 2)  // Überprüft der Benutzereingabe menu Größer als 2
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.WriteLine("Drücken um neu einzugeben");
                    Console.ReadKey();
                    Console.Clear();
                   
                }else if (flag1 == false) // Überprüfung ob die Eingabe eine Zahl ist
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.WriteLine("Drücken um neu einzugeben");
                    Console.ReadKey();
                    Console.Clear();
                  
                }

                if (menu == 1) //wenn menu 1 ausgewählt wird
                {
                    do
                    {
                        do
                        {
                            Console.Write("Gib den erste x Koordinat ein : "); // Benutzereingabe für x1
                            input1 = Console.ReadLine();
                            if (input1.ToLower() == "exit")   // Überprüfung ob die Benutzereingabe "exit" ist
                            {
                                Console.WriteLine("Konsole wird Beedndet.");
                                Thread.Sleep(2300);
                                Environment.Exit(0);
                                break;

                            }

                            while (!double.TryParse(input1, out x1))  // Überprüfung ob die Eingabe eine Zahl ist
                            {
                                Validinput1 = false;
                                Console.WriteLine("Falsche Eingabe");
                                Console.WriteLine("Drücken um neu einzugeben");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            }

                        } while (!Validinput1);

                        do
                        {
                            Console.WriteLine("Gib den erste y Koordinat ein : "); // Benutzereingabe für y1
                            input2 = Console.ReadLine();
                            if (input2.ToLower() == "exit")  // Überprüfung ob die Benutzereingabe "exit" ist
                            {
                                Console.WriteLine("Konsole wird Beedndet.");
                                Thread.Sleep(2300);
                                Environment.Exit(0);

                            }

                            while (!double.TryParse(input2, out y1))  // Überprüfung ob die Eingabe eine Zahl ist
                            {
                                Validinput2 = false;
                                Console.WriteLine("Falsche Eingabe");
                                Console.WriteLine("Drücken um neu einzugeben");
                                Console.ReadKey();

                                break;

                            }

                        } while (!Validinput2);

                        do
                        {
                            Console.WriteLine("Gib den zweite x Koordinat ein : "); // Benutzereingabe für x2
                            input3 = Console.ReadLine();
                            if (input3.ToLower() == "exit")   // Überprüfung ob die Benutzereingabe "exit" ist
                            {
                                Console.WriteLine("Konsole wird Beedndet.");
                                Thread.Sleep(2300);
                                Environment.Exit(0);
                            }

                            while (!double.TryParse(input3, out x2))  // Überprüfung ob die Eingabe eine Zahl ist
                            {
                                Validinput3 = false;
                                Console.WriteLine("Falsche Eingabe");
                                Console.WriteLine("Drücken um neu einzugeben");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            }

                        } while (!Validinput3);

                        do
                        {
                            Console.WriteLine("Gib den zweite y Koordinat ein : "); // Benutzereingabe für y2
                            input4 = Console.ReadLine();
                            if (input4.ToLower() == "exit")   // Überprüfung ob die Benutzereingabe "exit" ist
                            {
                                Console.WriteLine("Konsole wird Beedndet.");
                                Thread.Sleep(2300);
                                Environment.Exit(0);
                            }
                            while (!double.TryParse(input4, out y2))  // Überprüfung ob die Eingabe eine Zahl ist
                            {
                                Validinput4 = false;
                                Console.WriteLine("Falsche Eingabe");
                                Console.WriteLine("Drücken um neu einzugeben");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            }

                        } while (!Validinput4);

                        do
                        {
                            Console.WriteLine("Gib den Dritte x Koordinat ein : "); // Benutzereingabe für x3
                            input5 = Console.ReadLine();
                            if (input5.ToLower() == "exit")  // Überprüfung ob die Benutzereingabe "exit" ist
                            {
                                Console.WriteLine("Konsole wird Beedndet.");
                                Thread.Sleep(2300);
                                Environment.Exit(0);
                                break;

                            }
                            while (!double.TryParse(input5, out x3))  // Überprüfung ob die Eingabe eine Zahl ist 
                            {
                                Validinput5 = false;
                                Console.WriteLine("Falsche Eingabe");
                                Console.WriteLine("Drücken um neu einzugeben");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            }

                        } while (!Validinput5);

                        do
                        {
                            Console.WriteLine("Gib den dritten y Koordinat ein:"); // Benutzereingabe für y3
                            input6 = Console.ReadLine();

                            if (input6.ToLower() == "exit")   // Überprüfung ob die Benutzereingabe "exit" ist
                            {
                                Environment.Exit(0);
                                break;

                            }
                            while (!double.TryParse(input6, out y3))  // Überprüfung ob die Eingabe eine Zahl ist
                            {
                                Validinput6 = false;
                                Console.WriteLine("Falsche Eingabe");
                                Console.WriteLine("Drücken um neu einzugeben");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                        } while (!Validinput6);


                        // Linearlität test
                        linearity = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

                        if (linearity == 0) //Wenn Benutzereingabe Linear ist
                        {
                            Console.WriteLine("Die 3 punkte sind linear.");
                            Console.WriteLine("Drücken um neu einzugeben.");
                            Console.ReadKey();

                        }



                        if (linearity != 0) // Wenn Benutzereingabe nicht Linear ist
                        {
                            // Berechnung der Funktion
                            a = (x1 * (y2 - y3) * x1 * (y3 - y2) + x2 * x2 * (y1 - y3) + x3 * x3 * (y2 - y1)) / linearity;
                            c = (x1 * +x2 * (y1 - y3) + x3 * (y3 - y1)) / linearity;
                            b = (x1 * x1 * (x2 * y3 - x3 * y2) + x2 * x2 * (x3 * y1 - x1 * y3) + x3 * x3 * (x1 * y2 - x2 * y1)) / linearity;

                            Console.WriteLine("Der Quadratische Funktion ist: y = " + a + "x^2 + " + b + "x + " + c);
                            Thread.Sleep(3500);
                            Console.WriteLine("Drücke um neu Einzugeben oder beedende das Konsole mit (Exit).");
                            string menu2 = Console.ReadLine();
                            if (menu2.ToLower() == "exit")   // Überprüfung ob die Benutzereingabe "exit" ist
                            {
                                Console.WriteLine("Konsole wird Beedndet.");
                                Thread.Sleep(2300);
                                Environment.Exit(0);
                                break;

                            }


                        }


                    } while (linearity == 0); // wenn der Funktion Linear ist wird es zu menu geleitet

                } 
                else if (menu == 2)// wenn Benutzereingabe "2" ist 
                {
                    Environment.Exit(0);
                }

                static void DrawQuadraticGraph(Double[] coefficients, double x) // Brechnung der Graphen
                {

                }
      
            }while (true); // unendliche Schleife
        }
    }         
} 
