
Person myPerson = new Person("Fredrik") { FirstName = "Anders" };
// myPerson.FirstName = "Bertil"; <= FirstName kan inte sättas här eftersom den använder accessorn init, istället för set.

Console.WriteLine(myPerson.Name);

myPerson.Name = "Anders";

var name = myPerson.Name;

Console.WriteLine(myPerson.Name);


// Console.WriteLine(myPerson.name);

// myPerson.name = "Anders";

//Console.WriteLine(myPerson.GetName());

////myPerson.name = "Anders Johansson"; // Fungerar inte om myPerson.name är private
//myPerson.SetName("Anders");

//myPerson.Name = "Kalle";
//Console.WriteLine(myPerson.name);
//Console.WriteLine(myPerson.Name);

myPerson.Age = 25;
var myInt = myPerson.Age;

Console.WriteLine(myPerson.Length);

Console.WriteLine(myPerson.LastName);


class Person
{
    private string _name = string.Empty;

    public string Name
    {
        get
        {
            return _name.ToUpper(); ;
        }
        set
        {
            if (value.Length > 10)
            {
                throw new ArgumentException();
            }

            this._name = value;
        }
    }

    // Backing field till Age, privat och börjar med _
    private int _age = 0;

    // Property (code snippet: propfull)
    public int Age
    {
        get { return this._age; }
        set { this._age = value; }
    }

    // Auto-property (code snippet: prop)
    public double Length { get; set; } = 1.85; // Auto-property har en dold backing-field, men den kan ta en initialt värde; i detta fall 1.85

    public string FirstName { get; init; } // Kan bara sättas i konstruktorn eller i samband med new() - sedan är den read-only

    public string LastName { get; private set; } // Publikt/Externt är den read-only, men internt i klassen är den read/write.

    // Konstruktor
    public Person(string name)
    {
        this._name = name;
    }

    // Exempel på hur vanliga metoder kan sätta/läsa privata fields. Men i normala fall används med fördel en property istället för dessa två metoder. 
    public string GetName()
    {
        return this._name.ToUpper(); ;
    }

    public void SetName(string name)
    {
        if (name.Length > 10)
        {
            throw new ArgumentException();
        }

        this._name = name;
    }
}