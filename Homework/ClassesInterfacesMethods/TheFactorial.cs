namespace Homework;
internal class TheFactorial
{
    /// <summary>
    /// Calculates the factorial of a given number.
    /// </summary>
    public static void Factorial()
    {
        Console.Write("Enter number for factorial: ");
        string numberfactorial = Console.ReadLine();
        if (long.TryParse(numberfactorial, out long factorial))
        {
            Console.Write($"Factorial of {factorial} is " + FactorialCount(factorial));
        }
        else
        {
            Console.Write("You must enter number!");
        }

        static long FactorialCount(long Factorial)
        {
            if (Factorial == 0)
            {
                return 1;
            }
            else
            {
                return Factorial * FactorialCount(Factorial - 1);
            }
        }
    }
}