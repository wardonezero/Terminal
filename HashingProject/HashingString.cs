using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

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
            for (int j = input[i].Length - 1; j >= 0; j--)
            {
                result[i] += Convert.ToString(input[i][j], 2).PadLeft(8, '0');
            }
        }
        return result;
    }
    public static string[] GetStringHash(string[] input)
    {
        string[] result = new string[input.Length];
        int i = 0;
        foreach (string s in input)
        {
            result[i] = Convert.ToInt32(s, 2).ToString();
            i++;
        }
        return result;
    }

    public static string[] DecodeGetStringHash(string[] output)
    {
        string[] result = new string[output.Length];
        int i = 0;
        foreach (string s in output)
        {
            result[i] = Convert.ToString(Convert.ToInt32(s), 2).PadLeft(32, '0');
            result[i] = result[i].Replace("00000000", "");
            i++;
        }

        return result;
    }

    public static int[][] DecodeConvertToBinary(string[] output)
    {
        int[][] result = new int[output.Length][];
        for (int i = 0; i < output.Length; i++)
        {
            result[i] = new int[output[i].Length / 8];
            for (int j = 0, k = output[i].Length - 8; j < result[i].Length; j++, k -= 8)
            {
                result[i][j] = Convert.ToInt32(output[i].Substring(k, 8), 2);
            }
        }

        return result;
    }

    public static string[] DecodeGetASCIKey(int[][] output)
    {
        string[] result = new string[output.Length];
        for (int i = 0; i < output.Length; i++)
        {
            for (int j = 0; j < output[i].Length; j++)
            {
                result[i] += (char)output[i][j];
            }
        }

        return result;
    }

    public static string DecodeFourStringArray(string[] output)
    {
        string result = string.Empty;

        for (int i = 0; i < output.Length; i++)
        {
            result += output[i];
        }
        return result;
    }
}
