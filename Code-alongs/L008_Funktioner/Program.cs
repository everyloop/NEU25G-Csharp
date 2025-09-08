

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

Console.WriteLine();
FunctionA();


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

Console.WriteLine();

static string GetMultipleChar(char a, int count)
{
    // return new string(a, count);
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result += a;
    }

    return result;
}

string resultat = GetMultipleChar('A', 5);
Console.WriteLine(resultat);

// Uppgift4: Skriv en funktion som tar två heltal 'multiple' och 'length'
// och returnerar en int[] med längden 'length' där varje element är multiplar av 'multiple'
// i tur och ording:
// Ex. GetMultiples(3, 5); => int[5] { 3, 6, 9, 12, 15 }
// Spara värdet som funktionen returnerar i en variabel, och skriv sedan ut alla värden på skärmen.

static int[] Multiplicera(int multiple, int length)
{
    int[] intArray = new int[length];

    for (int i = 0; i < length; i++)
    {
        intArray[i] = (i + 1) * multiple;
    }

    return intArray;
}

int[] myMultiples = Multiplicera(3, 5);

foreach (var m in myMultiples)
{
    Console.WriteLine(m);
}

Console.WriteLine();


// Keyword 'params' kan användas för att ta in ett okänt antal parametrar av samma datatyp.
// Man kan bara ha en params, och den måste vara sista parametern
static int AddMultipleNumbers(params int[] numbers)
{
    int result = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        result += numbers[i];
    }

    return result;
}

int[] myNumbers = new int[] { 1, 3, 7, 5 };

Console.WriteLine(AddMultipleNumbers(1, 3, 7, 5, 10, 100));

// Exempel på hur man kan använda string.Join() för att skriva ut alla element i en array.
Console.WriteLine(string.Join(", ", myNumbers));

Console.WriteLine();

int count = 3;

// Funktioner märkta med 'static' har inte åtkomst till objekt deklarerade utanför funktionen.
// Tillsvidare använd static på alla era funktioner, så ni får in tänket att funktioner fungerar
// isolerat/fristående från annan kod.

//static void ExampleWithStatic()
//{
//    Console.WriteLine(count); // <- count kan inte läsas här.
//}

void ExampleWithoutStatic()
{
    Console.WriteLine(count);
}

// ExampleWithStatic();
ExampleWithoutStatic();