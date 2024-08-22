namespace Homework;
internal static class Deals
{
    public static int HowManyWords(this string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return 0;
        //string[] articles = [" a ", " an ", " the "];
        string[] words = s.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        //int wordsCount = words.Count(word => !articles.Contains($" {word.ToLower()} "));
        //return wordsCount;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == "a" || words[i] == "an" || words[i] == "the") continue;
            words[i] = words[i];
        }
        return words.Length - 1;
    }
}