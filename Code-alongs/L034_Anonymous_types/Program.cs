

var person = new { FirstName = "Anders", LastName = "Svensson", Age = 34 };

Console.WriteLine(person.FirstName);
Console.WriteLine(person.Age);

var typeExamples = new { Float = 3.2f, Double = 5.4, Decimal = 102.3m, Bool = true };

Console.WriteLine();

var countries = new string[] { "Sweden", "Denmark", "Norway" };

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

foreach (var p in people)
{
    Console.WriteLine($"{p.FirstName} {p.LastName} är {p.Age} år gammal.");
}

var user = new
{
    name = "Anders Eriksson",
    age = 45,
    contactInfo = new { email = "anders@gmail.com", phone = "2384723984" }
};

Console.WriteLine(user.contactInfo.email);