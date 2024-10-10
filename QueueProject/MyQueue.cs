using MyDataStructure;
using System.Collections;
namespace QueueProject;
public class MyQueue<T> : IEnumerable<T>
{
    MyLinkedList<T> _queue = [];

    public void Enqueue(T item) => _queue.AddLast(item);
    public T Dequeue()
    {
        if (_queue.Count == 0)
            throw new InvalidOperationException("The queue is empty");
        T value = _queue.Head.Value;
        _queue.RemoveFirst();
        return value;
    }

    public T Peek() => _queue.Head.Value;

    public int Count => _queue.Count;
    public void Clear() { }

    public MyLinkedListNode<T>? GetHead() => _queue.Head;

    public IEnumerator<T> GetEnumerator() => _queue.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _queue.GetEnumerator();
}