namespace Terminal;
//DON'T USE THES
internal stru GCTest
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