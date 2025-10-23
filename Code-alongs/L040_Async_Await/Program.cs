internal class Program
{
    private static HttpClient client = new HttpClient();
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Program start.");

        Task<int> myTask = Download();

        Console.WriteLine("Main continues ...");

        //for (int i = 0; i < 500; i++)
        //{
        //    await Task.Delay(10);
        //    Console.Write($"{i}, ");
        //}

        try
        {
            int dataLength = await myTask;
            Console.WriteLine($"Got {dataLength} chars of data.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


        Console.WriteLine("Program end.");
    }

    private static async Task<int> Download()
    {
        throw new Exception("Oops!");

        Task<string> download = client.GetStringAsync("http://google.com");

        Console.WriteLine("Download started ...");

        string data = await download;

        Console.WriteLine("Download complete!");

        await Task.Delay(2000);

        Console.WriteLine("Completed unnecessary delay in Download!");

        Console.WriteLine("Start CPU bound operation asynchronously");

        await Task.Run(() =>
        {
            for (int i = 0; i < 2000_000_000; i++) ;
        });

        Console.WriteLine("CPU bound operation ended.");

        return data.Length;
    }
}