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
            bool flag1, Validinput1 = true, Validinput2 = true, Validinput3 = true, Validinput4 = true, Validinput5 = true, Validinput6 = true, Validinput7 = true;
            int menu;
            string input1, input2, input3, input4, input5, input6;




            do
            {
                //Menu
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Exit");
                Console.WriteLine("W�hlen Sie bitte eine Option (1 oder 2): ");
                // �berpr�fung der Benutzereingabe
                flag1 = (int.TryParse(Console.ReadLine(), out menu));
                // �berpr�ft der Benutzereingabe menu kleiner als 1
                if (flag1 == true && menu <1 )
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.WriteLine("Dr�cken um neu einzugeben");
                    Console.ReadKey();
                    Console.Clear();
                    
                }else if (flag1 == true && menu > 2)  // �berpr�ft der Benutzereingabe menu Gr��er als 2
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.WriteLine("Dr�cken um neu einzugeben");
                    Console.ReadKey();
                    Console.Clear();
                   
                }else if (flag1 == false) // �berpr�fung ob die Eingabe eine Zahl ist
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.WriteLine("Dr�cken um neu einzugeben");
                    Console.ReadKey();
                    Console.Clear();
                  
                }

                if (menu == 1) //wenn menu 1 ausgew�hlt wird
                {
                    do
                    {
                        do{
                            Console.WriteLine("Gib den erste x Koordinat ein : "); // Benutzereingabe f�r x1
                            input1 = Console.ReadLine();
                            if (input1.ToLower() == "exit")   // �berpr�fung ob die Benutzereingabe "exit" ist
                            {
                                Console.WriteLine("Konsole wird Beedndet.");
                                Thread.Sleep(2300);
                                Environment.Exit(0);
                                break;

                            }

                            while (!double.TryParse(input1, out x1))  // �berpr�fung ob die Eingabe eine Zahl ist
                            {
                                Validinput1 = false;
                                Console.WriteLine("Falsche Eingabe");
                                Console.WriteLine("Dr�cken um neu einzugeben");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            }
                        } while (!Validinput1) ;
                        do{
                            Console.WriteLine("Gib den erste y Koordinat ein : "); // Benutzereingabe f�r y1
                            input2 = Console.ReadLine();
                            if (input2.ToLower() == "exit")  // �berpr�fung ob die Benutzereingabe "exit" ist
                            {
                                Console.WriteLine("Konsole wird Beedndet.");
                                Thread.Sleep(2300);
                                Environment.Exit(0);

                            }

                            while (!double.TryParse(input2, out y1))  // �berpr�fung ob die Eingabe eine Zahl ist
                            {
                                Validinput2 = false;
                                Console.WriteLine("Falsche Eingabe");
                                Console.WriteLine("Dr�cken um neu einzugeben");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            }

                        } while (!Validinput2) ;
                       do {
                            Console.WriteLine("Gib den zweite x Koordinat ein : "); // Benutzereingabe f�r x2
                            input3 = Console.ReadLine();
                            if (input3.ToLower() == "exit")   // �berpr�fung ob die Benutzereingabe "exit" ist
                            {
                                Console.WriteLine("Konsole wird Beedndet.");
                                Thread.Sleep(2300);
                                Environment.Exit(0);
                            }

                            while (!double.TryParse(input3, out x2))  // �berpr�fung ob die Eingabe eine Zahl ist
                            {
                                Validinput3 = false;
                                Console.WriteLine("Falsche Eingabe");
                                Console.WriteLine("Dr�cken um neu einzugeben");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            }

                       } while (!Validinput3);
                       do { 
                           Console.WriteLine("Gib den zweite y Koordinat ein : "); // Benutzereingabe f�r y2
                           input4 = Console.ReadLine();
                           if (input4.ToLower() == "exit")   // �berpr�fung ob die Benutzereingabe "exit" ist
                           {
                               Console.WriteLine("Konsole wird Beedndet.");
                               Thread.Sleep(2300);
                               Environment.Exit(0);
                           }
                           while (!double.TryParse(input4, out y2))  // �berpr�fung ob die Eingabe eine Zahl ist
                           {
                                Validinput4 = false;
                                Console.WriteLine("Falsche Eingabe");
                               Console.WriteLine("Dr�cken um neu einzugeben");
                               Console.ReadKey();
                               Console.Clear();
                               break;

                           }
                       } while (!Validinput4) ;
                       do{
                           Console.WriteLine("Gib den Dritte x Koordinat ein : "); // Benutzereingabe f�r x3
                           input5 = Console.ReadLine();
                           if (input5.ToLower() == "exit")  // �berpr�fung ob die Benutzereingabe "exit" ist
                           {
                               Console.WriteLine("Konsole wird Beedndet.");
                               Thread.Sleep(2300);
                               Environment.Exit(0);
                               break;

                           }
                           while (!double.TryParse(input5, out x3))  // �berpr�fung ob die Eingabe eine Zahl ist 
                           {
                                Validinput5 = false;
                               Console.WriteLine("Falsche Eingabe");
                               Console.WriteLine("Dr�cken um neu einzugeben");
                               Console.ReadKey();
                               Console.Clear();
                               break;

                           }
                       } while (!Validinput5) ;
                       do{
                           Console.WriteLine("Gib den dritten y Koordinat ein:"); // Benutzereingabe f�r y3
                           input6 = Console.ReadLine();

                           if (input6.ToLower() == "exit") ;   // �berpr�fung ob die Benutzereingabe "exit" ist
                           {
                               Environment.Exit(0);
                               break;

                           }
                           while (!double.TryParse(input6, out y3))  // �berpr�fung ob die Eingabe eine Zahl ist
                           {
                               Validinput6 = false;
                               Console.WriteLine("Falsche Eingabe");
                               Console.WriteLine("Dr�cken um neu einzugeben");
                               Console.ReadKey();
                               Console.Clear();
                               break;
                           }   
                            
                       } while (!Validinput6);


                        // Linearlit�t test
                        linearity = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

                        if (linearity == 0) //Wenn Benutzereingabe Linear ist
                        {
                            Console.WriteLine("Die 3 punkte sind linear.");
                            Console.WriteLine("Dr�cken um neu einzugeben.");
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
       




