using System;
using System.Globalization;

Console.WriteLine("Einfacher Mathe-Rechner");

if (!LiesZahl("Erste Zahl: ", out double zahl1) ||
    !LiesZahl("Zweite Zahl: ", out double zahl2))
{
    Console.WriteLine("Ungültige Zahl.");
    return;
}

Console.Write("Rechenzeichen (+, -, *, /): ");
string? zeichen = Console.ReadLine()?.Trim();

double ergebnis;

switch (zeichen)
{
    case "+":
        ergebnis = zahl1 + zahl2;
        break;

    case "-":
        ergebnis = zahl1 - zahl2;
        break;

    case "*":
        ergebnis = zahl1 * zahl2;
        break;

    case "/":
        if (zahl2 == 0)
        {
            Console.WriteLine("Division durch null ist nicht möglich.");
            return;
        }

        ergebnis = zahl1 / zahl2;
        break;

    default:
        Console.WriteLine("Unbekanntes Rechenzeichen.");
        return;
}

Console.WriteLine($"Ergebnis: {ergebnis}");

static bool LiesZahl(string aufforderung, out double zahl)
{
    Console.Write(aufforderung);
    string? eingabe = Console.ReadLine();

    return double.TryParse(eingabe, NumberStyles.Float,
               CultureInfo.CurrentCulture, out zahl) ||
           double.TryParse(eingabe?.Replace(',', '.'),
               NumberStyles.Float, CultureInfo.InvariantCulture, out zahl);
}
