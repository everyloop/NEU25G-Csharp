
string[] cities = new string[] { "Stockholm", "Göteborg", "Malmö", "Västerås", "Uppsala", "Jönköping" };

//int numberOfCities = 10;
//cities = new string[numberOfCities];

cities[2] = "Borås";

Console.WriteLine(cities);
Console.WriteLine(cities[0]);
Console.WriteLine(cities[3]);

Console.WriteLine("\nArray length: " + cities.Length);

Console.WriteLine("\n\nUse a for-loop to print all element of an array:");

for (int i = 0; i < cities.Length; i++)
{
    cities[i] = "Alingsås";
    Console.WriteLine(cities[i]);
}

Console.WriteLine("\n\nUse a foreach-loop to print all element of an array:");

foreach (string city in cities)
{
    // city = "Alingsås";     // City är read-only. foreach-loopar kan inte uppdatera elemnt i en kollektion (array). 
    Console.WriteLine(city);
}

Console.WriteLine("\n\nUse foreach to print double numbers.");
int[] numbers = new int[] { 5, 58, 103, 281 };

foreach (int number in numbers)
{
    Console.WriteLine(number * 2);
}
