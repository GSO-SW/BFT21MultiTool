using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBFTKlassenBibliothek
{
    internal class Feature12
    {
        public Feature12()
        {   
            Console.WriteLine("//////////////////////////")
            Console.WriteLine("Bit und Byte Rechner Menü ");
            Console.WriteLine("//////////////////////////");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Bitte geben sie ihre Einheit ein");
            Console.WriteLine("");
            string X = Console.ReadLine();
            double x = Convert.ToDouble(X);
            Console.WriteLine(x);
            Console.WriteLine("");
            Console.WriteLine("Bitte Wählen sie ihre ihre Einheit aus");
            Console.WriteLine("( (1) = Windows Rechner)---( (2) = Normale Rechnung)"); //Auswahl für die Berechnungs Formel
           
            //Windows Rechner
            if (x <==1)
            {
                Console.Clear;
                Console.WriteLine(x);
                Console.WriteLine("");
                Console.WriteLine("Wählen sie ihre die Einheit ihrer Zahl");
                Console.WriteLine("");
                Console.WriteLine("(Bit = 1) (Kibit = 2) (Mibit = 3) (Gibit = 4) (Tibit = 5)");
                Console.WriteLine("(Byte = a) (KiByte = l) (MiByte = e) (GiByte = n) (TiByte = d)");


                


            }
            if else (x = = 2)
                        {

            }
        }
    }
}
