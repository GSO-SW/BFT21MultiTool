using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WIBFTKlassenBibliothek
{
    internal class Feature18
    {



        public static void run()
        {
            bool exit = false;
            Console.WriteLine("Lohnsteuerberrechnung");
            Console.WriteLine("Disclaimer!\n" +
            "Dieses programm ist nicht als ersatz für einen finanzberater zu benutzen\n" +
            "das programm arbeitet mit evtl veralteten daten, und daher gilt keine garantie\n" +
            "auf jegliche angegebene werte.\n\nBestätigen sie durch das drücken einer taste");
            Console.ReadLine();
            bool res;
            while (exit == false)
            {
                //Bruttogehalt
                float eg1 = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Lohnsteuerberrehnung");
                    Console.WriteLine("Sie können das programm jederzeit durch die eingabe von Exit beenden.");
                    res = true;
                    Console.Write("Monatliches Bruttogehalt:");
                    string eg = Console.ReadLine().ToUpper();
                    switch (eg)
                    {
                        case "EXIT":
                            goto Kill;
                        default:
                            res = float.TryParse(eg, out eg1);
                            break;



                    }
                } while (!res);
                //Beiträge MTL
                float eg2 = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Lohnsteuerberrehnung");
                    Console.WriteLine("Sie können das programm jederzeit durch die eingabe von Exit beenden.");
                    res = true;
                    Console.Write("Summe aller monatlichen beiträge (versicherungen U.Ä.):");
                    string eg = Console.ReadLine().ToUpper();
                    switch (eg)
                    {
                        case "EXIT":
                            goto Kill;
                        default:
                            res = float.TryParse(eg, out eg2);
                            break;



                    }
                } while (!res);
                //KinderFreibetrag
                float eg3 = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Lohnsteuerberrehnung");
                    Console.WriteLine("Sie können das programm jederzeit durch die eingabe von Exit beenden.");
                    res = false;
                    Console.Write("Haben sie kinder [J/N]?");
                    string eg = Console.ReadLine().ToUpper();
                    if (eg == "J")
                    {
                        Console.Write("Geben sie ihren kinderfreibetrag an 0 wenn nicht vorhanden:");
                        eg = Console.ReadLine().ToUpper();
                        if (eg == "EXIT")
                            goto Kill;
                        res = float.TryParse(eg, out eg3);
                        if (eg3 < 0)
                            res = false;
                    }
                    else if (eg == "N")
                    {
                        res = true;
                    }
                    else if (eg == "EXIT")
                        goto Kill;
                } while (!res);
                //Steuerklasse
                short sk = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Lohnsteuerberrehnung");
                    Console.WriteLine("Sie können das programm jederzeit durch die eingabe von Exit beenden.");
                    Console.Write("Geben sie ihre steuerklasse als zahl ein [1-6]:");
                    string eg = Console.ReadLine().ToUpper();
                    if (eg == "EXIT")
                        goto Kill;
                    res = short.TryParse(eg, out sk);
                    if ((sk < 1) || (sk > 7))
                        res = false;
                } while (!res);
                float ges = eg1 - eg2 - eg3;
                short pc = 0;
                switch (sk)
                {
                    case 1:
                        if (ges < 9409) { pc = 0; }

                        else if (ges < 57052) { pc = 14; }

                        else if (ges < 270501) { pc = 42; }

                        else { pc = 45; }
                        break;
                    case 2:
                        if (ges < 9409) { pc = 0; }

                        else if (ges < 57052) { pc = 14; }

                        else if (ges < 270501) { pc = 42; }

                        else { pc = 45; }
                        break;
                    case 3:
                        if (ges < 18817) { pc = 0; }

                        else if (ges < 74409) { pc = 14; }

                        else if (ges < 270501) { pc = 42; }

                        else { pc = 45; }
                        break;
                    case 4:
                        if (ges < 1929) { pc = 0; }

                        else if (ges < 74409) { pc = 14; }

                        else if (ges < 270501) { pc = 42; }

                        else { pc = 45; }
                        break;
                    case 5:
                        if (ges < 9409) { pc = 0; }

                        else if (ges < 57052) { pc = 14; }

                        else if (ges < 270501) { pc = 42; }

                        else { pc = 45; }
                        break;
                    case 6:
                        if (ges < 9409) { pc = 0; }

                        else if (ges < 57052) { pc = 14; }

                        else if (ges < 270501) { pc = 42; }

                        else { pc = 45; }
                        break;
                }
                Console.Clear();
                Console.WriteLine("sie haben einen startbetrag von "+eg1+" eingegeben" +
                    "\n nach allen abzügen bleiben "+ges+" als zu versteuender betrag\n" +
                    "anhand ihrer steuerklasse "+sk+" erhalten sie einen steuersatz von "+pc+"%\n" +
                    "das entspricht "+ ges/100*pc +" in abzügen. Damit verbleiben "+ (ges-(ges/100*pc)) +" nach der versteuerung\n" +
                    "Drücken sie Enter um fortzufahren");
                Console.ReadLine();
            }
        Kill:;



        }
    }
}
