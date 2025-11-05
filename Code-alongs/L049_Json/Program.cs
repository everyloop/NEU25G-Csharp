using System.Text.Json;

var people = new Person[]
{
    new Person() { FirstName = "Anders", LastName = "Andersson", Age = 25 },
    new Person() { FirstName = "Kalle", LastName = "Svensson", Age = 28 },
    new Person() { FirstName = "Maria", LastName = "Andersson", Age = 24 },
};

string json = JsonSerializer.Serialize(people);

Console.WriteLine(json);

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}