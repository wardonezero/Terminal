using System.Collections;
namespace Terminal;
class MyStack<T> : IEnumerable<T>
{
    private MyLinkedList<T> _list = [];
    public void Push(T item) => _list.AddFirst(item);
    public T Pop()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("The stack is empty");
        T value = _list.Head.Value;
        _list.RemoveFirst();
        return value;
    }
    public void Peek(T item) { }
    public int Count => _list.Count;
    public void Clear() { }
    public IEnumerator<T> GetEnumerator()=>_list.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()=>_list.GetEnumerator();
}
