# Oktober 6

## Delegat

Delegat är en typ som representerar referenser till metoder med en viss parameterlista och returtyp. När du instansierar ett delegat kan du associera dess instans med valfri metod som har en kompatibel signatur och returtyp. Du kan sedan anropa metoden via delegatinstansen.

Delegat används för att skicka metoder som argument till andra metoder.

[Läs mer här!](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/)

Se även [multicast delegates](https://www.geeksforgeeks.org/multicast-delegates-in-c-sharp/)

**Code-along:**  
[L029_Delegates](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L029_Delegates/Program.cs)

## Generiska delegat-typer

Istället för att definera sina egna delegat-typer så är det oftast enklare att använda de generiska delegat-typerna Action<T> och Func<T>.

Action används för delegat som refererar till en metod med en eller flera inparametrar, och som **inte** returnerar någon data.

Func används för delegat som refererar till en metod med en eller flera inparametrar, och som returnerar någon data.

[Läs mer här!](https://dev.to/theramoliya/action-and-func-delegates-in-c-2mg5)

**Code-along:**  
[L029_Delegates](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L029_Delegates/Program.cs)

## Event

Event gör det möjligt för en klass eller ett objekt att meddela andra klasser eller objekt när något av intresse inträffar. Klassen som skickar (eller genererar) händelsen kallas *publisher* och de klasser som tar emot (eller hanterar) händelsen kallas *subscribers*.

[Läs mer här!](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/events/)

**Code-along:**  
[L032_Events](https://github.com/everyloop/NEU25G-Csharp/tree/master/Code-alongs/L032_Events)