# September 22

**Lecture slide:**  
[OOP.pdf](https://github.com/everyloop/NEU25G-Csharp/blob/master/Resources/OOP.pdf)

**Code-along:**  
[L016_OOP_Intro](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L016_OOP_Intro/Program.cs)

## Object oriented programming (OOP)

### Grundidén

Objektorienterad programmering (OOP) är ett sätt att strukturera program så att man beskriver världen med objekt.

- Ett objekt är en kombination av data (tillstånd, egenskaper) och funktionalitet (beteenden, vad objektet kan göra).

- Man organiserar programmet genom att skapa klasser som definierar hur ett visst slags objekt ser ut och fungerar.

### Jämförelse

- Utan OOP: du har massor av variabler och funktioner utspridda, och måste själv hålla koll på vilken funktion hör till vilken data.

- Med OOP: du binder ihop data och funktioner i en tydlig enhet → ett objekt.

[Läs mer här!](https://sv.wikipedia.org/wiki/Objektorienterad_programmering)

## Fyra grundprinciper i OOP

- Encapsulation
- Abstraction
- Inheritance
- Polymorphism

[Läs mer här!](https://medium.com/@estheremeka026/the-four-pillars-of-oop-in-c-6673b17244a7)

## Klasser och objekt

### Klass

En **klass** är som en **ritning** eller en **mall**.

Den beskriver hur ett visst slags objekt ska se ut och bete sig.

Den innehåller:

- **Fält/egenskaper** (data, t.ex. färg, hastighet).

- **Metoder** (funktioner, t.ex. kör, bromsa).

👉 Klassen i sig gör ingenting förrän du använder den för att skapa ett **objekt**.

### Objekt

Ett **objekt** är en **instans av en klass**.

- Om klassen är ritningen, så är objektet det **färdiga huset** byggt från ritningen.

- Du kan skapa flera objekt från samma klass – alla följer ritningen, men de kan ha olika värden.

![OOP](https://github.com/everyloop/NEU25G-Csharp/blob/master/Lecture-notes/Images/OOP.png)

## this

I C# används keyword "this" för att referera till den instans av klass som har anropat en av klassens metoder.

## null

Keyword null används som en literal value för att indikera att en referens inte pekar på något faktiskt objekt.

## Method overloading

Flera metoder i en klass kan ha samma namn fast med olika (i antal eller typ) parametrar. Detta är en typ av polymorfism. (Poly = Många, Morph = Former). Med andra ord: Method overloading låter oss skapa flera olika former av samma metod. Vilken av implementationerna som faktiskt körs avgörs vid kompilering genom att kolla på vilka argument som skickas in vid anropet.

## Static classes and members

### Statisk metod

- En statisk metod tillhör klassen i stället för ett objekt.

- Du anropar den via klassen, inte via en instans (MyClass.MyMethod() i stället för myObj.MyMethod()).

- Den kan bara nå statiska fält/medlemmar i klassen, inte instansdata (this finns inte).

### Statisk klass

- En klass som är markerad med static kan inte instansieras (du kan inte göra new på den).

- Alla dess medlemmar måste vara static.

- Används för hjälpmetoder eller utilities.

[Läs mer här!](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members)

## Top level statements

Top level statements introducerades i C# 9. Innan dess behövde alla program alltid innehålla en explicit Main-metod som var appens entry point.

[Läs mer här!](https://www.thomasclaudiushuber.com/2020/08/18/c-9-top-level-statements-or-should-i-say-hey-wheres-the-main-method/)

Se även längre förklaring i kommentarerna i denna code-along:

**Code-along:**  
[L017_Main_method_entry_point](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L017_Main_method_entry_point/Program.cs)