
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


// Exempel med BREAK

//int i = 0;
//while (true)
//{
//    i++;  // samma som i -= 1 eller i = i - 1
//    Console.WriteLine(i);

//    if (i > 5) break; // break avslutar loopen helt
//}


// Exempel med CONTINUE

int i = 0;
while (i < 10)
{
    i++;  // samma som i -= 1 eller i = i - 1
    if (i == 5) continue; // continue avsluta pågående iteration (varv) och fortsätta på nästa varv.
    Console.WriteLine(i);

}

