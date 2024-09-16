namespace Homework;
internal struct WorkingWithThreads
{
    public static void MyThreadMethod(int b)
    {
        int start; int end;
        string space = "";

        if (b == 1)
        {
            start = 0;
            end = 1_000;
        }
        else
        {
            start = ((b - 1) * 1_000) + 1;
            end = b * 1_000;
            for (int i = 1; i < b; i++)
            {
                space += "                   ";
            }
        }
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine($"{space}thread {b}: {i}");
            //Thread.Sleep(50);
        }
    }
}