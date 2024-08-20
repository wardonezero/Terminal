namespace Terminal;
internal class Paint
{
    public static void PaintRectangle()
    {
        byte w = 8;
        byte h = 8;
        char[,] board = new char[w, h];
        for (byte i = 0; i < w; i++)
        {
            for (byte j = 0; j < h; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    board[i, j] = '#';
                }
                else
                {
                    board[i, j] = '*';
                }
                Console.Write($"{board[i, j]} ");
            }
            Console.WriteLine();
        }
    }
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

        char[,] triangle = new char[n, n];
        int height = n / 2;

        for (int i = 0; i <= height; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                triangle[i, j] = '*';
                Console.Write(triangle[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = height + 1; i < n; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                triangle[i, j] = '*';
                Console.Write(triangle[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}