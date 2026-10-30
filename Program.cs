using System;

Console.WriteLine("Wähle einen Modus:");
Console.WriteLine("1. Zahlenraten");
Console.WriteLine("2. Richtig oder Falsch");
Console.Write("Deine Wahl: ");

string? auswahl = Console.ReadLine();

if (auswahl == "1")
{
    Random zufall = new Random();
    int geheimzahl = zufall.Next(1, 101);
    int versuche = 0;
    int tipp = 0;

    Console.WriteLine("\nIch denke an eine Zahl zwischen 1 und 100.");

    while (tipp != geheimzahl)
    {
        Console.Write("Dein Tipp: ");

        if (!int.TryParse(Console.ReadLine(), out tipp))
        {
            Console.WriteLine("Bitte gib eine gültige ganze Zahl ein.");
            continue;
        }

        versuche++;

        if (tipp < geheimzahl)
            Console.WriteLine("Die gesuchte Zahl ist größer.");
        else if (tipp > geheimzahl)
            Console.WriteLine("Die gesuchte Zahl ist kleiner.");
        else
            Console.WriteLine($"Richtig! Du hast {versuche} Versuche gebraucht.");
    }
}
else if (auswahl == "2")
{
    string[] fragen =
    {
        "Die Erde kreist um die Sonne.",
        "Eine Woche hat acht Tage.",
        "Wasser besteht aus Wasserstoff und Sauerstoff."
    };

    bool[] antworten =
    {
        true,
        false,
        true
    };

    int punkte = 0;

    Console.WriteLine("\nAntworte mit wahr oder falsch.");

    for (int i = 0; i < fragen.Length; i++)
    {
        Console.WriteLine($"\n{fragen[i]}");
        Console.Write("Deine Antwort: ");
        string? eingabe = Console.ReadLine()?.Trim().ToLower();

        bool antwortIstGueltig = eingabe == "wahr" || eingabe == "w" ||
                                 eingabe == "falsch" || eingabe == "f";

        if (!antwortIstGueltig)
        {
            Console.WriteLine("Ungültige Eingabe. Diese Frage zählt nicht als Punkt.");
            continue;
        }

        bool antwort = eingabe == "wahr" || eingabe == "w";

        if (antwort == antworten[i])
        {
            Console.WriteLine("Richtig!");
            punkte++;
        }
        else
        {
            Console.WriteLine("Leider falsch.");
        }
    }

    Console.WriteLine($"\nErgebnis: {punkte} von {fragen.Length} Punkten.");
}
else
{
    Console.WriteLine("Ungültige Auswahl.");
}
