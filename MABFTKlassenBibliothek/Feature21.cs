using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MABFTKlassenBibliothek
{
    class Feature21
    {
        public static void Polynom()
        {
            int wrongAttempts = 0;
            string menu;
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Polynom <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
            while (true)
            {


                Console.WriteLine("1. Programm starten");
                Console.WriteLine("2. Zurück zum Mathemenü");
                Console.Write("> ");
                #pragma warning disable CS8602
                menu = Console.ReadLine();

                if (menu == "1")
                {
                    Console.Clear();

                    // Deklaration und Initialisierung von Variablen
                    string[] coefficients;
                    double[] polynomialCoefficients;
                    bool validInput = false;

                    do // Eine Schleife, die solange ausgeführt wird, bis der Benutzer eine gültige Eingabe gemacht hat
                    {
                        Console.WriteLine("Geben Sie die Koeffizienten des Polynoms in aufsteigender Reihenfolge des Grades an, separiert durch Leerzeichen:");
                        Thread.Sleep(1000);
                        Console.WriteLine("Beispiel Aufgabe: -1 5 -2 3*sqrt(4)");
                        coefficients = Console.ReadLine().Split(); // Eingabe des Benutzers wird gelesen und in einzelnen Strings aufgeteilt
                        polynomialCoefficients = new double[coefficients.Length];// Array für Koeffizienten werden erstellen
                        validInput = true;

                        for (int i = 0; i < coefficients.Length; i++)  // Eine Schleife, die jedes Element des Eingabearrays durchläuft
                        {
                            if (coefficients[i].Contains("sqrt"))
                            {
                                int sqrtStartIndex = coefficients[i].IndexOf("sqrt(") + 5;  // Ermittelt den Startindex der Zahl innerhalb der Klammern
                                int sqrtLength = coefficients[i].Length - sqrtStartIndex - 1; // Ermittelt die Länge der Zahl innerhalb der Klammern
                                double sqrtValue;

                                if (!double.TryParse(coefficients[i].Substring(sqrtStartIndex, sqrtLength), out sqrtValue)) // Überprüft, ob der Wert in der Wurzel ein gültiger numerischer Wert ist
                                {
                                    Console.WriteLine("Ungültige Eingabe: Bitte geben Sie nur Zahlen ein.");
                                    validInput = false;
                                    break;
                                }
                                else
                                {
                                    polynomialCoefficients[i] = Math.Sqrt(sqrtValue);  // Berechnen des Wurzelwertes und Speichern in einem Array
                                }
                            }
                            else if (!double.TryParse(coefficients[i], out polynomialCoefficients[i])) // Überprüft, ob das Element eine gültige Zahl ist
                            {
                                Console.WriteLine("Ungültige Eingabe: Bitte geben Sie nur Zahlen ein.");
                                validInput = false;
                                break;
                            }
                        }
                    } while (!validInput);
                    // Variable für Eingabe des Benutzers deklarieren
                    double x;

                    Console.WriteLine("Geben Sie den Wert von x ein:");
                    Thread.Sleep(1000);
                    Console.WriteLine("Beispiel Aufgabe: 2.5");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "exit")
                    {
                        Environment.Exit(0);
                    }
                    while (!double.TryParse(input, out x)) // Solange der Benutzer keine gültige Zahl eingegeben hat, wird weiterhin die Eingabeaufforderung angezeigt
                    {
                        Console.WriteLine("Fehler: Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                        wrongAttempts++;
                        if (wrongAttempts == 18)
                        {
                            Console.WriteLine("Wenn du nochmal eine falsche Eingabe machst, explodiert dein Computer!");
                        }
                        else if (wrongAttempts == 19)
                        {
                            Console.WriteLine("Ich habe dir gesagt, dass dein Computer explodiert, wenn du nochmal eine falsche Eingabe machst! Du wurdest gewarnt...");
                        }
                        else if (wrongAttempts == 20)
                        {
                            Console.WriteLine("Tut mir leid, aber jetzt ist es zu spät. Dein Computer wird in \n3...");
                            Thread.Sleep(1000);
                            Console.WriteLine("2...");
                            Thread.Sleep(1000);
                            Console.WriteLine("1...");
                            Thread.Sleep(1000);
                            Console.WriteLine("BOOM!");

                            Environment.Exit(0);
                        }
                        else if (wrongAttempts >= 10 && wrongAttempts % 2 == 0)
                        {
                            Console.WriteLine("Hey, du scheinst Schwierigkeiten zu haben. Brauchst du Hilfe?");
                            string abfrage_hilfe = Console.ReadLine();
                            if (abfrage_hilfe.Contains("ja"))
                            {
                                Console.WriteLine("Also... Wenn ich dir ehrlich bin, kann dir nur noch Gott helfen oder wenn du wen Menschliches brauchst, dann kann dir vielleicht aber auch nur vielleicht ein Therapeut weiterhelfen...");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Okaayyy! Lezzzzz gooooooo");
                                Thread.Sleep(1000);
                                Console.ReadLine();
                            }
                        }
                    }
                    Console.Clear();
                    DrawPolynomialGraph(polynomialCoefficients, x);
                    Console.WriteLine("\nBitte drücken sie die ENTER-Taste!");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (menu == "2")
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\nSie werden nun zum Mathemenü geleitet!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    return;
                }

                else if (menu.ToLower() == "exit")
                {
                    Console.Clear();
                    Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("Ungültige Eingabe: Bitte geben Sie entweder '1' oder '2' ein!");
                    Console.WriteLine("\nBitte drücken sie irgendeine Taste, um zurück ins Polynomen-Menü zu gelangen!");
                    if (menu.ToLower() == "exit")
                    {
                        Environment.Exit(0);
                    }
                    if (menu == "iamlost")
                    {
                        if (wrongAttempts <= 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Herzlichen Glückwunsch, du hast einen geheimen Command gefunden, welcher zeigt, wie viele Fehlversuche du schon hier im Programm hattest :D");
                            Console.WriteLine("Möchtest du sehen, wie viele Fehlversuche du hattest? (y=yes/n=no)");
                            string fehlversuche = Console.ReadLine();
                            if (fehlversuche.ToLower() == "y")
                            {
                                Console.WriteLine($"\nDu hast {0} Fehlversuche im Programm gehabt! :)\n", wrongAttempts);
                                Thread.Sleep(1000);
                                Console.WriteLine("Bitte drücken sie die ENTER-Taste!");

                            }
                            else if (fehlversuche.ToLower() == "n")
                            {
                                Console.WriteLine("\nOkay, kein Problem.\n");
                                Console.WriteLine("Bitte drücken sie die ENTER-Taste!");

                            }

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Meine Augen bluten, wenn ich so sehe, wie oft du schon versucht hast, hier im Programm was richtig einzugeben...");
                            Thread.Sleep(4000);
                            Console.WriteLine("Achso und du hast " + wrongAttempts + " mal versucht was richtiges einzugeben...");
                            Console.WriteLine("\nBitte drücken sie die ENTER-Taste!");
                        }
                    }
                    else if (menu == "resetiamlost")
                    {
                        if (wrongAttempts > 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Punkte wurden zurückgesetzt!\n");
                            Console.ResetColor();
                            wrongAttempts = 0;
                            Console.WriteLine("Bitte drücken sie die ENTER-Taste!");
                        }
                        else if (wrongAttempts < 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Du hast bis jetzt keinen einzigen Fehlversuch gehabt! ");
                            Thread.Sleep(1000);
                            Console.WriteLine("\nBitte drücken sie die ENTER-Taste!");
                        }
                    }
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }

            static double CalculatePolynomialValue(double[] coefficients, double x)
            {
                double result = 0;
                for (int i = 0; i < coefficients.Length; i++) // Es wird solange inkrementiert, bis es den Wert coefficients.Length-1 erreicht hat
                {
                    double termValue = Math.Pow(x, i) * coefficients[i]; // Berechnet den Wert des Terms für den aktuellen Koeffizienten und x
                    result += termValue;// Addiert den berechneten Wert zum Gesamtergebnis
                }
                return result;  // Gibt das Gesamtergebnis zurück
            }

            static void DrawPolynomialGraph(double[] coefficients, double x)
            {
                // Bestimmt die Breite und Höhe des Konsolenfensters
                int width = Console.WindowWidth - 1;
                int height = Console.WindowHeight - 1;

                char[,] graph = new char[width, height]; //  Erstellt in der Konsole mit der Breite und Höhe des Konsolenfensters, um den Graphen darin zu zeichnen.

                for (int i = 0; i < width; i++) // Setzt alle Einträge der Konsole auf Leerzeichen, um sie zu löschen
                {
                    for (int j = 0; j < height; j++)
                    {
                        graph[i, j] = ' ';
                    }
                }

                //(Orientierung) Zeichnung der X und Y-Achse
                int xAxisPos = (int)Math.Round(height / 2.0);
                int yAxisPos = (int)Math.Round(width / 2.0);

                for (int i = 0; i < width; i++) // Zeichnet die X-Achse mit '-' Symbolen in die Konsole ein
                {
                    graph[i, xAxisPos] = '-';
                }

                for (int i = 0; i < height; i++) // Zeichnet die Y-Achse mit '|' Symbolen in die Konsole ein
                {
                    graph[yAxisPos, i] = '|';
                }

                // Bestimmt den maximalen und minimalen Funktionswert
                double minValue = double.MaxValue;
                double maxValue = double.MinValue;

                for (int i = -yAxisPos; i < width - yAxisPos; i++) // Durchläuft alle X-Werte im Bereich der Breite des Konsolenfensters und berechnet die Y-Werte des Polynoms an diesen X-Werten.
                {
                    double y = CalculatePolynomialValue(coefficients, i + x);
                    if (y < minValue)  // Aktualisiert den minimalen und maximalen y-Wert, die auf der Konsole dargestellt werden.
                    {
                        minValue = y;
                    }
                    if (y > maxValue)
                    {
                        maxValue = y;
                    }
                }
                // Bestimmt den Skalierungsfaktoren, um den Funktionsverlauf auf die Höhe des Konsolenfensters anzupassen
                double valueRange = maxValue - minValue;
                double heightPerUnit = height / valueRange;

                for (int i = -yAxisPos; i < width - yAxisPos; i++)
                {
                    double y = CalculatePolynomialValue(coefficients, i + x);
                    int yPos = xAxisPos - (int)Math.Round(y * heightPerUnit);

                    if (yPos >= 0 && yPos < height)  // Prüft ob die Y-Position innerhalb des Konsolenfensters liegt
                    {
                        graph[i + yAxisPos, yPos] = '*';
                    }
                }

                Console.WriteLine();
                for (int i = 0; i < height; i++) // Ausgabe des Graphen-Zeichnungsarrays in der Konsole
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write(graph[j, i]); // Gib das Zeichen an den Koordinaten (j, i) des Graphenarrays aus
                    }
                    Console.WriteLine(); // Geht zur nächsten Zeile
                }
            }
        }
    }
}