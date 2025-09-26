# September 19

**Lecture slide:**  
[ValueAndReferenceTypes.pdf](https://github.com/everyloop/NEU25G-Csharp/blob/master/Resources/ValueAndReferenceTypes.pdf)

## Stack & Heap

För att förstå minnes hantering i C#, och därmed bättre förstå value- och reference types, pass-by-value, pass-by-reference, och när man bör använda vad, så kan det vara en god idé att först förstå skillnaden på stack och heap.

[Läs mer här!](https://endjin.com/blog/2022/07/understanding-the-stack-and-heap-in-csharp-dotnet)

## Value types & Reference types

Alla datatyper i .NET är antingen en value type eller en reference type.

Value types lagrar det faktiska datavärdet direkt i minnet för variabeln.

Reference types lagrar i stället en referens till det faktiska värdet/objektet.

[Läs mer här!](https://medium.com/@dev.msalah/value-vs-reference-types-in-c-573e3cf6c5bf)

## Pass-by-value & Pass-by-reference

När man skickar in variabler i metoder kan dessa skickas antingen som pass-by-value eller pass-by-reference. Detta gäller oavsett om det är en value type eller en reference typ.

Pass-by-reference markeras med keyword "ref" eller "out" i C#, och innebär att metoden kan uppdatera den variabel som skickats in som argument vid anropet.

[Läs mer här!](https://www.c-sharpcorner.com/UploadFile/f1047f/story-of-pass-by-value-and-pass-by-reference-in-C-Sharp/)

[Se även: Ref vs Out](https://medium.com/@nwonahr/understanding-the-ref-and-out-keywords-in-c-f23757684575)

**Code-along:**  
[L021_Pass_by_value_vs_Pass_by_reference](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L021_Pass_by_value_vs_Pass_by_reference/Program.cs)

## Struct & Enum

Struct och Enum är två konstruktioner i C# som vi kan använda för att definera våra egna value types.

[Struct](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct) fungerar i stor sett (men det finns skillnader) som en class, med properties, metoder etc, men definerar en value type i stället för en reference type (som class gör).

[Enum](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum), eller enumeration types, definerar en datatyp som reperesenter en uppsättning konstanta värden/namn, t.ex färger. Skapar man en variabel med en enum typ så kan värdet på variabeln vara något av de värden (färger) som defineras i typen.

**Code-along:**  
[L022_Struct_&_Enum](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L022_Struct_%26_Enum/Program.cs)