

MyDelegate myDelegate = CountWords;

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

ProcessArray(strings, CountWords);

Console.WriteLine();

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

