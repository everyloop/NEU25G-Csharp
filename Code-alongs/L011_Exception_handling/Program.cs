
// OverflowException: 'Arithmetic operation resulted in an overflow.'
//checked // Utan checked-blocket får vi ingen exception.
//{
//    byte myByte = 200;
//    Console.WriteLine(myByte);
//    myByte += 100;
//    Console.WriteLine(myByte);
//}

// FormatException: 'The input string 'hej' was not in a correct format.'
//Byte.Parse("hej");

// IndexOutOfRangeException: 'Index was outside the bounds of the array.'
//int[] myArray = new int[10];
//myArray[15] = 3;

// DivideByZeroException: 'Attempted to divide by zero.'
//int x = 0;
//int y = 1 / x;


try
{
    //Byte.Parse("hej");
    int x = 0;
    int y = 1 / x;
    Console.WriteLine("Start of try block.");
    int[] myArray = new int[10];
    myArray[15] = 3;
    Console.WriteLine("End of try block.");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Array indexing went wrong!");
}
catch (FormatException ex)
{
    Console.WriteLine("Parsing went wrong!");
}
catch (Exception ex)
{
    Console.WriteLine("Catch all uncatched exceptions.");
}

Console.WriteLine("The end!");
