namespace Homework;
internal class TheCollatz
{
    /// <summary>
    /// Calculates and displays the Collatz sequence for a given positive number.
    /// </summary>
    public static void Collatz()
    {
        Console.Write("Enter positive number: ");
        string positiveNumber = Console.ReadLine();
        if (int.TryParse(positiveNumber, out int PositiveNumber) && PositiveNumber > 0)
        {
            CollatzNumber(PositiveNumber);
        }
        else
        {
            Console.Write("You must enter positive number!");
        }
    }
    /// <summary>
    /// Recursively generates and prints the Collatz sequence for the specified number.
    /// </summary>
    /// <param name="collatzNumber">The input number.</param>
    private static void CollatzNumber(int collatzNumber)
    {
        Console.Write($"{collatzNumber} ");
        if (collatzNumber == 1)
        {
            return;
        }
        else if (collatzNumber % 2 == 0)
        {
            CollatzNumber(collatzNumber / 2);
        }
        else
        {
            CollatzNumber(3 * collatzNumber + 1);
        }
    }
}