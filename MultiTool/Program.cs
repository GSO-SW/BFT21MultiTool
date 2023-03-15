using System;


string binäreZahl = "";
bool incorrectInput = false;
int sum = 0;
int stellenwert = 1;


while (!incorrectInput)
{
    Console.Write("Geben Sie Bitte eine Binärzahl ein:    ");
    binäreZahl = Console.ReadLine();
    incorrectInput = true;


    for (int i = binäreZahl.Length - 1; i >= 0; i--)
    {
        if (binäreZahl[i] != '0' && binäreZahl[i] != '1')
        {
            Console.WriteLine(binäreZahl + "ist keine gültige Binärzahl!");
            incorrectInput = false;
            break;
        }
        else
        {
            sum = sum + binäreZahl[i] * stellenwert;
            stellenwert = stellenwert * 2;
        }
    }
}
Console.WriteLine(binäreZahl + " ist eine gültige Binärzahl!");
Console.WriteLine(stellenwert);