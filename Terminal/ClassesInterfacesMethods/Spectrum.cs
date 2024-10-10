using System.Collections;
namespace Terminal;
internal class Spectrum : IEnumerable
{
    public string[] Colors = ["violet", "blue", "cyan", "green", "yellow", "orange", "red"];
    public IEnumerator GetEnumerator() { return new ColorEnumerator(Colors); }
} 