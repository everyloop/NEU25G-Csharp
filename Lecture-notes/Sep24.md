# September 24

## Namespaces

**Code-along:**  
[L018_Namespaces](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L018_Namespaces/Program.cs)

Ett namespace är som en mapp för klasser och andra typer.

- Hjälper till att organisera koden.

- Hindrar namnkrockar (två olika bibliotek kan ha en Person-klass, men i olika namespaces).

- Gör det enklare att hitta och förstå var en klass hör hemma.

## Konstruktor

**Code-along:**  
[L019_Konstruktor](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L019_Konstruktor/Program.cs)

En konstruktor är en speciell metod som körs automatiskt när man skapar ett nytt objekt med new.
Syftet är att sätta upp objektet i ett giltigt startläge:

- Ge startvärden till fält och properties.

- Utföra initial logik (t.ex. öppna en fil, koppla upp mot en databas, initiera resurser).

### Regler för konstruktorer

- Har samma namn som klassen.

- Har ingen returtyp (inte ens void).

- Kan ta emot parametrar.

- Kan finnas flera (metodöverlagring).

**Exempel:**
```cs
class Person
{
    public string Name;
    public int Age;

    // Konstruktor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

var p = new Person("Anna", 30);
Console.WriteLine($"{p.Name}, {p.Age}"); // 
```
När vi gör new Person("Anna", 30) händer:

- Minnesutrymme skapas.

- Fälten initieras med standardvärden (null, 0, false …).

- Konstruktorn körs och sätter Name och Age.

- En referens till objektet returneras.

## Properties

**Code-along:**  
[L020_Properties](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L020_Properties/Program.cs)

En property är som en kombination av ett fält och metoderna för att läsa/skriva det.

- Ser ut som en variabel utåt (obj.Name),

- Men under ytan kan den innehålla logik (validering, beräkning, etc).

- Är en viktig del av inkapsling i objektorienterad programmering.

**Exempel 1: property med logik**
```cs
class Person
{
    private string name;   // privat fält

    public string Name     // property
    {
        get { return name; }   // körs när man läser
        set 
        { 
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty");
            name = value;      // körs när man skriver
        }
    }
}
```
Användning:
```cs
var p = new Person();
p.Name = "Anna";          // anropar set
Console.WriteLine(p.Name); // anropar get
```

**Exempel 2: auto-property**

När man inte behöver logik kan man låta C# skapa fältet åt oss:

```cs
class Person
{
    public string Name { get; set; }  // auto-property
}
```
Detta ger automatiskt ett dolt fält i bakgrunden.

### Olika varianter

**Endast läsbar property:**
```cs
public string Name { get; }
```

**Write-only property** (ovanlig):
```cs
public string Password { set { /* ... */ } }
```

**Init-only:**
```cs
public string Name { get; init; }

var p = new Person { Name = "Anna" }; // ✅
// p.Name = "Lisa"; ❌
```

**Read/Write internt, Read-only externt:**
```cs
public string Name { get; private set; }
```

### Varför properties i stället för publika fält?

Om du gör fältet publikt:
```cs
public string Name;
```
… kan du inte senare lägga till validering utan att ändra all kod som använder det.

Men om du alltid exponerar det som en property:

```cs
public string Name { get; set; }
```
… kan du senare lägga till logik i get eller set utan att bryta användarkoden.

### Sammanfattning

- Property = “kontrollerad åtkomst” till ett värde.

- Ser ut som en variabel, men kan ha logik bakom.

- Kan vara get-only, set-only, init, auto-property, eller med full logik.

- Viktig för inkapsling och flexibel design.
