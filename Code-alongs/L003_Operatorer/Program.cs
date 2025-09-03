
// Operatorer är special tecken i C# som används för att utföra en operation på (oftast) två operander.

// Aritmetiska operationer (räkneoperationer):

Console.WriteLine("\nAritmetiska operationer:");
Console.WriteLine(5 + 3);
Console.WriteLine(5 - 3);
Console.WriteLine(5 * 3);
Console.WriteLine(5 / 3);

// Delar man två heltal så får man hur många gånger nämnaren går i täljaren, samt en rest man får ut med %

Console.WriteLine("\nDivision med heltal och flyttal:");
Console.WriteLine(9 / 2);
Console.WriteLine(9 % 2); // Modulus (Remainder, Rest)
Console.WriteLine(9.0 / 2);
Console.WriteLine(9 / 2.0);
Console.WriteLine(9.0 / 2.0);

Console.WriteLine("\nTilldelningsoperator");

int myInt = 5;  // <= Tilldelningsoperator (Assignment) ett enkelt likamedtecken (=) 
Console.WriteLine(5);


// Jämförelseoperatorer (Comparisson)

Console.WriteLine("\nJämförelseoperatorer");
Console.WriteLine(myInt == 5);  // Jämföra om två värden är exakt lika, dubbla likamedtecken (==)
Console.WriteLine(myInt != 5);  // Inte lika med.
Console.WriteLine(myInt > 5);   // Större än
Console.WriteLine(myInt < 5);   // Mindre än
Console.WriteLine(myInt >= 5);   // Större än eller lika med
Console.WriteLine(myInt <= 5);   // Mindre än eller lika med


// Logiska operationer (Logical operators)
Console.WriteLine("\nNOT: !)");
Console.WriteLine(!true);
Console.WriteLine(!false);

Console.WriteLine("\nAND: &&");
Console.WriteLine(false && false);
Console.WriteLine(true && false);
Console.WriteLine(false && true);
Console.WriteLine(true && true);

Console.WriteLine("\nOR: ||");
Console.WriteLine(false || false);
Console.WriteLine(true || false);
Console.WriteLine(false || true);
Console.WriteLine(true || true);

Console.WriteLine("\nFlera operatorer kan kombineras till längre uttryck:");
Console.WriteLine((myInt > 2) && (myInt < 7));
Console.WriteLine((5 > 2) && (10 < 7));
Console.WriteLine((5 > 2) || (10 < 7));
Console.WriteLine((1 != 0) && (true));

Console.WriteLine("\n+=, -=, *=, /=, %=, ++, --");
int x = 10;
Console.WriteLine(x);
x = x + 5;
Console.WriteLine(x);
x += 5;
Console.WriteLine(x);
x *= 5;
Console.WriteLine(x);
x++;
Console.WriteLine(x);
x--;
Console.WriteLine(x);
--x;
Console.WriteLine(x);

Console.WriteLine("\n ++y ökar y med 1 INNAN den skickas som argument till en metod.");
int y = 10;
Console.WriteLine(y);
Console.WriteLine(++y);
Console.WriteLine(y);

Console.WriteLine("\n z++ ökar z med 1 EFTER den skickats som argument till en metod."); int z = 10;
Console.WriteLine(z);
Console.WriteLine(z++);
Console.WriteLine(z);
