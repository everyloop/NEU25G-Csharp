# Oktober 13

**Lecture slide:**  
[Delegates.pdf](https://github.com/everyloop/NEU25G-Csharp/blob/master/Resources/Delegates.pdf)

## Language Integrated Queries (LINQ)

**Code-along:**  
[L036_LINQ](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L036_LINQ/Program.cs)

LINQ lägger till funktionalitet för databehandling på IEnumerable interfacet med hjälp av extension methods. Det betyder att alla typer som implementerar IEnumberable, så som t.ex arrayer och listor, får ett gäng nya metoder för att enkelt göra operationer på hela datamängden i en collection.

[Querying made easy](https://medium.com/@jepozdemir/exploring-linq-in-c-querying-made-easy-f06a590e5a89)

Några användbara metoder är till exempel:

**ofType** används för att filtrera ut objekt av en given typ.

**any** används för att kolla om *något* av elementen i en collection uppfyller ett givet vilkor; returnerar true/false.

**all** används för att kolla om *alla* elementen i en collection uppfyller ett givet vilkor; returnerar true/false.

**where** används för att filtrera ut alla element som uppfyller ett givet vilkor; returnerar en IEnumerable som kan användas för deferred execution, eller omvandlas till t.ex en array eller lista.

**select** används för att projicera (transformera) data för varje element utifrån ett givet vilkor; returnerar en IEnumerable som kan användas för deferred execution, eller omvandlas till t.ex en array eller lista.

**orderBy** används för att sortera i stigande ordning.

**orderByDescending** används för att sortera i fallande ordning.

**firstOrDefault** returnera första elementet i listan som uppfyller ett givet vilkor.

**lastOrDefault** returnera sista elementet i listan som uppfyller ett givet vilkor.

**count** räkna antal element som uppfyller ett givet vilkor.

## Deferred execution

[Läs här!](https://www.tutorialsteacher.com/linq/linq-deferred-execution)

[Yield return](https://www.kenneth-truyers.net/2016/05/12/yield-return-in-c/)

**Code-along:**  
[L037_Yield_return](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L037_Yield_return/Program.cs)
