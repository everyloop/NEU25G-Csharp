using System.Xml;

Console.Write("Enter your name: ");
string name = Console.ReadLine();

if (name == "fredrik")
{ 
    Console.WriteLine("Du heter Fredrik");
} 
else if (name == "kalle")
{
    Console.WriteLine("Du heter Kalle");
}
else if (name == "anders")
{
    Console.WriteLine("Du heter Anders");
}
else
{
    Console.WriteLine("Du heter varken Fredrik, Anders eller Kalle");
}

Console.WriteLine("Slut");

Console.WriteLine();

switch (name)
{
    case "Fredrik":
        Console.WriteLine("Du heter Fredrik");
        break;
    case "Anders":
        Console.WriteLine("Du heter Anders");
        break;
    case "Kalle":
        Console.WriteLine("Du heter Kalle");
        break;
    default:
        Console.WriteLine("Du heter varken Fredrik, Anders eller Kalle");
        break;
}

Console.WriteLine("\nTernery operator:");

// string lastName = (name == "fredrik" ? "johansson" : "unknown");

string lastName;

if (name == "fredrik")
{
    lastName = "johansson";
}
else
{
    lastName = "unknown";
}

Console.WriteLine(lastName);

