namespace HashingProject;
public static class HashingString
{
    public static string[] FourStringArray(string input)
    {
        int len;
        if (input.Length % 4 == 0)
            len = input.Length / 4;
        else
            len = (input.Length / 4) + 1;

        string[] result = new string[len];
        int sum = input.Length % 4;
        for (int i = 0, k = 0; i < len; i++, k += 4)
        {
            if (i < input.Length / 4)
                result[i] = input.Substring(k, 4);
            else
                result[i] = input.Substring(k, sum);
        }
        return result;
    }

    public static int[][] GetASCIKey(string[] input)
    {
        int len = input.Length;
        int[][] result = new int[len][];
        int i = 0;
        foreach (string s in input)
        {
            result[i] = new int[s.Length];
            for (int j = 0; j < s.Length; j++)
            {
                result[i][j] = (int)s[j];
            }
            i++;
        }
        return result;
    }

    public static string[] ConvertToBinary(int[][] input)
    {
        string[] result = new string[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = input[i].Length - 1; j > -1; j--)
            {
                result[i] += Convert.ToString(input[i][j], 2).PadLeft(8, '0');
            }
        }
        return result;
    }

}
