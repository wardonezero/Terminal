namespace MyDataStructure;
public class MyLinkedListNode<T>(T value)
{
    public T Value { get; set; } = value;
    public MyLinkedListNode<T>? Next { get; set; }
}
