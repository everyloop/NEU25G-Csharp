
Cat myCat = new Cat() { name = "Pelle", age = 4 };
Cat myOtherCat = new Cat() { name = "Måns", age = 5 };
Cat myThirdCat = new Cat() { name = "Bill", age = 2 };
Cat myForthCat = new Cat() { name = "Bull", age = 2 };

Cat[] cats = new Cat[] { myCat, myOtherCat, myThirdCat, myForthCat };

//Cat[] cats = new Cat[] {
//    new Cat() { name = "Pelle", age = 4 },
//    new Cat() { name = "Måns", age = 5 },
//    new Cat() { name = "Bill", age = 2 },
//    new Cat() { name = "Bull", age = 2 },
//    new Cat() { name = "Maja" },
//};

Console.WriteLine("*** Looping through the cats, printing fields and running methods ***");

foreach (var cat in cats)
{
    // Console.WriteLine($"cat.GetDoubleAge() => {cat.GetDoubleAge()}"); // <= Fungerar inte att anropa eftersom metoden är 'private'.

    Console.WriteLine($"\n{cat.name} är {cat.age} år gammal.");
    cat.Greet();
}

Console.WriteLine("\n\n*** Cat greeting Fredrik ***");
myOtherCat.Greet("Fredrik");

Console.WriteLine("\n\n*** Cats greeting each other ***");
myCat.Greet(myOtherCat); 
myOtherCat.Greet(myCat);


// Statiska medlemmar hör till datatypen, inte de enskilda instanserna.

Console.WriteLine("\n\n*** Static members ***");
Cat.numberOfLives = 6;
Console.WriteLine($"Cat.numberOfLives = {Cat.numberOfLives}");
Cat.PrintNumberOfLives();


// Även klasser kan defineras som static, vilket betyder att den inte kan instansieras alls (och inte heller ha instans(icke statiska)-medlemar)
// Exempel på sådana klasser är Console och Math. Det är inte meningen att man ska göra instanser av dem, utan de tillhandhåller allmän funktionalitet.
class Cat
{
    public string name = "default name";
    public int age = 0;
    public static int numberOfLives = 9;

    public void Greet()
    {
        Console.WriteLine($"Hej, jag heter {name} och min dubbla ålder är {GetDoubleAge()}!");
    }

    public void Greet(string name)
    {
        Console.WriteLine($"Hej {name}, jag heter {this.name}!");
    }

    public void Greet(Cat cat)
    {
        Console.WriteLine($"Hej {cat.name}, jag heter {this.name}");

    }

    public void GreetAndTellNumberOfLives(Cat cat)
    {
        Console.WriteLine($"Hej {cat.name}, katter har {numberOfLives} liv!");

    }
    private int GetDoubleAge()
    {
        return age * 2;
    }

    public static void PrintNumberOfLives()
    {
        Console.WriteLine($"Every cat has {numberOfLives} lives.");
    }
}


























