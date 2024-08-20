namespace Homework;
internal class Paint
{
    /// <summary>
    /// Paints a triangle
    /// </summary>
    public static void PaintTriangle()
    {
        byte n;//base of triangle
        while (true)
        {
            Console.Write("Enter odd number for triangle base: ");
            if (byte.TryParse(Console.ReadLine(), out n) && n % 2 != 0 && n > 0)
                break;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You must enter odd number!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        int height = (n + 1) / 2;
        DirectionsLRUD D;
        while (true)
        {
            Console.Write("Choose direction Left, Right, Up, or Down: ");
            if (Enum.TryParse(Console.ReadLine(), out D))
            {
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You must enter One of these directions");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t | Left | Right | Up | Down |");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        switch (D)
        {
            case DirectionsLRUD.Left:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Left(height);
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case DirectionsLRUD.Right:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Right(height);
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case DirectionsLRUD.Up:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Up(height, n);
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case DirectionsLRUD.Down:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Down(height, n);
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            default:
                break;
        }
    }
    private static void Left(int height)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (j < height - (i + 1))
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
        for (int i = 0; i < height - 1; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (j <= height - (height - i))
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
    }
    private static void Right(int height)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (j > i)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
        for (int i = 0; i < height - 1; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (j > height - (i + 2))
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
    }
    private static void Up(int height, int n)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (j < height - i || j > height + i)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
    }
    private static void Down(int height, int n)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i > j || j >= n - i)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
    }
    /// <summary>
    ///Paints a chessboard pattern in the console.
    /// </summary>
    public static void PaintChessBoard()
    {
        char[,] board = new char[9, 9];
        for (int i = 0; i <= 8; i++)
        {
            for (int j = 0; j <= 8; j++)
            {
                if (i == 0)
                {
                    board[i, j] = j == 0 ? ' ' : (char)('@' + j);
                }
                else if (j == 0)
                {
                    board[i, j] = (char)('9' - i);
                }
                else if (j > 0 && (i + j) % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    board[i, j] = ' ';
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    board[i, j] = ' ';
                }
                Console.Write($" {board[i, j]} ");
            }
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}