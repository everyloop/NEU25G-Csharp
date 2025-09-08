

static void FunctionA()
{
    Console.WriteLine("Start of FunctionA.");
    FunctionB();
    Console.WriteLine("End of FunctionA.");
}

static void FunctionB()
{
    Console.WriteLine("Start of FunctionB.");
    FunctionC();
    Console.WriteLine("End of FunctionB.");
}

static void FunctionC()
{
    Console.WriteLine("This is FunctionC.");
}

FunctionA();

Console.WriteLine();

// En funktion kan ta 0, 1 eller flera inparametrar.
// Parmetrar skrivs kommaseparerade i parantesen efter funktionsnamnet.
// Varje parameter har en datatyp (Datatypen anges alltså per parameter).

// En funktion signatur består av Namnet på funktionen följt parametrar i parantesen.
// Man kan ange att en parameter är "optional" genom att ge den ett default-värde i signaturen.
static void MyFunction(string text, int count = 1, int numberOfExclamationMarks = 3)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write(text);
        for (int j = 0; j < numberOfExclamationMarks; j++)
        {
            Console.Write("!");
        }
        Console.WriteLine();
    }
}

// Indata vid funktionsanrop kallas för argument.
// Argumenten måste matcha funktionens parametrar i antal och datatyper.
// Argument skickas tolkas normalt i samma ordning som parametrarna är angivga,
// men man kan också använda "named arguments" för att ange annan ordning, eller hoppa över vissa.
MyFunction("Min text", 3);
MyFunction("Lorem Ipsum", 5, 2);
MyFunction("Lorem Ipsum", numberOfExclamationMarks: 5);

//Console.Write("Skriv text: ");
//string text = Console.ReadLine();
//MyFunction(text, 10);

// Uppgift1: Skriv en funktion som tar två heltal in och skriver ut summan av dessa på skärmen.
// Uppgift2: Skriv en funktion som tar två heltal t.ex 2 & 4 och skriver ut en sträng "2 * 4 = 8"

static void Addition(int a, int b)
{
    Console.WriteLine(a + b);
}

static void Uppgift2(int x, int y)
{
    // int z = x * y;
    // Console.WriteLine(x + " * " + y + " = " + z);
    Console.WriteLine($"{x} * {y} = {x*y}");
}

Console.WriteLine();

Addition(3, 4);
Uppgift2(3, 4);

Addition(5, 3);

Console.WriteLine();

// En funktion kan returnera 0 eller 1 objekt.
// Man anger datatypen på objektet som returneras före funktionsnamnet.
// Alternativt använd "void" om funktionen inte returnerar ett värde.
// Koden (i funktionen) måste ALLTID returnera en matchande datatyp.
static string AddNumbers(int a, int b)
{
    if (a < 10)
    {
        return $"{a} + {b} = {a+b}";
    }
    else
    {
        return "Hello world!";
    }
}

string x = AddNumbers(13, 5);

Console.WriteLine(x);

Console.WriteLine(AddNumbers(3, 7));

// Uppgift3: Skriv en funktion som tar en char och en int
// och returnerar en string med tecknet upprepat x antal gånger.
// Skriv sedan ut resultat på skärmen.
// Ex. GetMultipleChars('A', 5);  => "AAAAA"

// Uppgift4: Skriv en funktion som tar två heltal 'multiple' och 'length'
// och returnerar en int[] med längden 'length' där varje element är multiplar av 'multiple'
// i tur och ording:
// Ex. GetMultiples(3, 5); => int[5] { 3, 6, 9, 12, 15 }
// Spara värdet som funktionen returnerar i en variabel, och skriv sedan ut alla värden på skärmen.