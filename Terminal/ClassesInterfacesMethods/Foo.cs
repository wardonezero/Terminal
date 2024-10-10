using static System.Console;
namespace Terminal;
internal class Foo
{
    private int _suspendCount;
    //public void SuspendEvents() => _suspendCount++;
    //public void ResumeEvents() => _suspendCount--;//low codes
    public void FireSomeEvent()
    {
        if (_suspendCount == 0)
            WriteLine(">>> == 0 ");
        WriteLine(">>> =! 0 ");
    }
    //public IDisposable SuspendEvents()
    //{
    //    _suspendCount++;
    //    return new SuspendToken(this);
    //}

    //class SuspendToken(Foo? foo) : IDisposable
    //{
    //    public void Dispose()
    //    {
    //        if (foo != null) 
    //            foo._suspendCount--;
    //        foo = null;
    //    }
    //}
    public IDisposable SuspendEvents()
    {
        _suspendCount++;
        return Disposible.Create(() => _suspendCount--);
    }
}