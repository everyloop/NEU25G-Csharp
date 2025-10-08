

var numbers = new int[] { 4, 6, 97, -15, 13 };

Array.Sort(numbers);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine();

var cats = new Cat[]
{
    new Cat("Pelle", 4),
    new Cat("Måns", 5),
    new Cat("Bill", 2),
    new Cat("Bull", 2),
    new Cat("Maja", 3),
};

Array.Sort(cats);
Array.Reverse(cats);

foreach (var cat in cats)
{
    Console.WriteLine($"{cat.Name} är {cat.Age} år gammal.");
}

Console.WriteLine();

//BadSort(new Cat[5]);

//static void BadSort(IComparable<Cat>[] comparables)
//{
//    if (comparables[0].CompareTo(comparables[1]) < 0)
//    {
//        IComparable temp = comparables[0];
//        comparables[0] = comparables[1];
//        comparables[1] = temp;
//    }
//}

//using(var reader = new StreamReader("myFile.txt"))
//{
//    // ...
//}

//using (var cat = new Cat())
//{
//    Console.WriteLine("Cat");
//}
//Console.WriteLine("The end!");


var myCat = new Cat("Pelle", 9);
//myCat.Collect();

ICollectable collectable = myCat;
myCat = (Cat)collectable;

var collectibles = new List<ICollectable>();
collectibles.Add(myCat);
collectibles.Add(new PokemonCard());

var myInventory = new Inventory();

if (!myInventory.TryCollect(5))
{
    Console.WriteLine("Could not collect item!");
}

myInventory.Collect(myCat);

class Inventory
{
    public List<ICollectable> Items { get; set; }

    public Inventory()
    {
        Items = new List<ICollectable>();
    }

    public bool TryCollect(object o)
    {
        if (o is ICollectable item)
        {
            Items.Add(item);
            item.Collect();
            return true;
        }

        return false;
    }

    public void Collect(ICollectable collectable)
    {
        Items.Add(collectable);
    }
}

class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }
}

class Cat : Animal, IDisposable, ICollectable, IComparable<Cat>
{
    public int Age { get; set; }
    public Cat(string name, int age) : base(name) 
    {
        Age = age;
    }

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

    public int CompareTo(Cat? other)
    {
        //return this.Name.CompareTo(other.Name);
        return this.Age.CompareTo(other.Age);
    }
}

class PokemonCard : ICollectable
{
    public void Collect()
    {
        Console.WriteLine("You collected a pokemon!");
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
