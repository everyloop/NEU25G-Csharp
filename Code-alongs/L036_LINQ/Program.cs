

var objectList = new List<object>();

objectList.Add("Hello world!");
objectList.Add("This is a text");
objectList.Add(5.3);
objectList.Add("Hej på er");
objectList.Add(true);
objectList.Add(94);
objectList.Add('a');
objectList.Add("Bye!");

//var stringList = new List<string>();

//foreach (var o in objectList)
//{
//    if (o is string s) stringList.Add(s);
//}

Console.WriteLine("objectList:");
Console.WriteLine(string.Join('\n', objectList));

var stringList = objectList.OfType<string>().ToList();

Console.WriteLine("\n*** OfType - Filters the elements based on a specified type - E.g. OfType<string> ***");
Console.WriteLine("\nstringList:");
Console.WriteLine(string.Join('\n', stringList));

Console.WriteLine("\n*** Any, All ***\n");

Console.WriteLine($"stringList.Any() => {stringList.Any()}");
Console.WriteLine($"stringList.Any(s => s.Length == 4) => {stringList.Any(s => s.Length == 4)}");
Console.WriteLine($"stringList.All(s => s.Length >= 4) => {stringList.All(s => s.Length >= 4)}");
Console.WriteLine($"stringList.Any(s => s == \"Hej\") => {stringList.Any(s => s == "Hej")}");
Console.WriteLine($"stringList.Any(s => s.Contains(\"ye\")) => {stringList.Any(s => s.Contains("ye"))}");
Console.WriteLine($"stringList.Any(s => s.ToLower() == \"hej\") => {stringList.Any(s => s.ToLower() == "hej")}");
Console.WriteLine($"stringList.Any(s => s.Split(' ').Length == 3) => {stringList.Any(s => s.Split(' ').Length == 3)}");
Console.WriteLine($"stringList.All(s => s.StartsWith('B')) => {stringList.All(s => s.StartsWith('B'))}");

// List<Enemy> enemies = levelElements.OfType<Enemy>().ToList();
// if (enemies.Any(e => e.HP < 5) ...


Console.WriteLine("\n*** Where ***\n");

var filteredStrings = stringList.Where(s => s.Length <= 12).ToList();

Console.WriteLine("stringList.Where(s => s.Length <= 12) =>");
Console.WriteLine(string.Join('\n', filteredStrings));

//foreach (var enemy in enemies.Where(e => e.HP < 5))
//{
//    Console.WriteLine(enemy.Name);
//}

Console.WriteLine();

Console.WriteLine("\n*** Select ***\n");

var people = new[]
{
    new { FirstName = "Anders", LastName = "Svensson", Age = 34 },
    new { FirstName = "Adam", LastName = "Johansson", Age = 24 },
    new { FirstName = "Maria", LastName = "Andersson", Age = 42 },
    new { FirstName = "Karl", LastName = "Karlsson", Age = 19 },
    new { FirstName = "Tomas", LastName = "Johansson", Age = 21 },
    new { FirstName = "Sven", LastName = "Palm", Age = 21 },
    new { FirstName = "Fia", LastName = "Kvist", Age = 28 },
    new { FirstName = "Camilla", LastName = "Alm", Age = 37 },
};

var people2 = people
    .Where(p => p.Age < 30)
    .Select(p => new { 
        FullName = $"{p.FirstName} {p.LastName}", 
        //Age = p.Age, 
        FirstNameLength = p.FirstName.Length 
    })
    .Where(p => p.FirstNameLength == 4)
    .ToList();

Console.WriteLine();





