
// Key word new används för att skapa ett nytt objekt (en instans av en klass):
// 1 - Allokerar minne för att lagra objektet.
// 2 - Skapar objektet på den platsen i minnet, med default värden.
// 3 - Kör konstruktorn
// 4 - Returnerar en referens till det nya objektet.

Person myPerson = new Person("Fredrik", 44);

Person myOtherPerson = new Person("Maria");

// Exempel med implicit typad referens:
var anna = new Person("Anna");

// Exempel med kort-varianten new(), istället för new Person()
Person kalle = new("Kalle");

// var anders = new("Anders");//  <= Fungerar inte; man kan inte använda var tillsammans med new()

Console.WriteLine();

// Konstruktorer används för att initialisera field, properties etc i objekten som skapas; ofta med parametrar som skickas med new()
class Person
{
    public string name = string.Empty;
    private int age = 0;

    // Konstuktor är en speciell metod som alltid heter sama som klassen, och inte har void eller datatyp framför namnet.
    public Person()
    {
        this.name = "My Person";
        this.age = 20;
    }

    // Man kan ha flera versioner av konstruktorn med olika parametrar (overloading)
    public Person(string name)
    {
        this.name = name;
    }

    // När man skapar en ny instans körs den konstruktorn som matchar parametrarna i new().
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Om man inte själv angett en konstuktor i sin klass så finns alltid en default konstruktor som inte tar några parametrar.

    // Denna ersätts dock med den första konstruktorn man explicit implementerar... så om man fortfarande vill ha en version som
    // inte tar några parametrar så behöver man själv lägga till en sådan i dessa fall.
}