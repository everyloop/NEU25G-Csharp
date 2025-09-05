
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


// Exempel som använder WHILE som räknare 1 till 10.
//int i = 1;

//while (i <= 10)
//{
//    Console.WriteLine(i);
//    i++;  // samma som i += 1 eller i = i + 1
//}

// Exempel med for-loop som räknar 1 till 5
//Console.WriteLine("Start");

//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("End");


// Exempel med BREAK
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//    if (i == 5)
//    {
//        break;
//    }
//}


// Exempel med CONTINUE
for (int i = 1; i <= 10; i++)
{
    if (i == 5 || i == 8)
    {
        continue;
    }
    Console.WriteLine(i);
}
Console.WriteLine("Slut!");

