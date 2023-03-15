using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBFTKlassenBibliothek
{
    class feat14
    {
        public static void dpi()
        {
            Console.WriteLine("WIllkommen zum DPI Reschner");
            Console.WriteLine("Beliebige Taste zum fortfahren");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Mit Hilfe des DPI Reschner, können Sie die Auflösung eines Bildes Bereschnen.");
            Console.WriteLine("Dies Funktioniert in dem Sie die Anzahl der Pixel einmal in der Höhe und der Breite Angeben.");
            Console.WriteLine("Beliebige Taste zum fortfahren");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Sie Können nun die Pixel in Höhe und Breite Angeben");
            Console.WriteLine("Beliebige Taste zum fortfahren");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Geben Sie nun bitte die Höhe in Pixel an");
             int Höhe = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Geben Sie nun bitte die Breite in Pixel an");
            int Breite = Convert.ToInt32(Console.ReadLine());

            int DPI = Höhe * Breite;

            Console.WriteLine($"Ihre DPI betragen {DPI}");
        }
    }
}


