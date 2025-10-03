
var countries = new List<string>() { "Sweden", "Denmark", "Norway" };

// Ta bort alla objekt på listan:
// countries.Clear();

// Lägg till ett objekt på listan:
countries.Add("Finland");
countries.Add("Germany");

// Tar bort ett specifikt objekt:
//countries.Remove("Norway");

// Tar bort ett objekt på angivet index:
//countries.RemoveAt(2);

// Tar bort 3 objekt från index 1 och framåt:
//countries.RemoveRange(1, 3);

Console.WriteLine($"Number of countries in list: {countries.Count}\n");

// Sorterar listan, förutsatt att datatypen tillåter det.
// countries.Sort();

foreach (var country in countries)
{
    Console.WriteLine(country);
}

var myCountry = "Sweden";
Console.WriteLine($"\ncountries.Contains(\"{myCountry}\") => {countries.Contains(myCountry)}");


Console.WriteLine();

// Internt så lagrar List<T> alla items i en array.

var numbers = new List<int>();

// Storleken på arrayen kan sättas, och läsas av med propertyn Capacity.

// Om man lägger till (Add) objekt när den interna arrayen inte är tillräckligt stor så dubblas capacity.
// ... det innebär att den skapar en ny, större, array och kopierar över befintliga värden.

// Om man vet med sig att man ska lägga in många objekt med en gång kan man sätta Capacity i förväg
// för att undvika onödiga om allokeringar av minne och förflyttning av data.
//numbers.Capacity = 40;

for (int i = 0; i < 40; i++)
{
    Console.WriteLine($"numbers.Count => {numbers.Count}, numbers.Capacity => {numbers.Capacity}");
    numbers.Add(234);
}

// Man kan även i efterhand trimma ner storleken på arrayen så inte överflödiga minnesplatser allokeras i onödan.
//numbers.TrimExcess();

// TrimExess() är i princip samma sak som:
//numbers.Capacity = numbers.Count;

Console.WriteLine();
Console.WriteLine($"numbers.Count => {numbers.Count}, numbers.Capacity => {numbers.Capacity}");
numbers.Add(234);
Console.WriteLine($"numbers.Count => {numbers.Count}, numbers.Capacity => {numbers.Capacity}");


// I bakgrunden används Array.Resize.
var myArray = new int[50];
Array.Resize(ref myArray, 25);

Console.WriteLine();