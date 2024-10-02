using System.Collections;

namespace BinaryTreeProject;
public class MyBinaryTree<T> : IEnumerable<T>
    where T : IComparable<T>
{
    public MyBinaryTreeNode<T>? _head;
    private int _count;
    public bool Contains(T item)
    {
        MyBinaryTreeNode<T>? parent;
        return FindWithParent(item, out parent) != null;
    }
    private MyBinaryTreeNode<T> FindWithParent(T value, out MyBinaryTreeNode<T>? parent)
    {
        parent = null;
        MyBinaryTreeNode<T>? current = _head;
        while (current != null)
        {
            int result = current.CompareTo(value);
            if (result > 0)
            {
                parent = current;
                current = current.Left;
            }
            else if (result < 0)
            {
                parent = current;
                current = current.Right;
            }
            else
                break;
        }
        return current;
    }
    public bool Remove(T value)
    {
        MyBinaryTreeNode<T> current, parent;
        current = FindWithParent(value, out parent);
        if (current == null)
            return false;
        _count--;
        if (current.Right == null)
        {
            if (parent.Left == current)
                parent.Left = current.Left;
            else
                parent.Right = current.Left;
        }
        else if (current.Right.Left == null)
        {
        }
        else
            current = null;

        return true;
    }
    public IEnumerator<T> GetEnumerator() => throw new NotImplementedException();
    IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    public override string ToString() => $"{_head.Value}";
}