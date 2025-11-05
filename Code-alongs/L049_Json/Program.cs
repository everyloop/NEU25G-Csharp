using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

//var people = new Person[]
//{
//    new Person( "Anders", "Andersson", 25),
//    new Person( "Kalle", "Svensson", 28),
//    new Person( "Maria", "Andersson", 24),
//};

////people[0].BestFriend = people[1];
////people[1].BestFriend = people[0];


//var options = new JsonSerializerOptions()
//{
//    WriteIndented = true,
//    //IncludeFields = true,
//    //IgnoreReadOnlyProperties = true,
//    //PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
//    //ReferenceHandler = ReferenceHandler.Preserve
//};

//string json = JsonSerializer.Serialize(people, options);

//Console.WriteLine(json);

//File.WriteAllText("people.json", json);

string json = File.ReadAllText("people.json");

List<Person> people;

var options = new JsonSerializerOptions()
{
    UnmappedMemberHandling = JsonUnmappedMemberHandling.Skip
};

people = JsonSerializer.Deserialize<List<Person>>(json, options);

foreach (var person in people)
{
    Console.WriteLine(person.FirstName);
}

[DebuggerDisplay("{FirstName,nq} {LastName,nq}, Age = {Age}")]
class Person
{

    public string FirstName { get; set; }
    
    [JsonPropertyOrder(-1)]
    public string LastName { get; }

    [JsonIgnore]
    public int Age { get; set; }
    //public Person BestFriend { get; set; }

    public double Height;


    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
}