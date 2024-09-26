using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MyDataStructure;//datastructure
public class MyLinkedList<T> : ICollection<T>
{
    public MyLinkedListNode<T>? Head { get; private set; }
    public MyLinkedListNode<T>? Tail { get; private set; }
    #region ICollection
    public int Count { get; private set; }//done

    public bool IsReadOnly => false;//done

    public void Add(T item) => AddFirst(item);//done

    public void Clear()//done
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    public bool Contains(T item)//done
    {
        MyLinkedListNode<T>? current = Head;
        while (current != null)
        {
            if (current.Value.Equals(item))
                return true;
            current = current.Next;

        }
        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)//done
    {
        MyLinkedListNode<T>? current = Head;
        while (current != null)
        {
            array[arrayIndex] = current.Value;
            current = current.Next;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        MyLinkedListNode<T>? current = Head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<T>)this).GetEnumerator();
    #endregion
    #region Add
    public void AddFirst(T item) => AddFirst(new MyLinkedListNode<T>(item));//done
    private void AddFirst(MyLinkedListNode<T> node)//done
    {
        MyLinkedListNode<T>? temp = Head;
        Head = node;
        Head.Next = temp;
        Count++;
        if (Count == 1)
            Tail = Head;
    }

    public void AddLast(T item) => AddLast(new MyLinkedListNode<T>(item));
    private void AddLast(MyLinkedListNode<T> node)//done
    {
        if (Count == 0) Head = node;
        else Tail.Next = node;
        Tail = node;
        Count++;
    }
    #endregion
    #region Remove
    public void RemoveFirst()//done
    {
        if (Count != 0)
        {
            Head = Head.Next;
            Count--;
        }
        if (Count == 0) Tail = null;
    }
    public void RemoveLast()//done
    {
        if (Count != 0)
        {
            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                MyLinkedListNode<T>? current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }
                Tail = current;
                Tail.Next = null;
            }
            Count--;
        }
    }
    #endregion

    public static void PrintMyList(MyLinkedListNode<T>? node)//done
    {
        Console.Write('[');
        while (node != null)
        {
            Console.Write($" {node.Value} ");
            node = node.Next;
        }
        Console.WriteLine(']');
    }
}
