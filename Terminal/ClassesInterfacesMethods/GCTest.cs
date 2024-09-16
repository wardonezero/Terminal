namespace Terminal;
//DON'T USE THES
internal class GCTest
{
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (disposing) { }
    }
    ~GCTest() => Dispose(false);
}