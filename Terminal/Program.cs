using System.Collections.Generic;
using Terminal;
using static System.Console;
//1
MyLinkedList<int> ints = new();
ints.AddFirst(1);
PrintMyList(ints.Head);
ints.AddLast(200);
PrintMyList(ints.Head);
ints.AddFirst(4);
PrintMyList(ints.Head);
ints.AddLast(2);
PrintMyList(ints.Head);
ints.AddFirst(2);
PrintMyList(ints.Head);
ints.RemoveFirst();
PrintMyList(ints.Head);
ints.RemoveLast();
PrintMyList(ints.Head);
static void PrintMyList(MyLinkedListNode<int> node)//done
{
    Write('[');
    while (node != null)
    {
        Write($" {node.Value} ");
        node = node.Next;
    }
    WriteLine(']');
}