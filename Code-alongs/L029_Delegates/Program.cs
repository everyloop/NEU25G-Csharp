

Func<string, int> myDelegate = CountWords;

Console.WriteLine(myDelegate.Invoke("Hello world"));

myDelegate = CountChars;

Console.WriteLine(myDelegate("Hello world"));

myDelegate = null;

Console.WriteLine(myDelegate?.Invoke("Hello world"));

if (myDelegate is not null)
{
    Console.WriteLine(myDelegate("Hello world"));
}

var strings = new string[] { "Hello world", "Good morning everyone", "Hej" };

Console.WriteLine("var strings = new string[] { \"Hello world\", \"Good morning everyone\", \"Hej\" };");

Console.WriteLine("\nProcessArray(strings, CountWords); =>");

ProcessArray(strings, CountWords);

Console.WriteLine("\nProcessArray(strings, CountChars); =>");

ProcessArray(strings, CountChars);

Console.WriteLine();
static void ProcessArray(string[] strings, MyDelegate myDelegate)
{
    foreach (var item in strings)
    {
        Console.WriteLine(myDelegate(item));
    }
}

static int CountChars(string text)
{
    return text.Length;
}

static int CountWords(string text)
{
    return text.Split(' ').Length;
}

// Multicast delegate

Console.WriteLine("Multicast delegate:\n");

MyOtherDelegate funcDelegate = FuncC;

funcDelegate += FuncB;
funcDelegate += FuncA;
funcDelegate += FuncB;
funcDelegate = FuncB;
funcDelegate += FuncC;

funcDelegate.Invoke("Hello");

Console.WriteLine();

funcDelegate.Invoke("Hej");

static void FuncA(string text)
{
    Console.WriteLine($"FuncA: {text}");
}
static void FuncB(string text)
{
    Console.WriteLine($"FuncB: {text}");
}
static void FuncC(string text)
{
    Console.WriteLine($"FuncC: {text}");
}


public delegate int MyDelegate(string s);

public delegate void MyOtherDelegate(string s);

public delegate TResult MyGenericDelegate<T, TResult>(T s);


// Använd generiska delegat (Func (returvärde), Action (inget returvärde) för att lösa följande uppgifter:
// Func<in T1, in T2, ..., out TResult>
// Action<in T1, in T2, ... >

// Uppgift 1:
// Skapa en funktion som tar två heltal in, plussar ihop dem, och skriver ut resultatet.
// Skapa ett generiskt delegat som pekar på metoden och använd detta för att anropa metoden.

// Uppgift 2:
// Skapa en funktion som tar en Char och en Int in, samt returnerar en String som innehåller
// bokstaven upprepad det antal gånger som man angett i heltalet. Använd ett generisk delegat
// för att anropa metoden. Skriv ut resultatet.

// Uppgift 3:
// Skriv en funktion som tar två heltal in, multiplicerar dem och skriver ut resultatet.
// Skriv sedan ytterligare en funktion som tar in ett heltal tillsammans med ett delegat till
// en metod som tar två heltal in. Om man skickar in t.ex 3 till denna metoden så ska den ha
// en loop i från 1 till 10, som varje gång anropar delegatmetoden med (3, i).
// Prova att anropa metoden dels med funktionen i uppgift 1, dels med funktionen som multiplicerar.




