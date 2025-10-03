# September 26

## Generiska klasser och metoder

En generisk klass är en klass där någon datatyp inte är fördefinierad, utan deklareras i koden som instantierar klassen. En lista där värdena som lagras är int har till exempel datatypen List\<int\> och en lista med strings är en List\<string\>.

Det som skrivs mellan \<\> i en generisk klass kallas för en typ-parameter.

[Läs mer här!](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics)

**Code-along:**  
[L026_Generics](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L026_Generics/Program.cs)

## Generic collections

C# innehåller ett antal färdiga generiska klasser i form av "samlingar" – helt enkelt objekt som samlar flera objekt eller värden av andra datatyper. Till exempel kan en samling innehålla integers, strings eller instanser av en klass.

Bilden nedan visar några av de vanligaste typerna av generic collections:

![GenericCollections](https://github.com/everyloop/NEU25G-Csharp/blob/master/Lecture-notes/Images/GenericCollections.png)

## [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-8.0)

**Code-along:**  
[L027_List](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L027_List/Program.cs)

## [Dictionary\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-8.0)

**Code-along:**  
[L028_Dictionary](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L028_Dictionary/Program.cs)

## [Stack\<T\>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=net-8.0)

## [Queue\<T\>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=net-8.0)

