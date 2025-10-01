
var myCar = new Car("Toyota", "Yaris", "Yellow", 4.5);

//Console.WriteLine($"{myVehicle.Brand}, {myVehicle.Model}, {myVehicle.Color}");

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    public Vehicle()
    {
        
    }

    public Vehicle(string brand)
    {
        Brand = brand;
    }

    public Vehicle(string brand, string model) : this(brand)
    {
        Model = model;
    }

    public Vehicle(string brand, string model, string color) : this(brand, model)
    {
        Color = color;
    }
}

class Car : Vehicle
{
    public double Length { get; set; }
    
    public Car(string brand, string model, string color, double length) : base(brand, model, color)
    {
        Length = length;
    }

}