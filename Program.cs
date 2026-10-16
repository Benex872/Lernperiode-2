Console.WriteLine("=====Zahlen-Guesser=====");
int randomNumber = new Random().Next(1, 101);
Console.WriteLine("Errate die Zahl zwischen 1 und 100:");
int userGuess;
do
{
        Console.WriteLine("Gib eine Zahl ein:");
   while(!int.TryParse(Console.ReadLine(), out userGuess)) 
    {
        Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl zwischen 1 und 100 ein:");
    }
    if (userGuess < randomNumber)
    {
        Console.WriteLine("Zu niedrig! Versuch es nochmal.");
    }
    else if (userGuess > randomNumber)
    {
        Console.WriteLine("Zu hoch! Versuch es nochmal.");
    }








}while (userGuess != randomNumber);