

var objectList = new List<object>();

objectList.Add("Hello world!");
objectList.Add("This is a text");
objectList.Add(5.3);
objectList.Add("Hej");
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


Console.WriteLine();

