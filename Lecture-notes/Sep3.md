# September 3

## Statement (sats)
Fullständig instruktion. Kan sluta på ; alternativ vara ett block { } av flera statements.

```cs
Console.WriteLine("This line is a statement");

if (true)
{
    Console.WriteLine("Statement 1");
    Console.WriteLine("Statement 2");
    // ...
}
```

## Expression (uttryck)
Utvärderas till ett värde.


- 5 + 3
- x * 2
- "Hello" + " " + "World"

## Keywords
Reserverade ord som redan används av C#.

**Exempel:** if, for, true, while

## Case

-UPPERCASE
- lowercase
- camelCase(förstaOrdetBörjarMedLitenBokstavSedanRestenBörjarPåStor)
- PascalCase(AllaOrdBörjarPåStorBokstav)
- snake_case(bara_små_bokstäver_ord_avskiljda_med_underscore) < -Används ej i C#
 - kebab-case (bara_små_bokstäver_ord_avskiljda_med_bindesträck)   <- Används ej i C#

Språket C# är case sensitive, till skillnad från vissa andra språk som är case insensitve.

## Identifiers
Namn som man ger på variabler, funktioner, klasser etc.
-Kan innehålla bokstäver, nummer och underscore (_), inte övriga tecken eller space.
 - Måste börja med bokstav eller underscore (inte siffra)
 - Man kan inte använda reserverade ord (keywords)
 - variabler och parameterar skrivs i camelCase, alla andra identifiers (t.ex klasser & metoder) använder PascalCase. (enligt konvention)

## Variabler
En "behållare" för att lagra data av en given typ.

I C# måste variabler deklareras innan de kan användas.

```cs
int x;
int y = 3;
double z = 3.45;
char letterA = 'A';         //   Char literal values surrounded by single quotes '
string name = "Fredrik";    // String literal values surrounded by double quotes "
bool isEnabled = true;
```

## Literal values
Ett "hårdkodat" värde som står angivet direkt i koden (till skillnad från ett värde i t.ex en variabel).

**Exempel:** 3, 3.45, 'A', "Fredrik", true

Literal values kan använda sig av suffix för att avgöra typen på det "hårdkodade" värdet:

**Exempel:** 1.0f är float-värde, medan 1.0 är double-värde.

## Data types(datatyper)
Anger vilken typ av data vi lagrar i t.ex en variabel.

- C# är ett **statiskt typat** språk:
 Innan koden kompileras så måste datatypen för varje enskild variabel vara känd.

- C# är ett **starkt typat** språk:
 Om man försöker sätta in data av felaktig typ i en variabel så resulterar det i ett kompileringsfel.
 name = 3; <= Ger ett kompileringsfel

- C# är ett **typsäkert** språk:
 Man kan bara utföra operationer som en given datatyp tillåter

 ## Implicit (underförstått)  & Explicit (uttryckligen) typade variabler.

Explicit typad variabel - Vi har uttryckligen i koden angett att datatype på myInt är 'int'.

int myInt; // Likvärdig med Int32 myInt;  Int32 är namnet på .NET-typen, och int är C-sharps alias för Int32.

// Implicit typad variabel - Med keyword var så avgör kompilatorn datatyp.
var myVariable = 5.2;
myVariable = 5.3;