namespace Terminal;
internal struct WorkingWithThreads
{
    public static void MyThreadMethod()
    {
        //Console.WriteLine("Hello from my custom thread");
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"\t\t\t\t\t\t\t\tThis is the MY thread {i}");
        }
        //Console.WriteLine();
        //Console.WriteLine("Bye from my custom thread");
    }
}