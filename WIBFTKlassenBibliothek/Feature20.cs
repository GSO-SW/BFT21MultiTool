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
        start:
            Console.Clear();
            Console.WriteLine("Enter Starting Currncy Code [xyz]:");
            string input = Console.ReadLine().ToUpper()1;
            double op = -2;
            if (input.Length == 3)
            {
                op = Feature20.ArrayAnalyze(input);
                if(op == -1)
                {
                    Console.WriteLine("Die Währung konnte nicht gefunden. Bitte überprüfen sie ihre rechtschreibung\nSollte der fehler weiterhin bestehen ist die währung vom programm leider nicht unterstützt\nEingabe Drücken un fortzufahren");
                    Console.ReadLine();
                    goto start;
                }
            }
            else
            {
                Console.WriteLine("Format Fehler. der currency code muss aus exakt 3 zeichen bestehen\nDrücke Eingabe um fortzufahren");
                Console.ReadLine();
                goto start;
            }
            Console.WriteLine("Faktor ist 1"+input+"="+op+"USD");
            Console.ReadLine();
        }

    }
}
