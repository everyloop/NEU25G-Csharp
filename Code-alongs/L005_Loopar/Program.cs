
// WHILE-loop körs så länge den utvärderas till true, 0 eller fler gånger:

//string name = string.Empty;

//while (name != "fredrik")
//{
//    Console.Write("Gissa ditt namn: ");
//    name = Console.ReadLine();
//}

//Console.WriteLine("Yes, du gissade rätt!");



// DO-WHILE-loop kör så länge den utvärderas till true, men alltid minst en gång.

//string name = string.Empty;
//do
//{
//    Console.Write("Gissa ditt namn: ");
//    name = Console.ReadLine();
//} while (name != "fredrik");

//Console.WriteLine("Yes, du gissade rätt!");


Console.WriteLine("\nExempel som använder WHILE som räknare 1 till 5");

int j = 1;

while (j <= 5)
{
    Console.WriteLine(j);
    j++;  // samma som j += 1 eller j = j + 1
}


Console.WriteLine("\nExempel med for-loop som räknar 1 till 5");

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}


Console.WriteLine("\nExempel med BREAK");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
    if (i == 5)
    {
        break; // Avbryter loopen helt, och fortsätter exekvering efter loopen.
    }
}


Console.WriteLine("\nExempel med CONTINUE");

for (int i = 1; i <= 10; i++)
{
    if (i == 5 || i == 8)
    {
        continue; // Avbryter pågående iteration, och fortsätter på nästa "varv" i loopen
    }
    Console.WriteLine(i);
}


