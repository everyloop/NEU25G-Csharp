
//var animal = new Animal() { Name = "Orvar" };
//animal.Run();

Console.WriteLine();

var cat = new Cat() { Name = "Pelle" };
cat.Run();
cat.Mew();
cat.Walk();

Console.WriteLine();

var dog = new Dog() { Name = "Fido" };
dog.Run();
dog.Bark();
dog.Walk();

Console.WriteLine();

dog.ScareAway(cat);

Console.WriteLine();

cat.ScareAway(dog);

Console.WriteLine();

Animal[] animals = new Animal[]
{
    new Cat() { Name = "Måns" },
    new Dog() { Name = "Pluto" },
    new Dog() { Name = "Karo" },
    new Cat() { Name = "Maja" },
};

foreach (var animal in animals)
{
    animal.Walk();

    // Cast kommer kasta en exception om animal inte kan castas till Cat.
    // Cat myCat = (Cat)animal;
    
    // I detta fallet kommer dock myCat bli null istället för att en exception kastas.
    Cat myCat = (animal as Cat);

    // The null conditional operator (?.) allows you to perform member access or method calls on an object only if that object is not null.
    // If the object is null, the operation returns null instead of throwing a null reference exception. 
    myCat?.Mew();

    // The null conditional operator kan alltså anvädas istället för:
    //if (myCat is not null)
    //{
    //    myCat.Mew();
    //}

    // is-operatorn används för att se om animal är datatypen Cat
    //if (animal is Cat)
    //{
    //    Cat myCat = (Cat)animal;
    //    myCat.Mew();
    //}

    // is-operatorn kan även göra en auto-cast (myDog) om animal är Dog.
    //if (animal is Dog myDog) myDog.Bark();


    //var myString = animal.ToString();
    //Console.WriteLine(myString);
    //animal.ScareAway(dog);
    //Console.WriteLine();
}

Console.WriteLine();

// Implicit konvertering
int myInt = 100;
long myLong = myInt;
Console.WriteLine("Implicit konvertering: int => long");
Console.WriteLine($"myInt = {myInt}");
Console.WriteLine($"myLong = {myLong}");

// Explicit konvertering (Cast)
myLong = 10000000000;
myInt = (int)myLong;
Console.WriteLine("\nExplicit konvertering: long => int (här krävs en cast)");
Console.WriteLine($"myLong = {myLong}");
Console.WriteLine($"myInt = {myInt}");

abstract class Animal
{
    public string Name { get; set; }

    public virtual void Run()
    {
        Console.WriteLine($"{Name} is running.");
    }

    public abstract void Walk();

    public void ScareAway(Mammal animal)
    {
        Console.WriteLine($"{this.Name}: I'm going to eat you {animal.Name}!");
        animal.Run();
    }

    public override string ToString()
    {
        return this.Name;
    }
}

abstract class Mammal : Animal
{
    public override void Run()
    {
        Console.WriteLine($"{Name} is running like a mammal");
        //base.Run();
    }
}
class Cat : Mammal
{
    public void Mew()
    {
        Console.WriteLine($"{Name}: Meow!");
    }

    public override void Walk()
    {
        Console.WriteLine($"{Name} is walking like a cat.");
    }
}

class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine($"{Name}: Woof!");
    }

    public override void Run()
    {
        Console.WriteLine($"{Name} is running like a dog.");
        //base.Run();
    }

    public override void Walk()
    {
        Console.WriteLine($"{Name} is walking like a dog.");
    }
}