
using System;
using System.Globalization;
 
namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Taschenrechner ===");

            bool weitermachen = true;

            while (weitermachen)
            {
                // Erste Zahl einlesen
                double zahl1 = ZahlEinlesen("Erste Zahl: ");

                // Rechenart einlesen
                char rechenzeichen = RechenzeichenEinlesen();

                // Zweite Zahl einlesen
                double zahl2 = ZahlEinlesen("Zweite Zahl: ");

                // Rechnen
                double ergebnis = 0;
                bool gueltig = true;

                switch (rechenzeichen)
                {
                    case '+':
                        ergebnis = Addieren(zahl1, zahl2);
                        break;
                    case '-':
                        ergebnis = Subtrahieren(zahl1, zahl2);
                        break;
                    case '*':
                        ergebnis = Multiplizieren(zahl1, zahl2);
                        break;
                    case '/':
                        if (zahl2 == 0)
                        {
                            Console.WriteLine("Fehler: Durch 0 kann man nicht teilen!");
                            gueltig = false;
                        }
                        else
                        {
                            ergebnis = Dividieren(zahl1, zahl2);
                        }
                        break;
                }

                // Ergebnis ausgeben
                if (gueltig)
                {
                    Console.WriteLine($"Ergebnis: {zahl1} {rechenzeichen} {zahl2} = {ergebnis}");
                }

                // Nochmal rechnen?
                Console.Write("\nNochmal rechnen? (j/n): ");
                string antwort = Console.ReadLine();
                weitermachen = antwort != null && antwort.Trim().ToLower() == "j";
                Console.WriteLine();
            }

            Console.WriteLine("Tschüss!");
        }

        // ---------- Rechenmethoden ----------

        static double Addieren(double a, double b)
        {
            return a + b;
        }

        static double Subtrahieren(double a, double b)
        {
            return a - b;
        }

        static double Multiplizieren(double a, double b)
        {
            return a * b;
        }

        static double Dividieren(double a, double b)
        {
            return a / b;
        }

        // ---------- Eingabe-Methoden ----------

        // Fragt so lange nach, bis eine gültige Zahl eingegeben wurde.
        // Komma und Punkt werden beide als Dezimaltrennzeichen akzeptiert.
        static double ZahlEinlesen(string text)
        {
            while (true)
            {
                Console.Write(text);
                string eingabe = Console.ReadLine();

                if (eingabe != null)
                {
                    eingabe = eingabe.Trim().Replace(',', '.');

                    if (double.TryParse(eingabe, NumberStyles.Float, CultureInfo.InvariantCulture, out double zahl))
                    {
                        return zahl;
                    }
                }

                Console.WriteLine("Ungültige Eingabe! Bitte eine Zahl eingeben.");
            }
        }

        // Fragt so lange nach, bis +, -, * oder / eingegeben wurde.
        static char RechenzeichenEinlesen()
        {
            while (true)
            {
                Console.Write("Rechenart (+, -, *, /): ");
                string eingabe = Console.ReadLine();

                if (eingabe != null)
                {
                    eingabe = eingabe.Trim();

                    if (eingabe == "+" || eingabe == "-" || eingabe == "*" || eingabe == "/")
                    {
                        return eingabe[0];
                    }
                }

                Console.WriteLine("Ungültige Rechenart! Bitte +, -, * oder / eingeben.");
            }
        }
    }
}
