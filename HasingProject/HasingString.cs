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
            if (i < input.Length/4)
                result[i] = input.Substring(k, 4);
            else
                result[i] = input.Substring(k, sum);
        }
        return result;
    }

}
