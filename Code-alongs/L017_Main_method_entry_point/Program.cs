
internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Please provide source and destination..");
        }

        string source = args[0];
        string destination = args[1];

        Console.WriteLine("Arguments:");

        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }

        Console.WriteLine();

        int x = 5;


        PrintX();
        PrintY(x);
        PrintHello();

        // Lokal funktion (finns endast i denna metod) kan använda x då den inte är markerad som statisk
        void PrintX()
        {
            Console.WriteLine($"x = {x}");
        }


        // Lokal funktion kan inte använda variabler utifrån om de är markerade som static.
        static void PrintY(int y)
        {
            Console.WriteLine($"y = {y}");
        }
    }

    // Denna metod måste vara statisk om den ska gå att anropa från en annan statisk metod. I detta fall main.
    static void PrintHello()
    {
        Console.WriteLine("Hello");
    }

}
