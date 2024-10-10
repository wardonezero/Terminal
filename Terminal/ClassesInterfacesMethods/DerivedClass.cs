namespace Terminal;
internal class DerivedClass : BaseClass
{
    public override void AbstractMethod()
    {
        _x++;
        _y++;
    }
    public override int X { get { return _x + 10; } }
    public override int Y { get { return _y + 10; } }
}