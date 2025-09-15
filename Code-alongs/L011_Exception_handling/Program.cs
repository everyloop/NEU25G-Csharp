
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


static void TryCatchExample()
{
    try
    {
        //try
        //{
        //    int x = 0;
        //    int y = 1 / x;
        //    Byte.Parse("hej");
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Parsing went wrong!");
        //}

        //int x = 0;
        //int y = 1 / x;
        Console.WriteLine("Start of try block.");
        int[] myArray = new int[10];
        myArray[15] = 3;
        Console.WriteLine("End of try block.");
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine("Array indexing went wrong!");
        throw;
    }
    //catch (Exception ex)
    //{
    //    Console.WriteLine($"Something went wrong: {ex.Message}");
    //    Console.WriteLine(ex.StackTrace);
    //}
    finally
    {
        //int[] myOtherArray = new int[10];
        //myOtherArray[15] = 3;
        Console.WriteLine("This always runs at the end of try/catch.");
    }

}


Console.WriteLine("Start program!");

try
{
    Console.WriteLine("Before function call.");
    TryCatchExample();
    //int userAge = -50;
    //Console.WriteLine($"IsLegalAge({userAge}) => {IsLegalAge(userAge)}");
    Console.WriteLine("After function call.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("ERROR: Tried to divide by zero.");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Not valid age!");
}
catch (Exception ex)
{
    Console.WriteLine($"Nothing else catched this one: {ex.Message}");
}


 Console.WriteLine("The end!");


static bool IsLegalAge(int age)
{
    if (age < 0)
    {
        throw new ArgumentOutOfRangeException();
    }
    return age >= 18;
}