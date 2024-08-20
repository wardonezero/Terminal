namespace Homework;
internal class TheFibonacci
{
    /// <summary>
    /// Calculates and displays the Fibonacci number based on user input.
    /// </summary>
    public static void Fibonacci()
    {
        Console.Write("Enter number: ");
        string? fibonacci = Console.ReadLine();
        if (ulong.TryParse(fibonacci, out ulong Fibonacci))
        {
            Console.Write("Enter 1 or 2: ");
            string oneORtwo = Console.ReadLine();
            Console.Write($"{Fibonacci} fibonacci number is " + oneORtwo == "1" ? FibonacciOne(Fibonacci) : FibonacciTwo(Fibonacci));
        }
        else
        {
            Console.Write("You must enter a number!");
        }
    }
    /// <summary>
    /// Calculates the Fibonacci number using a recursive approach.
    /// </summary>
    /// <param name="FibonacciNumber">The position of the desired Fibonacci number.</param>
    /// <returns>The Fibonacci number at the specified position.</returns>
    private static ulong FibonacciTwo(ulong FibonacciNumber)
    {
        if (FibonacciNumber <= 1)
        {
            return FibonacciNumber;
        }
        else
        {
            return FibonacciTwo(FibonacciNumber - 1) + FibonacciTwo(FibonacciNumber - 2);
        }
    }
    /// <summary>
    /// Calculates the Fibonacci number at a given position using an optimized recursive approach.
    /// </summary>
    /// <param name="FibonacciNumber">The position of the desired Fibonacci number.</param>
    /// <param name="first">The first value in the Fibonacci sequence (optional, default is 0).</param>
    /// <param name="second">The second value in the Fibonacci sequence (optional, default is 1).</param>
    /// <returns>The Fibonacci number at the specified position.</returns>
    private static ulong FibonacciOne(ulong FibonacciNumber, ulong first = 0, ulong second = 1)
    {
        if (FibonacciNumber <= 1)
        {
            return second;
        }
        else
        {
            return FibonacciOne(FibonacciNumber - 1, second, first + second);
        }
    }
}