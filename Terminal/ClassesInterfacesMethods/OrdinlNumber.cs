namespace Terminal;
internal class OrdinlNumber
{
    /// <summary>
    ///  Prompts the user to enter a range of numbers and generates and prints ordinal numbers.
    /// </summary>
    public static void ToOrdinlNumber()
    {
        Console.Write("Enter range of number: ");
        string? range = Console.ReadLine();
        if (int.TryParse(range, out int cardinal) && cardinal >= 1)
        {
            GetOrdinalNumber(cardinal);
        }
        else
        {
            Console.WriteLine("You must enter positive number!");
        }
    }
    /// <summary>
    /// Generates and prints ordinal numbers based on the input cardinal number.
    /// </summary>
    /// <param name="cardinal">The cardinal number up to which to generate ordinal numbers.</param>
    private static void GetOrdinalNumber(int cardinal)
    {
        string ordinal;

        for (int i = 1; i <= cardinal; i++)
        {
            ordinal = (i % 100) switch
            {
                11 or 12 or 13 => $"{i}th",
                _ => (i % 10) switch
                {
                    1 => $"{i}st",
                    2 => $"{i}nd",
                    3 => $"{i}rd",
                    _ => $"{i}th",
                },
            };
            Console.WriteLine(ordinal);
        }
    }
}