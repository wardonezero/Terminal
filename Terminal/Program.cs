using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Collections;
using Terminal;
using static System.Console;
//1
MyLinkedList<int> d = [5, 8, 3, 4, 7, 9, 2, 1];
 static void PrintMyList(MyLinkedListNode<T> node)//done
{
    while (node != null)
    {
        Console.WriteLine(node.Value);
        node = node.Next;
    }
}