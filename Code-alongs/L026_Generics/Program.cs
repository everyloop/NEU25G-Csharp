
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

static void Swap<T>(ref T a, ref T b)
{
    T hold = a;
    a = b;
    b = hold;
}



//var birdCage = new Cage<Bird>();
//birdCage.Inhabitant = new Bird();

//var catCage = new Cage<Cat>();
//catCage.Inhabitant = new Cat();

//Console.WriteLine();


//class Bird { }
//class Cat { }

//class Cage<T>()
//{
//    public T Inhabitant { get; set; }
//}




