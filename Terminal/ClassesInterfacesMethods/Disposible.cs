namespace Terminal;
internal class Disposible : IDisposable
{
    private Action? _onDispose;
    private Disposible(Action onDispose) => _onDispose = onDispose;
    public static Disposible Create(Action onDispose) => new(onDispose);
    public void Dispose()
    {
        _onDispose?.Invoke();
        _onDispose = null;
    }
}