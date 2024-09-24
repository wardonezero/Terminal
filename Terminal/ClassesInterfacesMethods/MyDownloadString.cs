using System.Diagnostics;
using System.Net;
namespace Terminal;
internal class MyDownloadString
{
        readonly Stopwatch sw = new();
        public void DoRun()
        {
        const int LargeNumber = 6_000_000;
        sw.Start();
        Task<int> t1 = CountCharactersAsync(1, "https://github.com/wardonezero/Chess");
        Task<int> t2 = CountCharactersAsync(2, "https://github.com/wardonezero");
        CountToALargeNumber(1, LargeNumber);
        CountToALargeNumber(2, LargeNumber);
        CountToALargeNumber(3, LargeNumber);
        CountToALargeNumber(4, LargeNumber);
        Console.WriteLine($"Chars in https://github.com/wardonezero/Chess : {t1.Result}");
        Console.WriteLine($"Chars in https://github.com/wardonezero : {t2.Result}");

    }
    //private int CountCharacters(int id , string uriString)
    private async Task<int> CountCharactersAsync(int id, string uriString)
    {
        WebClient wc1 = new();
        Console.WriteLine($"Starting call {id} : {sw.Elapsed.TotalMilliseconds, 4:N0}ms");
        //string result = wc1.DownloadString(new Uri (uriString) );
        string result = await wc1.DownloadStringTaskAsync(new Uri(uriString));
        Console.WriteLine($"Call {id} completed : {sw.Elapsed.TotalMilliseconds, 4:N0}ms");
        return result.Length;
    }
    private void CountToALargeNumber(int id, int value)
    {
        for (long i = 0; i < value; i++) ;
            Console.WriteLine($"End counting {id} : {sw.Elapsed.TotalMilliseconds, 4:N0}ms");
    }
}