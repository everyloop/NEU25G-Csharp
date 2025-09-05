
// Strängar går att indexera. De fungerar i princip som en read-only array av Char.
var text = "Hello world!"; //.ToCharArray();

// Få ut längden på myString som ett heltal.
Console.WriteLine(text.Length);

Console.WriteLine("\nLoopa igenom bokstav för bokstav med hjälp av index:");

for (int i = 0; i < text.Length; i++)
{
    // text[i] = 'x';      // strängar är read-only 
    Console.Write(text[i]);
    if (i < 4)
    {
        Console.Write("-");
    }
}

Console.WriteLine("\n\nLoopa igenom bokstav för bokstav med foreach:");
foreach (char letter in text)
{
    Console.WriteLine(letter);
}

Console.WriteLine("\n*************\n");

// Standard string literal
Console.WriteLine("Hello \"world\" - \\n");

// Escape sequences - backslash (\) följt av vissa andra tecken har specifika betydelser
// '\n' - new line
// '\t' - tab
// '\"' - double qoute (")
// '\\' - backslash (\)

Console.WriteLine();

// Verbatim string literal, startar med @ före ""
string path = @"C:\Users\Fredrik\Desktop";
Console.WriteLine(path);
Console.WriteLine(@"Hello ""world"".");

// Interpolation strings, startar med $ före ""
Console.WriteLine($"Hello {5+5} world");

string name = "Fredik";

Console.WriteLine("Hej " + name + "!");
Console.WriteLine($"Hej {name} {name}sson! - {3+4} - {name.ToUpper()}");
