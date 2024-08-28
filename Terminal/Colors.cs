using System.Collections;
namespace Terminal;
internal class Colors : IEnumerable
{
    public readonly string[] colors = ["RED", "GREEN", "BLUE", "YELLOW"];
    public IEnumerator GetEnumerator() { return new ColorEnumerator(colors); }
}