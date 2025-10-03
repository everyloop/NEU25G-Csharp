
var myDictionary = new Dictionary<string, string>();

myDictionary.Add("boy", "pojke");
myDictionary.Add("girl", "flicka");
myDictionary.Add("man", "man");
myDictionary.Add("woman", "kvinna");

Console.WriteLine("Keys:");

foreach (string key in myDictionary.Keys)
{
    Console.WriteLine(key);
}

Console.WriteLine("\nValues:");

foreach (string value in myDictionary.Values)
{
    Console.WriteLine(value);
}

Console.WriteLine("\nKeys with values:");

foreach (KeyValuePair<string, string> keyValuePair in myDictionary)
{
    Console.WriteLine($"The key {keyValuePair.Key} holds the value {keyValuePair.Value}");
}

Console.WriteLine();
Console.WriteLine($"myDictionary[\"girl\"] => {myDictionary["girl"]}");

// Om nyckeln saknas kastas en KeyNotFoundException
// Console.WriteLine($"myDictionary[\"tree\"] => {myDictionary["tree"]}");


string input;

do
{
    input = Console.ReadLine();

    if (myDictionary.ContainsKey(input))
    {
        Console.WriteLine(myDictionary[input]);
    }
    else
    {
        Console.WriteLine("Nyckeln saknas.");
    }
} while (input != string.Empty);