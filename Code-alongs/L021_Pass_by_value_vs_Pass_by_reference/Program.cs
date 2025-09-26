
// Value type
int a = 5;
int b = a;  // Kopierar värdet 5 till b
a = 3;

Console.WriteLine($"a = {a}, b = {b}");

// Reference type
Person personA = new Person() { name = "Adam" };
Person personB = personA;  // Kopierar referensen till "Adam" till personB

// Om man ändrar namnet på objektet som personA refererar till, så är det samma objekt som personB refererar till.
personA.name = "Bertil";

// Om man däremot ändrar referensen i sig, så påverkas inte referensen personB
//personA = new Person() { name = "Bertil" };

Console.WriteLine($"personA.name = {personA.name}, personB.name = {personB.name}\n");

PassValuetypeByValue(a);
Console.WriteLine($"PassValuetypeByValue(a) => a = {a}\n");

PassValuetypeByReference(ref a);
Console.WriteLine($"PassValuetypeByReference(ref a) => a = {a}\n");

static void PassValuetypeByValue(int x)
{
    x += 2;
    Console.WriteLine($"x = {x}");
}

static void PassValuetypeByReference(ref int x)
{
    x += 2;
    Console.WriteLine($"x = {x}");
}

PassReferencetypeByValue(personA);
Console.WriteLine($"PassReferencetypeByValue(personA.name) => personA.name = {personA.name}\n");

PassReferencetypeByReference(ref personA);
Console.WriteLine($"PassReferencetypeByReference(personA.name) => personA.name = {personA.name}\n");

static void PassReferencetypeByValue(Person p)
{
    //p.name = "David";
    p = new Person() { name = "David" };
    Console.WriteLine($"p.name = {p.name}");
}

static void PassReferencetypeByReference(ref Person p)
{
    //p.name = "David";
    p = new Person() { name = "David" };
    Console.WriteLine($"p.name = {p.name}");
}


class Person
{
    public string name;
}