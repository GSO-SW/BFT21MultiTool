using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WIBFTKlassenBibliothek
{
    internal class Feature20
    {
        static double ArrayAnalyze(string code)
        {
            //Define Array
            var currencies = new[]
            {
                new { Name = "US Dollar", Code = "USD", Rate = 1.00 },
                new { Name = "Euro", Code = "EUR", Rate = 1.17 },
                new { Name = "Japanese Yen", Code = "JPY", Rate = 0.0091 },
                new { Name = "British Pound", Code = "GBP", Rate = 1.38 },
                new { Name = "Canadian Dollar", Code = "CAD", Rate = 0.79 },
                new { Name = "Swiss Franc", Code = "CHF", Rate = 1.09 },
                new { Name = "Chinese Yuan", Code = "CNY", Rate = 0.15 },
                new { Name = "Swedish Krona", Code = "SEK", Rate = 0.12 },
                new { Name = "Australian Dollar", Code = "AUD", Rate = 0.73 },
                new { Name = "New Zealand Dollar", Code = "NZD", Rate = 0.67 },
                new { Name = "Hong Kong Dollar", Code = "HKD", Rate = 0.13 },
                new { Name = "Norwegian Krone", Code = "NOK", Rate = 0.11 },
                new { Name = "South Korean Won", Code = "KRW", Rate = 0.00089 },
                new { Name = "Turkish Lira", Code = "TRY", Rate = 0.12 },
                new { Name = "Russian Ruble", Code = "RUB", Rate = 0.014 },
                new { Name = "Indian Rupee", Code = "INR", Rate = 0.014 },
                new { Name = "Brazilian Real", Code = "BRL", Rate = 0.19 },
                new { Name = "South African Rand", Code = "ZAR", Rate = 0.068 },
                new { Name = "Mexican Peso", Code = "MXN", Rate = 0.049 },
                new { Name = "Israeli Shekel", Code = "ILS", Rate = 0.31 },
                new { Name = "Danish Krone", Code = "DKK", Rate = 0.16 },
                new { Name = "Polish Zloty", Code = "PLN", Rate = 0.26 },
                new { Name = "Singapore Dollar", Code = "SGD", Rate = 0.74 },
                new { Name = "Thai Baht", Code = "THB", Rate = 0.031 },
                new { Name = "Taiwan Dollar", Code = "TWD", Rate = 0.036 },
                new { Name = "Emirati Dirham", Code = "AED", Rate = 0.27 },
                new { Name = "Saudi Riyal", Code = "SAR", Rate = 0.27 },
            };
            string lcode = "NULL";
            float Rate = -1;
            int i = 0;
            while (i < 26)
            {
                lcode = currencies[i].Code;
                if (lcode == code)
                {
                    return currencies[i].Rate;
                }
                i++;
            }
            return Rate;
        }

        public static void run()
        {
            bool conf = false;
            double op1 = 0, op2 = 0, w1 = 0;
            string ip1 = "", ip2 = "";
            //currency 1 select
            do
            {
                Console.Clear();
                Console.WriteLine("Enter Starting Currncy Code [xyz]:");
                ip1 = Console.ReadLine().ToUpper();
                op1 = -2;
                if (ip1.Length == 3)
                {
                    op1 = Feature20.ArrayAnalyze(ip1);
                    if (op1 == -1)
                    {
                        Console.WriteLine("Die Währung konnte nicht gefunden. Bitte überprüfen sie ihre rechtschreibung\nSollte der fehler weiterhin bestehen ist die währung vom programm leider nicht unterstützt\nEingabe Drücken un fortzufahren");
                        Console.ReadLine();
                    }
                    else conf = true;
                }
                else if (ip1 == "EXIT")
                    goto exit;
                else
                {
                    Console.WriteLine("Format Fehler. der currency code muss aus exakt 3 zeichen bestehen\nDrücke Eingabe um fortzufahren");
                    Console.ReadLine();
                }
            } while (!conf);
            Console.WriteLine("Faktor ist 1" + ip1 + "=" + op1 + "USD");
            Console.ReadLine();
            conf = false;
            //currency 2 select
            do
            {
                Console.Clear();
                Console.WriteLine("Enter Aiming Currncy Code [xyz]:");
                ip2 = Console.ReadLine().ToUpper();
                op2 = -2;
                if (ip2.Length == 3)
                {
                    op2 = Feature20.ArrayAnalyze(ip2);
                    if (op2 == -1)
                    {
                        Console.WriteLine("Die Währung konnte nicht gefunden. Bitte überprüfen sie ihre rechtschreibung\nSollte der fehler weiterhin bestehen ist die währung vom programm leider nicht unterstützt\nEingabe Drücken un fortzufahren");
                        Console.ReadLine();
                    }
                    else conf = true;
                }
                else if (ip2 == "EXIT")
                    goto exit;
                else
                {
                    Console.WriteLine("Format Fehler. der currency code muss aus exakt 3 zeichen bestehen\nDrücke Eingabe um fortzufahren");
                    Console.ReadLine();
                }
            } while (!conf);
            Console.WriteLine("Faktor ist 1" + ip2 + "=" + op2 + "USD");
            Console.ReadLine();
            //currency calculations
            {
                conf = false;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Bitte zuletzt geldbetrag eingeben:");
                    string temp = Console.ReadLine().ToUpper();
                    conf = double.TryParse(temp, out w1);
                    if (temp == "EXIT")
                        goto exit;
                } while (!conf);
                Console.Clear();
                Console.WriteLine("Conversion rate is 1{2} -> {3}USD -> {0}{1}",(op1 * (op2 / 1)), ip2, ip1,op1);
                Console.WriteLine("Resulting in:{0}",(w1*op1*(op2/1)));

            }
        exit:;
        }

    }
}
