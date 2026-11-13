Console.WriteLine("=====Altersrechner=====");
Console.WriteLine("In Welchem Jahr wurden Sie geboren");
double year = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("In welchem Jahr befinden wir uns gerade?");
double currentYear = Convert.ToDouble(Console.ReadLine());

 double age = currentYear - year;
Console.WriteLine("Sie sind " + age + " Jahre alt");
Console.ReadLine();
