

// Variabler 7 - Summa och medelvärde
// Skriv ett program som upprepade gånger frågar användaren efter ett tal
// ända till man skriver något som inte är ett tal (t.ex bara trycker enter).
// Efter varje inmatning ska summan av alla tal som matats in skrivas ut,
// innan nästa inmatning efterfrågas. Innan programmet avslutas ska man även
// skriva ut medelvärde av de inmatade talen.

//double sum = 0;
//int count = 0;

//Console.Write("Skriv in ett tal: ");

//while (Int32.TryParse(Console.ReadLine(), out int input))
//{
//    sum += input;
//    count++;

//    Console.WriteLine(sum);
//    Console.Write("Skriv in ett tal: ");
//}

//Console.WriteLine($"Medelvärde: {sum / count}");


// Loopar 13 - Primtal
// Primtal är heltal större än 1 som inte går att jämnt dela med något annat heltal
// (förutom 1 eller talet själv, eftersom alla tal är delbara med sig själva och 1).
// De 5 första primtalen är 2, 3, 5, 7, 11. Skriv ett program som
// listar de första 20 primtalen.

// Tips: Modulus/Rest (%-operatorn) kan användas för att se om ett tal är jämnt delbart med ett annat.
// ... och även när man behöver göra varannan eller var tredje o.s.v av något i en loop.


// Indexering 8 - Fördröjd utskrift
// Skapa ett program som ber användaren att skriva in ett ord. Sedan ett till, och ett till i all evighet.
// Varje gång man skrivit in ett ord så ska programmet skriva ut det ord man skrev 10 inmatningar tidigare.
// Men om man inte skrivit in 10 ord än så kan den istället skriva just det: “Du har inte skrivit in 10 ord än.”

string[] words = new string[10];
int count = 0;

while (true)
{
    Console.Write("Skriv något: ");
    string input = Console.ReadLine();
    words[count%10] = input;

    if (count < 9)
    {
        Console.WriteLine("Du har inte skrivit 10 ord än.");
    }
    else if (count%10 == 9)
    {
        Console.WriteLine(words[0]);
    }
    else
    {
        Console.WriteLine(words[count%10 + 1]);
    }

    count++;
}




/*
string[] strings = new string[10];

for (int i = 0; i < 9; i++)
{
    Console.WriteLine("Skriv något: ");
    strings[i] = Console.ReadLine();
    Console.WriteLine("Du har inte skrivit 10 ord än.");
}

Console.WriteLine("Skriv något: ");
strings[9] = Console.ReadLine();

while(true)
{
    for (int i = 0; i < 10; i++)
    {
        foreach (var item in strings)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Skriv något: ");
        strings[i] = Console.ReadLine();
    }
}
*/












