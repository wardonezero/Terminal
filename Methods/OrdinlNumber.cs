namespace Terminal;
internal class OrdinlNumber
{
    /// <summary>
    ///  Prompts the user to enter a range of numbers and generates and prints ordinal numbers.
    /// </summary>
    public static void ToOrdinlNumber()
    {
        Console.Write("Enter range of number: ");
        string range = Console.ReadLine();
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
            switch (i % 100)
            {
                case 11:
                case 12:
                case 13:
                    ordinal = $"{i}th";
                    break;
                default:

                    switch (i % 10)
                    {
                        case 1:
                            ordinal = $"{i}st";
                            break;
                        case 2:
                            ordinal = $"{i}nd";
                            break;
                        case 3:
                            ordinal = $"{i}rd";
                            break;
                        default:
                            ordinal = $"{i}th";
                            break;
                    }
                    break;
            }
            Console.WriteLine(ordinal);
        }
    }
}