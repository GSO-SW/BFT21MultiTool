using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MABFTKlassenBibliothek
{
    class Feature22
    {
        public static void flachenberechnung()
        {   
            string s1;
            int i1;
            double d1;
            string s2;
            int i2;
            string s3;
            int i3;

            string U; //Es werden Zusatzangaben für die Umfangberechnung benötigt. string U gibt an, ob der Umfang berechnet werden soll.
            string u1; //Grundseite a, Umfang.
            int u1i;  //Grundseite a, Umfang, Integer.
            string u2; //Seite b, Umfang.
            int u2i; //Seite b, Umfang, integer...
            string u3;
            int u3i;
            string u4;
            int u4i;

            //Es gibt für jede Eingabe einen string sowohl einen integer, da ich das Wort "exit" nicht mit einem integer erkennen kann, das Programm würde abstürzen.

            //Flächenformeln(A):Quadrat=a*a | Rechteck=a*b | Parallelogramm=a*h | Trapez=(a+c)*h/2 | Dreieck=0,5*g*h | Drachen(-viereck)/Raute=0,5*e*f | Kreis=pi*r²
            //Spezielle Umfangsformel U für Kreis= 2*r*pi

            //menu
            bool tryparseout;
            bool tryparseoutmenu;
            string Smenu;
            int menu;
            //menu 9
            string Thema = "Fehler";
            int Fsum = 0000;
            int Usum = 0000;

            int zsum1;
            int zsum;
            double dsum;
            double fdsum;
            double fusum;

            do
            {
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Flächen- und Umfangberechnung <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("Willkommen in der Unterkategorie Flächen- und Umfangberechnung!\n" +
                    "Wählen sie eine Form aus, indem sie die zugehörige Zahl eingeben und Enter drücken.:\n" +
                    "1 - Quadrat\n" +
                    "2 - Rechteck\n" +
                    "3 - Parallelogramm\n" +
                    "4 - Trapez\n" +
                    "5 - Dreieck\n" +
                    "6 - Drachen (-viereck) / Raute\n" +
                    "7 - Kreis\n" +
                    "8 - Formeln\n" +
                    "9 - Letztes Ergebnis erneut ausgeben\n" +
                    "Tipp: mit der Eingabe des Wortes exit können sie das programm jederzeit verlassen.");
                Smenu = Console.ReadLine();

                if (Smenu == "exit")
                {
                    Environment.Exit(0);
                }
                tryparseoutmenu = int.TryParse(Smenu, out menu);

                Console.Clear();
                if (menu == 1)
                {
                    do
                    {
                        Console.WriteLine("Geben sie die Länge oder die Breite ein und drücken sie anschließen ENTER.");
                        s1 = Console.ReadLine();
                        if (s1 == "exit")
                        {
                            Environment.Exit(0);
                        }
                        tryparseout = int.TryParse(s1, out i1);
                        if (tryparseout == false)
                        {
                            Console.WriteLine("Fehler, machen sie erneut eine Eingabe.");
                        }
                    } while (tryparseout == false);
                    Thema = "Quadrat";
                    Fsum = i1 * i1;
                    Usum = i1 + i1 + i1 +i1;
                    Console.WriteLine($"Die Fläche beträgt{Fsum}__²\n" +
                            $"Der Umfang beträgt {Usum}__²");
                }
                if (menu == 2)
                {
                    do
                    {
                        Console.WriteLine("Bitte geben sie die Länge der Seite a ein und drücken sie anschließen ENTER.");
                        s1 = Console.ReadLine();
                        if (s1 == "exit")
                        {
                            Environment.Exit(0);
                        }
                        tryparseout = int.TryParse(s1, out i1);
                        if (tryparseout == false)
                        {
                            Console.WriteLine("Fehler, machen sie erneut eine Eingabe.");
                        }
                        Console.WriteLine("Bitte geben sie die Länge der Seite b ein und drücken sie anschließen ENTER.");
                        s2 = Console.ReadLine();
                        if (s2 == "exit")
                        {
                            Environment.Exit(0);
                        }
                        tryparseout = int.TryParse(s2, out i2);
                        if (tryparseout == false)
                        {
                            Console.WriteLine("Fehler, machen sie erneut eine Eingabe.");
                        }
                    } while (tryparseout == false);
                    Thema = "Rechteck";
                    Fsum = i2 * i2;
                    Usum = i2 + i2 + i2 + i2;
                    Console.WriteLine($"Die Fläche beträgt{Fsum}__²\n" +
                            $"Der Umfang beträgt {Usum}__²");
                }
                if (menu == 3)
                {
                    do
                    {
                        Console.WriteLine("Geben sie die Länge der Grundseite ein");
                        s1 = Console.ReadLine();
                        if (s1 == "exit")
                        {
                            Environment.Exit(0);
                        }
                        tryparseout = int.TryParse(s1, out i1);
                        Console.WriteLine("Geben sie die Höhe ein");
                        s2 = Console.ReadLine();
                        if (s2 == "exit")
                        {
                            Environment.Exit(0);
                        }
                        tryparseout = int.TryParse(s2, out i2);
                        Thema = "Parallelogramm";
                        Fsum = i1 * i2;
                        Console.WriteLine("Wollen sie den Umfang berechnen [ja] oder den Flächeninhalt wissen und das Programm beenden [exit]?");
                        U = Console.ReadLine();
                        if (U == "ja")
                        {
                            Console.WriteLine("Geben sie die Länge der Seite b ein.");
                            u1 = Console.ReadLine();
                            tryparseout = int.TryParse(u1, out u1i);
                            Usum = i1 + i1 + u1i + u1i;
                            Console.WriteLine($"Ihre Fläche beträgt: {Fsum}__²");
                            Console.WriteLine($"Der Umfang beträgt: {Usum}__");
                        }
                        if (U == "exit")
                        {
                            Console.WriteLine($"Ihre Fläche beträgt: {Fsum}__²\n" +
                                "Drücken sie eine beliebige Taste um das Programm zu beenden.");
                            Console.ReadKey();
                            Environment.Exit(0);

                        }
                    } while (tryparseout == false);
                }
                if (menu == 4)
                {
                    do
                    {
                        Console.WriteLine("Geben sie die Länge der Grundseite (a) ein");
                        s1 = Console.ReadLine();
                        if (s1 == "exit")
                        {
                            Environment.Exit(0);
                        }
                        tryparseout = int.TryParse(s1, out i1);
                        Console.WriteLine("Geben sie die Länge für die Seite C ein");
                        s2 = Console.ReadLine();
                        if (s2 == "exit")
                        {
                            Environment.Exit(0);
                        }
                        tryparseout = int.TryParse(s2, out i2);
                        Console.WriteLine("Geben sie die Höhe ein");
                        s3 = Console.ReadLine();
                        if (s3 == "exit")
                        {
                            Environment.Exit(0);
                        }
                        tryparseout = int.TryParse(s3, out i3);
                        Thema = "Trapez";
                        zsum1 = i1 + i2;
                        zsum = zsum1 * i3;
                        Fsum = zsum / 2;
                        Console.WriteLine("Wollen sie den Umfang berechnen [ja] oder den Flächeninhalt wissen und das Programm beenden [exit]?");
                        U = Console.ReadLine();
                        if (U == "ja")
                        {
                            Console.WriteLine("Geben sie die Länge der Seite b ein.");
                            u1 = Console.ReadLine();
                            tryparseout = int.TryParse(u1, out u1i);
                            Console.WriteLine("Geben sie die Länge der Seite d ein.");
                            u2 = Console.ReadLine();
                            tryparseout = int.TryParse(u2, out u2i);
                            Usum = i1 + u1i + i2 + u2i;
                            Console.WriteLine($"Ihre Fläche beträgt: {Fsum}__²");
                            Console.WriteLine($"Der Umfang beträgt: {Usum}__");
                        }
                        if (U == "exit")
                        {
                            Console.WriteLine($"Ihre Fläche beträgt: {Fsum}__²\n" +
                                "Drücken sie eine beliebige Taste um das Programm zu beenden.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    } while (tryparseout == false);
                }
                if (menu == 5)
                {
                    do
                    {
                        Console.WriteLine("Geben sie die Länge der Grundseite ein");
                        s1 = Console.ReadLine();
                        if (s1 == "exit")
                        {
                            Environment.Exit(0);
                        }
                        tryparseout = int.TryParse(s1, out i1);
                        Console.WriteLine("Geben sie die Höhe ein");
                        s2 = Console.ReadLine();
                        if (s2 == "exit")
                        {
                            Environment.Exit(0);
                        }
                        tryparseout = int.TryParse(s2, out i2);
                        Thema = "Dreieck";
                        zsum = 1 / 2;
                        Fsum = zsum * i1 * i2;
                        Console.WriteLine("Wollen sie den Umfang berechnen [ja] oder den Flächeninhalt wissen und das Programm beenden [exit]?");
                        U = Console.ReadLine();
                        if (U == "ja")
                        {
                            Console.WriteLine("Geben sie die Länge der Seite b ein.");
                            u1 = Console.ReadLine();
                            tryparseout = int.TryParse(u1, out u1i);
                            Console.WriteLine("Geben sie die Länge der Seite c ein.");
                            u2 = Console.ReadLine();
                            tryparseout = int.TryParse(u2, out u2i);
                            Usum = i1 + u1i + u2i;
                            Console.WriteLine($"Ihre Fläche beträgt: {Fsum}__²");
                            Console.WriteLine($"Der Umfang beträgt: {Usum}__");
                        }
                        if (U == "exit")
                        {
                            Console.WriteLine($"Ihre Fläche beträgt: {Fsum}__²\n" +
                                "Drücken sie eine beliebige Taste um das Programm zu beenden.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    } while (tryparseout == false);
                }
                if (menu == 6)
                {
                    do
                    {
                        Console.WriteLine("Geben sie die Länge der Diagonale e ein");
                        s1 = Console.ReadLine();
                        if (s1 == "exit")
                        {
                            Environment.Exit(0);
                        }
                        tryparseout = int.TryParse(s1, out i1);
                        Console.WriteLine("Geben sie die Länge der Diagonale f ein");
                        s2 = Console.ReadLine();
                        if (s2 == "exit")
                        {
                            Environment.Exit(0);
                        }
                        tryparseout = int.TryParse(s2, out i2);
                        Thema = "Drachen (-viereck)/Raute";
                        zsum = 1 / 2;
                        Fsum = zsum * i1 * i2;
                        Console.WriteLine("Wollen sie den Umfang berechnen [ja] oder den Flächeninhalt wissen und das Programm beenden [exit]?");
                        U = Console.ReadLine();
                        if (U == "ja")
                        {
                            Console.WriteLine("Geben sie die Länge der Seite a ein.");
                            u1 = Console.ReadLine();
                            tryparseout = int.TryParse(u1, out u1i);
                            Console.WriteLine("Geben sie die Länge der Seite b ein.");
                            u2 = Console.ReadLine();
                            tryparseout = int.TryParse(u2, out u2i);
                            Console.WriteLine("Geben sie die Länge der Seite c ein.");
                            u3 = Console.ReadLine();
                            tryparseout = int.TryParse(u3, out u3i);
                            Console.WriteLine("Geben sie die Länge der Seite d ein.");
                            u4 = Console.ReadLine();
                            tryparseout = int.TryParse(u4, out u4i);
                            Usum = u1i + u2i + u3i + u4i;
                            Console.WriteLine($"Ihre Fläche beträgt: {Fsum}__²");
                            Console.WriteLine($"Der Umfang beträgt: {Usum}__");
                        }
                        if (U == "exit")
                        {
                            Console.WriteLine($"Ihre Fläche beträgt: {Fsum}__²\n" +
                                "Drücken sie eine beliebige Taste um das Programm zu beenden.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    } while (tryparseout == false);
                }
                if (menu == 7)
                {
                    do
                    {
                        Console.WriteLine("Geben sie den Radius ein");
                        s1 = Console.ReadLine();
                        if (s1 == "exit")
                        {
                            Environment.Exit(0);
                        }
                        tryparseout = double.TryParse(s1, out d1);
                        dsum = d1 * 2;
                        Thema = "Kreis";
                        fdsum = 3.14159 * dsum;
                        fusum = dsum * 3.14159;
                        Fsum = Convert.ToInt32(fdsum);
                        Usum = Convert.ToInt32(fusum);
                        Console.WriteLine($"Ihre Fläche beträgt: {Fsum}__²");
                        Console.WriteLine($"Der Umfang beträgt: {Usum}__");

                    } while (tryparseout == false);
                }
                if (menu == 8)
                {
                    Console.WriteLine("Flächenformeln(A):Quadrat=a*a | Rechteck=a*b | Parallelogramm=a*h | Trapez=(a+c)*h/2 | Dreieck=0,5*g*h | Drachen(-viereck)/Raute=0,5*e*f | Kreis=pi*r²\n" +
                        "Spezielle Umfangsformel U für Kreis= 2*r*pi ( Bei allen anderen Formen alle Seiten multiplizieren");
                }
                if (menu == 9)
                {
                    Console.WriteLine($"Ihr letztes Ergebnis war im Themenbereich {Thema} und es kam\n" +
                        $"{Fsum}__² als Summe des Flächeninhalts raus und\n" +
                        $"{Usum}__ als Summe des Umfangs heraus.");
                }
                else if (menu < 1 || menu > 9 || tryparseoutmenu == false)
                {
                    Console.WriteLine("Falsche Eingabe, bitte versuchen sie es nochmal");
                }
                Console.WriteLine("Drücken sie die Taste ENTER um ins Menü zu gelangen.");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }
    }
}
