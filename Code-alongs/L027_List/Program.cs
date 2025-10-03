

using System.Collections.Specialized;

var countries = new List<string>() { "Sweden", "Denmark", "Norway" };

// Remove all elements
// countries.Clear();

countries.Add("Finland");
countries.Add("Germany");

//countries.Remove("Norway");
//countries.RemoveAt(2);
//countries.RemoveRange(1, 3);

Console.WriteLine($"Number of countries in list: {countries.Count}\n");

countries.Sort();

foreach (var country in countries)
{
    Console.WriteLine(country);
}

var myCountry = "Sweden";
Console.WriteLine($"\ncountries.Contains(\"{myCountry}\") => {countries.Contains(myCountry)}");


Console.WriteLine();

var numbers = new List<int>();

//numbers.Capacity = 40;

for (int i = 0; i < 40; i++)
{
    Console.WriteLine($"numbers.Count => {numbers.Count}, numbers.Capacity => {numbers.Capacity}");
    numbers.Add(234);
}

//numbers.Capacity = numbers.Count;
numbers.TrimExcess();

Console.WriteLine();
Console.WriteLine($"numbers.Count => {numbers.Count}, numbers.Capacity => {numbers.Capacity}");
numbers.Add(234);
Console.WriteLine($"numbers.Count => {numbers.Count}, numbers.Capacity => {numbers.Capacity}");

var myArray = new int[50];
Array.Resize(ref myArray, 25);

Console.WriteLine();