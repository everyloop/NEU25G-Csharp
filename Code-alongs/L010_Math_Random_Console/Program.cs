
Console.WriteLine("*** Math ***\n");

Console.WriteLine($"Math.PI => {Math.PI}");
Console.WriteLine($"Math.E => {Math.E}\n");

// Absolutbelopp: Gör talet positivt.
Console.WriteLine($"Math.Abs(3) => {Math.Abs(3)}");
Console.WriteLine($"Math.Abs(-3) => {Math.Abs(-3)}\n");

// Avrundningsfunktioner
Console.WriteLine($"Math.Floor(2.731) => {Math.Floor(2.731)}");
Console.WriteLine($"Math.Ceiling(2.731) => {Math.Ceiling(2.731)}");
Console.WriteLine($"Math.Round(2.731) => {Math.Round(2.731)}");
Console.WriteLine($"Math.Truncate(2.731) => {Math.Truncate(2.731)}\n");

Console.WriteLine($"Math.Floor(-2.731) => {Math.Floor(-2.731)}");
Console.WriteLine($"Math.Truncate(-2.731) => {Math.Truncate(-2.731)}\n");

Console.WriteLine($"Math.Round(2.731, 1) => {Math.Round(2.731, 1)}");
Console.WriteLine($"Math.Round(2.731, 2) => {Math.Round(2.731, 2)}\n");

// Min, Max, Clamp
Console.WriteLine($"Math.Min(5, 12) => {Math.Min(5, 12)}");
Console.WriteLine($"Math.Max(5, 12) => {Math.Max(5, 12)}\n");

Console.WriteLine($"Math.Clamp(2, 5, 12) => {Math.Clamp(2, 5, 12)}");
Console.WriteLine($"Math.Clamp(7, 5, 12) => {Math.Clamp(7, 5, 12)}");
Console.WriteLine($"Math.Clamp(18, 5, 12) => {Math.Clamp(18, 5, 12)}\n");

int userInput = 103;
int clampedValue = Math.Clamp(userInput, 0, 100);

// Upphöjt & Kvadratroot
Console.WriteLine($"Math.Pow(10, 3) => {Math.Pow(10, 3)}");
Console.WriteLine($"Math.Sqrt(9) => {Math.Sqrt(9)}\n");

Console.WriteLine("*** Math ***\n");

Console.WriteLine($"int.MinValue => {int.MinValue}");
Console.WriteLine($"int.MaxValue => {int.MaxValue}\n");

Console.WriteLine("Random myRandom = new Random();");
Random myRandom = new Random();

Console.WriteLine($"myRandom.Next() => {myRandom.Next()}\n");

for (int i = 0; i < 20; i++)
{
   Console.WriteLine($"myRandom.Next() => {myRandom.Next(1, 7)}");
}

double range = 50.0;
double offset = -25;

Console.WriteLine($"\nmyRandom.NextDouble() => {myRandom.NextDouble() * range + offset}");




