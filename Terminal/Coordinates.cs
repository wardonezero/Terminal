using static System.Console;
namespace Terminal;
internal struct Coordinates
{
    private int _column;
    private int _row;
    public int column
    {
        get { return _column; }
        set
        {
            
        }
    }
    public int row
    {
        get { return _row; }
        set
        {
            
        }
    }
    public Coordinates()
    {
        IsLetter();
        IsNumber();
    }
    private int IsLetter()
    {
        while (true)
        {
            if (char.TryParse(ReadKey().KeyChar.ToString(), out char letter) && letter >= 'a' && letter <= 'h')
            {
                _column = letter - 'a' + 1;
                break;
            }
            else
            {
                //Console
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\nError 3.1: Wrong coordinate.( a - b)");
                ForegroundColor = ConsoleColor.Gray;
                Write("Enter coordinates: ");
            }
        }
        return _column;
    }
    private int IsNumber()
    {
        while (true)
        {
            if (char.TryParse(ReadKey().KeyChar.ToString(), out char number) && number >= '1' && number <= '8')
            {
                _row = number - '1' + 1;
                break;
            }
            else
            {
                //Console
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\nError 3.2: Wrong coordinate.( 1 - 8 )");
                ForegroundColor = ConsoleColor.Gray;
                Write("Enter coordinates: ");
            }
        }
        return _row;
    }
}