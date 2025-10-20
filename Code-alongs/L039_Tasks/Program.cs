




Task<long> myTask = new Task<long>(() =>
{
    long sum = 0;

	for (int i = 0; i < 1000_000_000; i++)
	{
		sum += i;
	}

	return sum;
});

Console.WriteLine("Starting the task ...");

myTask.ContinueWith(task =>
{
	Console.WriteLine($"Task result: {myTask.Result}");
});

myTask.Start();

Console.WriteLine("Continues executing code ...");

//myTask.Wait();

Console.WriteLine("Task is complete!");






























// Task myTask = Task.Run(TaskOne);

//Task myTask = new Task(() => TaskMethod("Task A"));

//new Task(() => TaskMethod("Task B")).Start();

//Console.WriteLine($"myTask is {myTask.Status}");

//myTask.Start();

//Console.WriteLine($"myTask is {myTask.Status}");

//for (int i = 0; i < 1000; i++)
//{
//    Console.WriteLine($"Main process: {i}");
//}

//Console.WriteLine($"myTask is {myTask.Status}");

//Console.WriteLine("The end!");

//static void TaskMethod(string identifier)
//{
//    for (int i = 0; i < 1000; i++)
//    {
//        Console.WriteLine($"{identifier}: {i}");
//    }
//}