

Size mySize = Size.Medium;

Color myColor = Color.Black;

//Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine($"mySize = {mySize}");
Console.WriteLine($"myColor = {myColor}");

Identification id = Identification.Passport | Identification.BankId;
Console.WriteLine($"id = {id}");


enum Size : byte { Small = 100, Medium = 150, Large = 180 }; // Lagras som en byte, då vi angett det.

enum Color // Default är att det lagras som en Int32
{
    White = 10,
    Black,
    Red,
    Green = 20,
    Blue,
    Yellow
}

[Flags]
enum Identification : byte
{
    Passport = 1,
    DriverLicence = 2,
    NationalId = 4,
    BankId = 8
}




//Point p1 = new Point(3.0, 5.0);
//Point p2 = new Point(3.0, 5.0);

//Console.WriteLine($"p1 == p2 => {p1.Equals(p2)}");

//Point p3 = p1;
//p1.X = 8;

//Console.WriteLine($"p1 = ({p1.X}; {p1.Y})");
//Console.WriteLine($"p2 = ({p2.X}; {p2.Y})");
//Console.WriteLine($"p3 = ({p3.X}; {p3.Y})");

struct Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }
}