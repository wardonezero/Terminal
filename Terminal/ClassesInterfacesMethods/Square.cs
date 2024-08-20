using System.Security.Cryptography.X509Certificates;

namespace Terminal;
internal class Square : Shape
{
    private int _side;
    public Square(int n) => _side = n;
    public override int GetArea() => _side * _side;
}