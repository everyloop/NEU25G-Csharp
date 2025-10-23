

for (int i = 0; i < 20; i++)
{
    Count();
}

static void Count()
{
    object myLock = new object();

    int count = 0;

    var taskA = Task.Run(DoCount);
    var taskB = Task.Run(DoCount);
    var taskC = Task.Run(DoCount);
    var taskD = Task.Run(DoCount);

    Task.WaitAll(taskA, taskB, taskC, taskD);

    Console.WriteLine(count);

    void DoCount()
    {
        for (int i = 0; i < 10000; i++)
        {
            lock (myLock)
            {
                int temp = count;
                temp = temp + 1;
                count = temp;
            }
        }
    }
}