using System.Collections;
namespace Terminal;
internal class ColorEnumerator : IEnumerator
{
    private readonly string[] _colors;
    public int _position = -1;
    public ColorEnumerator(string[] colors)
    {
        _colors = new string[colors.Length];
        for (int i = 0; i < colors.Length; i++)
            _colors[i] = colors[i];
    }

    public object Current
    {
        get
        {
            if (_position == -1)
                throw new InvalidOperationException();
            if (_position >= _colors.Length)
                throw new InvalidOperationException();
            return _colors[_position];
        }
    }

    public bool MoveNext()
    {
        if (_position < _colors.Length - 1)
        {
            _position++;
            return true;
        }
        else
            return false;
    }
    public void Reset()
    {
        _position = -1;
    }
}
