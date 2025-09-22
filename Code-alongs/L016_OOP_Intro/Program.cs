
//Cat myCat = new Cat() { name = "Pelle", age = 4 };
//Cat myOtherCat = new Cat() { name = "Måns", age = 5 };
//Cat myThirdCat = new Cat() { name = "Bill", age = 2 };
//Cat myForthCat = new Cat() { name = "Bull", age = 2 };

//Cat[] cats = new Cat[] { myCat, myOtherCat, myThirdCat, myForthCat, new Cat() { name = "Maja" } };

Cat[] cats = new Cat[] {
    new Cat() { name = "Pelle", age = 4 },
    new Cat() { name = "Måns", age = 5 },
    new Cat() { name = "Bill", age = 2 },
    new Cat() { name = "Bull", age = 2 },
    new Cat() { name = "Maja" },
};

foreach (var cat in cats)
{
    Console.WriteLine($"{cat.name} är {cat.age} år gammal.");
}

class Cat
{
    public string name = "default name";
    public int age = 0;
}


