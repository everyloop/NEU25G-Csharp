

Func<int, int> square = x => x * x;
Action<int> printInt = i => Console.WriteLine(i);

printInt(square(5));

//static int Square(int x)
//{
//    return x * x;
//}

PrintResults(x => x * 10 + 5);

Console.WriteLine();

PrintResults(x => x % 3);

Console.WriteLine();

PrintResults(n =>
{
	int sum = 0;

	for (int i = 0; i <= n; i++)
	{
		sum += i;
	}
	return sum;
});

static void PrintResults(Func<int, int> func)
{
	for (int i = 1; i <= 10; i++)
	{
        Console.WriteLine($"{i}: {func(i)}");
	}
}

Console.WriteLine();

Func<Person, int, bool> isLegal = (person, legalAge) => person.Age >= legalAge;
Console.WriteLine(isLegal(new Person() { Age = 15}, 18));

Console.WriteLine();

Func<int, int, int, string> getString = (a, b, c) => $"{a} + {b} + {c} = {a + b + c}";
Console.WriteLine(getString(3, 6, 19));

Console.WriteLine();

Func<double, double, double> getCylinderVolume = (r, h) => r * r * Math.PI * h;
Console.WriteLine(getCylinderVolume(2, 10));

class Person
{
    public int Age { get; set; }
}