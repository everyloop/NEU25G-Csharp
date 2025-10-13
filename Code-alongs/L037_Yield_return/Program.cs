
//foreach (var s in GetStrings())
//{
//    Console.WriteLine(s);
//}


//IEnumerable<string> GetStrings()
//{
//    yield return "First";
//    yield return "Second";
//    yield return "Third";
//}

// Skapar en lista med 1 miljard element i minnet, oavsett hur många den anropande koden egentligen använder.
IEnumerable<int> GenerateWithoutYield()
{
    var list = new List<int>();
    for (int i = 0; i < 1000_000_000; i++)
    {
        list.Add(i);
    }

    return list;
}

// Returnerar ett värde i taget allt eftersom den anropande koden efterfrågar dem.
IEnumerable<int> GenerateWithYield()
{
    for (int i = 0; i < 1000_000_000; i++)
    {
        yield return i;
    }
}

// Om denna koden istället skulle använda GenerateWithoutYield() så tas mycket onödiga resurser (CPU tid & minne) i anspråk.
foreach (var i  in GenerateWithYield().Skip(10).Take(5))
{
    Console.WriteLine(i);
}