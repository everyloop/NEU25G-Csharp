// Variables (Variabler) - En behållare för att lagra data (av en given typ).

// I C# måste variabler deklareras innan de kan användas.

int x;
int y = 3;
double z = 3.45;
char letterA = 'A';         //   Char literal values surrounded by single quotes '
string name = "Fredrik";    // String literal values surrounded by double quotes "
bool isEnabled = true;

// Literal values
// t.ex 3, 3.45, 'A', "Fredrik", true


// Data types (datatyper) - Anger vilken typ av data vi lagrar i t.ex en variabel.

// C# är ett statiskt typat språk:
// Innan koden kompileras så måste datatypen för varje enskild variabel vara känd.

// C# är ett starkt typat språk:
// Om man försöker sätta in data av felaktig typ i en variabel så resulterar det i ett kompileringsfel.
// name = 3; <= Ger ett kompileringsfel

// C# är ett typsäkert språk:
// Man kan bara utföra operationer som en given datatyp tillåter
Console.WriteLine(y + 3);
// Console.WriteLine(isEnabled + 3);  <= Otillåten operation mellan bool och int.

byte myByte = 300;
short myShort = 300;
byte myOtherByte = -2;
sbyte mySignedByte = -2;