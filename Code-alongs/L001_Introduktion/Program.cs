
// Statement (sats) - fullständig instruktion. Kan sluta på ; alternativ vara ett block { } av flera statements.
Console.WriteLine("This line is a statement");

if (true)
{
    Console.WriteLine("Statement 1");
    Console.WriteLine("Statement 2");
    // ...
}


// Expression (uttryck) - utvärderas till ett värde.
// 5 + 3
// x * 2
// "Hello" + " " + "World"


// Keywords - (Av C#-språket) reserverad ord
// t.ex: if, for, true, while


// Case
// - UPPERCASE
// - lowercase
// - camelCase(förstaOrdetBörjarMedLitenBokstavSedanRestenBörjarPåStor)
// - PascalCase(AllaOrdBörjarPåStorBokstav)
// - snake_case(bara_små_bokstäver_ord_avskiljda_med_underscore) < -Används ej i C#
// - kebab-case (bara_små_bokstäver_ord_avskiljda_med_bindesträck)   <- Används ej i C#

// Språket C# är case sensitive, till skillnad från vissa andra språk som är case insensitve


// Identifiers - Namn som man ger på variabler, funktioner, klasser etc.
// - Kan innehålla bokstäver, nummer och underscore (_), inte övriga tecken eller space.
// - Måste börja med bokstav eller underscore (inte siffra)
// - Man kan inte använda reserverade ord (keywords)
// - variabler och parameterar skrivs i camelCase, alla andra identifiers (t.ex klasser & metoder) använder PascalCase. (enligt konvention)
