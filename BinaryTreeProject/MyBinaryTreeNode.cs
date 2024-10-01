namespace BinaryTreeProject;
public class MyBinaryTreeNode<TNode>(TNode value) : IComparable<TNode>
    where TNode : IComparable<TNode>
{
    public TNode Value { get; private set; } = value;
    public MyBinaryTreeNode<TNode>? Left { get; set; }
    public MyBinaryTreeNode<TNode>? Right { get; set; }
    public int CompareTo(TNode? other) => Value.CompareTo(other);
}