namespace Terminal;
internal class MultiplicationTable
{
    /// <summary>
    /// Prints the multiplication table for the specified number up to the given limit.
    /// </summary>
    public static void PrintMultiplicationTable()
    {
        Console.Write("Please enter your favorite number: ");
        double number = Convert.ToDouble(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine($"{i} * {number} = {i * number}");
        }
    }
}