
// Console.WriteLine($"Current directory: {Directory.GetCurrentDirectory()}");
// Directory.SetCurrentDirectory(@"c:\");

//var path = @"C:\Users\Fredrik\source\repos\NEU25G-Csharp\Code-alongs\L013_Path_and_Directory\program.cs";

//using (StreamReader reader = new StreamReader(path))
//{
//    // Console.WriteLine(reader.ReadToEnd());

//    while (!reader.EndOfStream)
//    {
//        // Console.WriteLine(reader.ReadLine());
//        Console.Write((char)reader.Read());
//        Thread.Sleep(50);
//    }
//}

using (var writer = new StreamWriter("myFile.txt"))
{
    writer.WriteLine("Hello");
    writer.WriteLine("World");

    for (int i = 65; i < 90; i++)
    {
        writer.Write((char)i);
    }

    writer.WriteLine();
}
