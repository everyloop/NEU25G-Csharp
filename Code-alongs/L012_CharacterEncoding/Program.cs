

char myChar = '\u0578';

Console.WriteLine(myChar);
Console.WriteLine((int)myChar);

Console.WriteLine();

for (int i = 65; i <= 90; i++)
{
    Console.Write((char)i);
}

Console.WriteLine();

string myString = "Hello❤️";
Console.WriteLine(myString.Length);
Console.WriteLine();

for (int i = 0; i < myString.Length; i++)
{
    Console.WriteLine($"{(int)myString[i]} - {myString[i]} - {char.IsHighSurrogate(myString, i)}");
}
