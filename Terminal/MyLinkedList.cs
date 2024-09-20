using System.Collections;

namespace Terminal;//datastructure
class MyLinkedList<T> : ICollection<T>
{
    public MyLinkedListNode<T>? Head { get; private set; }
    public MyLinkedListNode<T>? Tail { get; private set; }
    #region ICollection
    public int Count { get; private set; }

    public bool IsReadOnly => false;

    public void Add(T item)
    {
        AddFirst(item);
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
    #endregion
    #region Add
    public void AddFirst(T item)
    {
        AddFirst(new MyLinkedListNode<T>(item));
    }
    private void AddFirst(MyLinkedListNode<T> node)
    {
        MyLinkedListNode<T>? temp = Head;
        Head = node;
        Head.Next = temp;
        Count++;
        if (Count == 1)
            Tail = Head;
    }

    public void AddLast(T item)
    {
        AddLast(new MyLinkedListNode<T>(item));
    }
    private void AddLast(MyLinkedListNode<T> node)
    {
        MyLinkedListNode<T>? temp = Tail;
        Tail.Next = node.Next;
        Tail = node;
    }
    #endregion
    public static void PrintMyList()
    {
        while (Tail.Next != null)
        {
            Console.WriteLine();
            Tail.Next();
        }
    }
}
