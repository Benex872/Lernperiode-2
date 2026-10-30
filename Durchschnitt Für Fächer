using System;
using System.Collections.Generic;
using System.Globalization;

Dictionary<string, List<double>> faecher = new Dictionary<string, List<double>>();

Console.WriteLine("Notendurchschnitt für mehrere Fächer");
Console.WriteLine("Lass den Fachnamen leer, um das Programm zu beenden.");

while (true)
{
    Console.Write("\nFachname: ");
    string fach = Console.ReadLine()?.Trim() ?? "";

    if (fach == "")
        break;

    List<double> noten = new List<double>();

    Console.WriteLine($"Gib die Noten für {fach} ein. Schreibe 'fertig', wenn du fertig bist.");

    while (true)
    {
        Console.Write("Note: ");
        string? eingabe = Console.ReadLine()?.Trim();

        if (eingabe?.ToLower() == "fertig")
            break;

        if (double.TryParse(eingabe, NumberStyles.Float,
                CultureInfo.CurrentCulture, out double note) ||
            double.TryParse(eingabe?.Replace(',', '.'),
                NumberStyles.Float, CultureInfo.InvariantCulture, out note))
        {
            if (note >= 1 && note <= 6)
                noten.Add(note);
            else
                Console.WriteLine("Die Note muss zwischen 1 und 6 liegen.");
        }
        else
        {
            Console.WriteLine("Bitte gib eine gültige Note ein.");
        }
    }

    if (noten.Count > 0)
        faecher[fach] = noten;
    else
        Console.WriteLine($"Für {fach} wurden keine Noten gespeichert.");
}

if (faecher.Count == 0)
{
    Console.WriteLine("\nEs wurden keine Fächer mit Noten eingegeben.");
}
else
{
    double summeAllerDurchschnitte = 0;
    int anzahlFaecher = 0;

    Console.WriteLine("\nDurchschnitte pro Fach:");

    foreach (var fachEintrag in faecher)
    {
        double summe = 0;

        foreach (double note in fachEintrag.Value)
            summe += note;

        double durchschnitt = summe / fachEintrag.Value.Count;

        Console.WriteLine($"{fachEintrag.Key}: {durchschnitt:F2}");
        summeAllerDurchschnitte += durchschnitt;
        anzahlFaecher++;
    }

    Console.WriteLine($"Durchschnitt über alle Fächer: {summeAllerDurchschnitte / anzahlFaecher:F2}");
}
