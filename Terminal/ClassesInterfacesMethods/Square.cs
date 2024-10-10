namespace Terminal;
internal class Square(int n) : Shape
{
    private int _side = n;

    public override int GetArea() => _side * _side;
}