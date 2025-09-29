

Car myCar = new Car();
myCar.Engine = new Engine();

// Null conditonal ?.
Console.WriteLine(myCar?.Engine?.numberOfCylinders);


myCar.Engine = null;

// Null coalescing operator ??  (Väljer den vänstra operander om den inte är null, annars den högra)
Engine myEngine = myCar.Engine ?? new Engine() { numberOfCylinders = 8 };

Console.WriteLine(myEngine.numberOfCylinders);



// Arv - "Is A"-relationship => En katt ÄR ett djur.

// Komposition - "Has A"-relationship => En bil HAR en motor.

class Car
{
    //public Car()
    //{
    //    this.Engine = new Engine();    
    //}

    public string Brand { get; set; }

    public Engine Engine { get; set; } // = new Engine();
}

class Engine
{
    public int numberOfCylinders { get; set; } = 6;
}
