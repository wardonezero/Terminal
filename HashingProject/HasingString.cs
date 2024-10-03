namespace HasingProject;
public static class HasingString
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
            for (int j = 0; j < s.Length; j++)
            {
                result[i][j] = s[j];
            }
            i++;
        }
        return result;
    }

    public static string[] ConvertToBinary(int[][] input)
    {
        int len;
        string[] result = new string[input.Length];
        return result;
    }

}
