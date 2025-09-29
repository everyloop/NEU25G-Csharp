
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
    //animal.Walk();
    //var myString = animal.ToString();
    //Console.WriteLine(myString);

    animal.ScareAway(dog);
    Console.WriteLine();
}

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