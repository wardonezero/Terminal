using System.Collections;

namespace BinaryTreeProject;
public class MyBinaryTree<T> : IEnumerable<T>
    where T : IComparable<T>
{
    private readonly MyBinaryTreeNode<T>? _head;
    private readonly int _count;
    public bool Contains(T item)
    {
        MyBinaryTreeNode<T>? parent;
        return FindWithParent(item, out parent) != null;
    }
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Finds and returns the first node containing the specified value.  If the value
    /// is not found, returns null.  Also returns the parent of the found node (or null)
    /// which is used in Remove.
    /// </summary>
    /// <param name="value">The value to search for</param>
    /// <param name="parent">The parent of the found node (or null)</param>
    /// <returns>The found node (or null)</returns>
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
    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}