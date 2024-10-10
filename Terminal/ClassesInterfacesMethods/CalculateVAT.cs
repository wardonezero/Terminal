namespace Terminal;
internal class CalculateVAT
{
    /// <summary>
    /// Calculates the VAT (Value Added Tax) based on the user's input for country ISO A2 code and 
    /// </summary>
    public static void ToCalculateVAT()
    {
        Console.Write("Enter your income: ");
        string? income = Console.ReadLine();
        //decimal Income;
        string? isoA2;
        if (decimal.TryParse(income, out decimal Income))
        {
            Console.Write("Enter county iso A2 code: ");
            isoA2 = Console.ReadLine();
            Console.Write(VatCalculation(isoA2, Income));
        }
        else
        {
            Console.Write("You must enter your income");
        }

    }
    /// <summary>
    /// Calculates the VAT (Value Added Tax) based on the country's ISO A2 code and income.
    /// </summary>
    /// <param name="isoA2">The ISO A2 code of the country.</param>
    /// <param name="income">The income amount.</param>
    /// <returns>A string indicating the calculated tax amount.</returns>
    private static string VatCalculation(string isoA2, decimal income)
    {
        var rate = isoA2 switch
        {
            "AM" => 20.0M,
            "CA" => 15.0M,
            "FR" => 20.0M,
            "DE" => 19.0M,
            "UK" => 14.0M,
            "US" => 11.5M,
            _ => 1.0M,
        };
        decimal tax = (income * rate) / 100;
        return $"You must pay {tax}";
    }
}