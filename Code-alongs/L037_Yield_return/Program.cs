
foreach (var s in GetStrings())
{
    Console.WriteLine(s);
}


IEnumerable<string> GetStrings()
{
    yield return "First";
    yield return "Second";
    yield return "Third";
}