﻿using System;
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
            bool Exit = false; 
            Exit= true;
            bool submenü = false;
            double Kapitel = 0;
            double zinssatz = 0;
            double jahr = 0;
            double gewinn = 0;
            double kontostand = 0;

            
          
            Console.WriteLine("Bitte geben sie ihr kapital ein");

            string Kapitel_str = Console.ReadLine();
            do {
                if (Kapitel_str == "exit")
                {
                    Console.WriteLine("Programm wird beendet...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (Kapitel_str =="submenü")
                {
                    Console.WriteLine("Zurück zum Submenü");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Kapitel = Convert.ToDouble(Kapitel_str);
                }

            }
            while (Kapitel==0 & submenü == false); 

                    Console.WriteLine("Bitte geben sie ihr Zinssatz ein");
          string  zinssatz_str = Console.ReadLine();
            do
            {
                if (zinssatz_str == "exit")
                {
                    Console.WriteLine("Programm wird beendet...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (zinssatz_str == "submenü")
                {
                    Console.WriteLine("Zurück zum Submenü");
                    Console.ReadKey();
                    submenü = true;
                }
                else
                {
                   zinssatz = Convert.ToDouble(zinssatz_str);
                }

            }
            while (zinssatz == 0 & submenü == false);

            Console.WriteLine("Bitte geben sie ihr anlagedauer ein");
           string  jahr_str= Console.ReadLine();
            do
            {
                if (jahr_str == "exit")
                {
                    Console.WriteLine("Programm wird beendet...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (jahr_str == "submenü")
                {
                    Console.WriteLine("Zurück zum Submenü");
                    Console.ReadKey();
                    submenü = true;
                }
                else
                {
                    jahr = Convert.ToDouble(jahr_str);
                }

            }
            while (jahr == 0 & submenü == false);
            gewinn = Kapitel*zinssatz* jahr;

            Console.WriteLine($"Ihr Gewinn beträgt:{gewinn}");
            Console.ReadKey();


            
            


        }

    }
}
