using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBFTKlassenBibliothek
{
    internal class Feature11
    {
        internal static void Feature_11()
        {


            (int, int) cPosBM = Console.GetCursorPosition();

            Console.ForegroundColor = ConsoleColor.Blue;
            bool Exit = false;

            Console.WriteLine
                (FiggleFonts.Slant.Render("Sound und Video Speicherrechner"));

            Console.Title = "BFTMultiTool | INFORMATIK | Sound und Video speicherrechner";

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n" +
                                 "\"                                   >   >  >  Willkommen zum Sound-/Video-Speicherrechner!  <  <  <\n" +
                                 "------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n\n");
            int w = 0;
            int ww = 0;
            int www = 0;

            while (w != 4)
            {
                Console.WriteLine("[> Wählen Sie eine Option <]");
                Console.WriteLine("[1] Sound-Dateien Rechner");
                Console.WriteLine("[2] Video-Dateien Rechner");
                Console.WriteLine("[3] <- Zurück zum Submenü");
                Console.WriteLine("[4] [/] Beendung des Programmes");
                Console.WriteLine("> Eingabe:");

                try
                {
                    w = int.Parse(Console.ReadLine());

                    switch (w)
                    {

                        case 1:

                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;


                            Console.WriteLine
                                (FiggleFonts.Slant.Render("Sounddaten Speicherrechner"));

                            Console.Title = "BFTMultiTool | INFORMATIK | Sounddaten speicherrechner";

                            //Code für den Sound-Dateien Rechner 

                            Console.WriteLine("Wählen Sie eine Option aus");
                            Console.WriteLine("[1] .Wav Dateien Rechner");
                            Console.WriteLine("[2] .mp3 Dateien Rechner");
                            Console.WriteLine("[3] <- Zurück zum Submenü");
                            Console.WriteLine("> Eingabe:");


                            ww = int.Parse(Console.ReadLine());

                            switch (ww)
                            {
                                case 1:


                                    Console.WriteLine
                                (FiggleFonts.Slant.Render("Wav Sounddaten Speicherrechner"));

                                    Console.Title = "BFTMultiTool | INFORMATIK | Wav Sounddaten speicherrechner";

                                    //zum rechnen
                                    int auflösung = 0;
                                    int abtastrate = 0;
                                    short kanäle = 0;
                                    int zeitwav = 0;
                                    int übertragungsrate = 0;
                                    //speichertyp
                                    int Xbit = 0;
                                    int Xbyte = 0;
                                    int Xmbyte = 0;
                                    int Xgbyte = 0;


                                    Console.WriteLine("Bitte geben sie die Auflösung:");
                                    Console.WriteLine("> Eingabe:");
                                    Console.WriteLine("------------------------------------");
                                    auflösung = int.Parse(Console.ReadLine());

                                    Console.Clear();
                                    Console.WriteLine("Bitte geben sie die Abtastrate:");
                                    Console.WriteLine("> Eingabe:");
                                    Console.WriteLine("------------------------------------");
                                    abtastrate = int.Parse(Console.ReadLine());

                                    Console.Clear();
                                    Console.WriteLine("Bitte geben sie die anzahl Kanäle:");
                                    Console.WriteLine("> Eingabe:");
                                    Console.WriteLine("------------------------------------");
                                    kanäle = short.Parse(Console.ReadLine());

                                    Console.Clear();
                                    Console.WriteLine("Bitte geben sie die Zeit (in sekunden!):");
                                    Console.WriteLine("> Eingabe:");
                                    Console.WriteLine("------------------------------------");
                                    zeitwav = int.Parse(Console.ReadLine());

                                    Xbit = ((auflösung * abtastrate * kanäle) * zeitwav);
                                    Xbyte = (Xbit / 8);
                                    Xmbyte = (Xbyte / 1000);
                                    Xgbyte = (Xmbyte / 1000);

                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("####################################");
                                    Console.WriteLine();
                                    //Bit
                                    Console.WriteLine("Bit:");
                                    Console.WriteLine(Xbit);
                                    Console.WriteLine("------------------------------------");
                                    Console.WriteLine();
                                    //Byte
                                    Console.WriteLine("Bit:");
                                    Console.WriteLine(Xbyte);
                                    Console.WriteLine("------------------------------------");
                                    Console.WriteLine();
                                    //MB
                                    Console.WriteLine("Bit:");
                                    Console.WriteLine(Xmbyte);
                                    Console.WriteLine("------------------------------------");
                                    Console.WriteLine();
                                    //GB
                                    Console.WriteLine("Bit:");
                                    Console.WriteLine(Xgbyte);
                                    Console.WriteLine("####################################");
                                    Console.WriteLine();

                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                case 2:



                                    Console.WriteLine
                                    (FiggleFonts.Slant.Render("MP3 Sounddaten Speicherrechner"));

                                    Console.Title = "BFTMultiTool | INFORMATIK | MP3 Sounddaten speicherrechner";

                                    Console.WriteLine("Bitte geben sie die Zeit (in sekunden!):");
                                    Console.WriteLine("> Eingabe:");
                                    Console.WriteLine("------------------------------------");
                                    zeitwav = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Bitte geben sie die Übertragungsrate:");
                                    Console.WriteLine("> Eingabe:");
                                    Console.WriteLine("------------------------------------");
                                    übertragungsrate = int.Parse(Console.ReadLine());

                                    Xbit = (zeitwav * übertragungsrate);
                                    Xbyte = (Xbit / 8);
                                    Xmbyte = (Xbyte / 1000);
                                    Xgbyte = (Xmbyte / 1000);

                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("####################################");
                                    Console.WriteLine();
                                    //Bit
                                    Console.WriteLine("Bit:");
                                    Console.WriteLine(Xbit);
                                    Console.WriteLine("------------------------------------");
                                    Console.WriteLine();
                                    //Byte
                                    Console.WriteLine("Bit:");
                                    Console.WriteLine(Xbyte);
                                    Console.WriteLine("------------------------------------");
                                    Console.WriteLine();
                                    //MB
                                    Console.WriteLine("Bit:");
                                    Console.WriteLine(Xmbyte);
                                    Console.WriteLine("------------------------------------");
                                    Console.WriteLine();
                                    //GB
                                    Console.WriteLine("Bit:");
                                    Console.WriteLine(Xgbyte);
                                    Console.WriteLine("####################################");
                                    Console.WriteLine();

                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                case 3:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    return;
                                    //zurück ins Submenü

                            }

                            break;

                        case 2:

                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.Clear();

                            Console.WriteLine
                                (FiggleFonts.Slant.Render(" Video Speicherrechner"));

                            Console.Title = "BFTMultiTool | INFORMATIK | Video speicherrechner";

                            Console.WriteLine("- Video-Dateien Rechner -");
                            //Code für den video-Dateien Rechner 

                            Console.WriteLine("Wählen Sie eine Option aus");
                            Console.WriteLine("[1] Video Dateien Rechner");
                            Console.WriteLine("[2] <- Zurück zum Submenü");
                            Console.WriteLine("> Eingabe:");


                            www = int.Parse(Console.ReadLine());

                            switch (www)
                            {

                                case 1:
                                    int pxB = 0;
                                    int pxH = 0;
                                    int datentiefe = 0;
                                    int fps = 0;

                                    int Ybit = 0;
                                    int Ybyte = 0;
                                    int Ymbyte = 0;
                                    int Ygbyte = 0;
                                    int Ytbyte = 0;


                                    Console.WriteLine("Bitte geben sie die pixelbreite:");
                                    Console.WriteLine("> Eingabe:");
                                    Console.WriteLine("------------------------------------");
                                    pxB = int.Parse(Console.ReadLine());

                                    Console.Clear();
                                    Console.WriteLine("Bitte geben sie die pixelbreite:");
                                    Console.WriteLine("> Eingabe:");
                                    Console.WriteLine("------------------------------------");
                                    pxH = int.Parse(Console.ReadLine());

                                    Console.Clear();
                                    Console.WriteLine("Bitte geben sie die pixelbreite:");
                                    Console.WriteLine("> Eingabe:");
                                    Console.WriteLine("------------------------------------");
                                    datentiefe = int.Parse(Console.ReadLine());

                                    Console.Clear();
                                    Console.WriteLine("Bitte geben sie die pixelbreite:");
                                    Console.WriteLine("> Eingabe:");
                                    Console.WriteLine("------------------------------------");
                                    fps = int.Parse(Console.ReadLine());


                                    Ybit = ((pxB * pxH) * datentiefe * fps);
                                    Ybyte = (Ybit / 8);
                                    Ymbyte = (Ybyte / 1000);
                                    Ygbyte = (Ymbyte / 1000);
                                    Ytbyte = (Ymbyte / 1000);

                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("####################################");
                                    Console.WriteLine();
                                    //Bit
                                    Console.WriteLine("Bit:");
                                    Console.WriteLine(Ybit);
                                    Console.WriteLine("------------------------------------");
                                    Console.WriteLine();
                                    //Byte
                                    Console.WriteLine("Byte:");
                                    Console.WriteLine(Ybyte);
                                    Console.WriteLine("------------------------------------");
                                    Console.WriteLine();
                                    //MB
                                    Console.WriteLine("MegaByte:");
                                    Console.WriteLine(Ymbyte);
                                    Console.WriteLine("------------------------------------");
                                    Console.WriteLine();
                                    //GB
                                    Console.WriteLine("GigaByte:");
                                    Console.WriteLine(Ygbyte);
                                    Console.WriteLine("------------------------------------");
                                    Console.WriteLine();
                                    //TB
                                    Console.WriteLine("TeraByte:");
                                    Console.WriteLine(Ytbyte);
                                    Console.WriteLine("####################################");
                                    Console.WriteLine();


                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                case 2:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    return;
                                //zurück ins IT sub menü

                                default:
                                    Console.WriteLine("Fehler: Ungültige Eingabe! Bitte geben Sie eine Zahl zwischen 1 und 4 ein.(du wirst zurück gesendet!)");
                                    return;
                                    //neue eingabe

                            }
                            break;

                        case 3:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            return;
                        //zurück ins IT sub menü

                        case 4:
                            Exit = true;
                            break;

                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Fehler: Ungültige Eingabe! Bitte geben Sie eine Zahl zwischen 1 und 4 ein.");
                }
            }
        }

    }
}
