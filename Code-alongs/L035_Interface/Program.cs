

//using(var reader = new StreamReader("myFile.txt"))
//{
//    // ...
//}

//using (var cat = new Cat())
//{
//    Console.WriteLine("Cat");
//}
//Console.WriteLine("The end!");


var myCat = new Cat("Pelle");
myCat.Collect();


class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }
}

class Cat : Animal, IDisposable, ICollectable
{
    public Cat(string name) : base(name) { }

    public void Collect()
    {
        Console.WriteLine($"{Name} was collected!");
    }

    public void Dispose()
    {
        Console.WriteLine("Disposed!");
    }

    public bool IsCollected()
    {
        throw new NotImplementedException();
    }
}

interface ICollectable
{
    public void Collect();
    public bool IsCollected();
}
