using Terminal;
using static System.Console;
//Penguin pingvin1 = new Penguin(2.4, "Yellow");

try
{
    checked
    {
        int x = int.MaxValue - 1;
        WriteLine($"Initial value: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"Affter incrementing: {x}");
        x++;
        WriteLine($"Affter incrementing: {x}");
        x++;
    }
}
catch(OverflowException)
{
    WriteLine($"The code overflowed but I caught the exception");
}