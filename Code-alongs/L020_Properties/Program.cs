
Person myPerson = new Person("Fredrik");

Console.WriteLine(myPerson.Name);

myPerson.Name = "Anders";

Console.WriteLine(myPerson.Name);



// Console.WriteLine(myPerson.name);

// myPerson.name = "Anders";

//Console.WriteLine(myPerson.GetName());

////myPerson.name = "Anders Johansson"; // Fungerar inte om myPerson.name är private
//myPerson.SetName("Anders");

//myPerson.Name = "Kalle";
//Console.WriteLine(myPerson.name);
//Console.WriteLine(myPerson.Name);


class Person
{
    private string name = string.Empty;

    public string Name
    {
        get
        {
            return name.ToUpper(); ;
        }
        set
        {
            if (value.Length > 10)
            {
                throw new ArgumentException();
            }

            this.name = value;
        }
    }

    public Person(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return this.name.ToUpper(); ;
    }

    public void SetName(string name)
    {
        if (name.Length > 10)
        {
            throw new ArgumentException();
        }

        this.name = name;
    }
}