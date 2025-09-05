# September 3

**Code-alongs:**  
[L001_Introduktion](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L001_Introduktion/Program.cs)  
[L002_Variabler](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L002_Variabler/Program.cs)  
[L003_Operatorer](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L003_Operatorer/Program.cs)  
[L004_If-satser](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L004_If-satser/Program.cs)  
[L005_Loopar](https://github.com/everyloop/NEU25G-Csharp/blob/master/Code-alongs/L005_Loopar/Program.cs)  


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

- UPPERCASE
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
[Läs mer om variabler här!](https://www.tutorialsteacher.com/csharp/csharp-variable)

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

## Fördefinerade datatyper i C#/.NET
| Alias   | .NET Type            | Description                                         | Range                                                      | Suffix |
|---------|----------------------|-----------------------------------------------------|------------------------------------------------------------|--------|
| byte    | System.Byte          | 8-bit unsigned integer                              | 0 to 255                                                   |        |
| sbyte   | System.SByte         | 8-bit signed integer                                | -128 to 127                                                |        |
| short   | System.Int16         | 16-bit signed integer                               | -32,768 to 32,767                                          |        |
| ushort  | System.UInt16        | 16-bit unsigned integer                             | 0 to 65,535                                                |        |
| int     | System.Int32         | 32-bit signed integer                               | -2,147,483,648 to 2,147,483,647                            |        |
| uint    | System.UInt32        | 32-bit unsigned integer                             | 0 to 4,294,967,295                                         | u      |
| long    | System.Int64         | 64-bit signed integer                               | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807    | l      |
| ulong   | System.UInt64        | 64-bit unsigned integer                             | 0 to 18,446,744,073,709,551,615                            | ul     |
| —       | System.Int128        | 128-bit signed integer                              | -170,141,183,460,469,231,731,687,303,715,884,105,728 to 170,141,183,460,469,231,731,687,303,715,884,105,727 |        |
| —       | System.UInt128       | 128-bit unsigned integer                            | 0 to 340,282,366,920,938,463,463,374,607,431,768,211,455   |        |
| float   | System.Single        | 32-bit single-precision floating point              | approx. -3.402823e38 to 3.402823e38                        | f      |
| double  | System.Double        | 64-bit double-precision floating point              | approx. -1.79769313486232e308 to 1.79769313486232e308      | d      |
| decimal | System.Decimal       | 128-bit decimal (financial/monetary)                | (±)1.0 × 10^-28 to 7.9 × 10^28                             | m      |
| char    | System.Char          | 16-bit single Unicode character                     | Any valid Unicode character (UTF-16 code unit)             |        |
| bool    | System.Boolean       | Logical true/false                                  | True or False                                              |        |
| object  | System.Object        | Base type of all other types                        | —                                                          |        |
| string  | System.String        | A sequence of Unicode characters                    | —                                                          |        |
| —       | System.DateTime      | Represents date and time                            | 0001-01-01 00:00:00 to 9999-12-31 23:59:59.9999999         |        |

[Läs mer om datatyper här!](https://www.tutorialsteacher.com/csharp/csharp-data-types)

 ## Implicit (underförstått)  & Explicit (uttryckligen) typade variabler.

**Explicit typad variabel:** Vi har uttryckligen i koden angett att data typen på myInt är 'int'.

```cs
int myInt; // Likvärdig med Int32 myInt;  Int32 är namnet på .NET-typen, och int är C-sharps alias för Int32.
```

**Implicit typad variabel** - Med keyword var så avgör kompilatorn datatyp.

```cs
// Det är underförstått att myVariable är en double eftersom vi initialiserar med värdet 5.2
var myVariable = 5.2;

// Den är fortfarande statisk typad så följande skulle ge ett kompilatorfel.
myVariable = false;
```

[Läs mer om implicit typade variabler här!](https://www.tutorialsteacher.com/csharp/csharp-var-implicit-typed-local-variable)

## Scope
En variabels "lifetime" - d.v.s var i koden som den är giltig. Det finns tre olika sorters scope:
- Class scope
- Method scope
- **Block scope**

Vi har kollat på block scope som betyder att en variabel är giltig i det block den deklarerats i, och går "out-of-scope" när exekveringen lämnar blocket.

## Operatorer

Operatorer är speciella symboler som används för att uföra en specifika operationer mellan operander.

**Exempel:** Plus operatorn adderar operanderna x och 5.
```cs
y = x + 5;
```

Operander kan delas in i några övergripande kategorier. Vi har kollat på:
- Aritmetiska operatorer (plus, minus, gånger, delat med och modulus). 
- Jämförelse operatorer. (mindre än, större än, lika med, inte lika med).
- Logiska operatorer. (not, and, or)
- Tilldelningsoperator

Vilken ordning operationerna utförs beror på deras precedence. T.ex utförs gånger och delat med, före plus och minus. Detta kan man dock styra genom att använda paranteser.

[Läs mer om operatorer här!](https://www.tutorialsteacher.com/csharp/csharp-operators)

## If-satser, swith-case & ternery operator
Dessa används för att styra flödet i ett program så att olika delar körs beroende på vilka vilkor som är uppfyllda.

[If-statement](https://www.tutorialsteacher.com/csharp/csharp-if-else)  
[Switch statement](https://www.tutorialsteacher.com/csharp/csharp-switch)  
[Ternary operator](https://www.tutorialsteacher.com/csharp/csharp-ternary-operator)

## Loopar
Loopar finns i flera olika former och används för att upprepa delar av koden om och om igen.

Vi kollade på While och Do-While, som är snarlika, med skillnaden att while gör sin utvärdering innan kodblocket körs, medan Do-While gör utvärderingen efter. Detta betyder att en Do-While allt körs minst en gång, medan en While kanske inte körs alls. Båda fortsätter så länge de utvärderas till true.

Se detaljer i länkarna nedan, och kolla gärna även upp for-loop, som vi inte hann kolla på. En for-loop är mer praktisk att använda när man ska räkna över ett förutbestämt antal.

[While loop](https://www.tutorialsteacher.com/csharp/csharp-while-loop)  
[Do-while loop](https://www.tutorialsteacher.com/csharp/csharp-do-while-loop)  
[For loop](https://www.tutorialsteacher.com/csharp/csharp-for-loop)  

### Break
C# keywordet 'break' används för att avsluta en loop.

### Continue
C# keywordet 'break' används för att avbryta den pågående iterationen (varvet) i en loop och fortsätta på nästa.