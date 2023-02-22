using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIBFTKlassenBibliothek
{
    internal class Feature17
    {
    
    public static void run()
        {
            double Kapitel = 0;
            double zinssatz = 0;
            double jahr = 0;
            double gewinn = 0;
            double kontostand = 0;
            Console.WriteLine("Bitte geben sie ihr kapital ein");
            Kapitel  = Convert .ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben sie ihr Zinssatz ein");
            zinssatz = Convert .ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben sie ihr anlagedauer ein");
            jahr= Convert .ToDouble(Console.ReadLine());
            
            gewinn = Kapitel*zinssatz* jahr;

            Console.WriteLine($"Ihr Gewinn beträgt:{gewinn}");
            Console.ReadKey();



        }

    }
}
