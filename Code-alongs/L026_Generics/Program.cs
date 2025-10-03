
int x = 5;
int y = 3;

Console.WriteLine($"x = {x}, y = {y}");

Swap(ref x, ref y);

Console.WriteLine($"x = {x}, y = {y}");

string textA = "hello";
string textB = "world";

Console.WriteLine($"\ntextA = {textA}, textB = {textB}");

Swap(ref textA, ref textB);

Console.WriteLine($"textA = {textA}, textB = {textB}");

Console.WriteLine(AreAllElementsEqual(new char[] { '2', '2', '2', '2' }));

static void Swap<T>(ref T a, ref T b)
{
    T hold = a;
    a = b;
    b = hold;
}

static bool AreAllElementsEqual<T>(T[] array)
{
    if (array.Length == 0) return true;

    for (int i = 0; i < array.Length; i++)
    {
        if (!Object.Equals(array[i], array[0])) return false;
    }

    return true;
}


//var birdCage = new Cage<Bird>();
//birdCage.Inhabitant = new Bird();

//var catCage = new Cage<Cat>();
//catCage.Inhabitant = new Cat();

//Console.WriteLine();

//var cage = new DoubleCage<Bird, Cat>();

//class Bird { }
//class Cat { }

//class DoubleCage<T1, T2>()
//{
//    public T1 FirstInhabitant { get; set; }
//    public T2 SecondInhabitant { get; set; }

//}




