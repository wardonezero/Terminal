namespace Terminal;
internal static class Deals
{
    public static string CarColor(this Car car)
    {
        string carColor = "Black";
        return carColor;
    }
    public static bool IsPaliandrom(this string ch)
    {
        int end = ch.Length - 1;
        int count = 0;
        for (int i = 0; i < ch.Length / 2; i++)
        {
            if (ch[i] == ch[end - i])
                count++;

        }
        if (count != ch.Length / 2)
            return false;
        return true;
        //int left = 0, right = ch.Length - 1;
        //while (left < right)
        //{
        //    while (left < right && !char.IsLetterOrDigit(ch[left]))
        //    {
        //        left++;
        //    }
        //    while (left < right && !char.IsLetterOrDigit(ch[right]))
        //    {
        //        right--;
        //    }
        //    if (char.ToLower(ch[left]) != char.ToLower(ch[right]))
        //        return false;
        //    left++;
        //    right--;
        //}
        //return true;
    }
    public static bool IsPrime(this int sn)
    {
        if (sn <= 1) return false;
        if (sn >= 2 && sn <= 3) return true;
        if (sn % 2 == 0 || sn % 3 == 0) return false;
        for (int i = 3; i * i <= sn; i += 2)
        {
            if (sn % i == 0) return false;
        }
        return true;
    }
}