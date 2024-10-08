using System.Collections;
namespace SetProject;
public class Set<T> : ICollection<T>
    where T : IComparable<T>
{
    private List<T> _items = [];

    public T GetItem(int index) => _items[index];

    public int Count => _items.Count;

    public bool IsReadOnly => false;

    public void Add(T item)
    {
        foreach (T existingItem in _items)
        {
            if (item.CompareTo(existingItem) == 0)
            {
                throw new InvalidOperationException("An item with the same value already exists.");
            }
        }
            _items.Add(item);
    }

    public void AddRange(Set<T> items)
    {
        foreach (T item in items)
        {
            Add(item);
        }
    }

    public void Clear() => _items.Clear();

    public bool Contains(T item) => _items.Contains(item);

    public void CopyTo(T[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);

    public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();

    public bool Remove(T item) => _items.Remove(item);

    IEnumerator IEnumerable.GetEnumerator() => _items.GetEnumerator();

    public Set<T> Union(Set<T> other)
    {
        Set<T> result = [];
        foreach (T item in _items)
        {
            result.Add(item);
        }
        foreach (T item in other)
        {
            if (!result.Contains(item))
                result.Add(item);
        }
        return result;
    }
    public Set<T> Intersection(Set<T> other)
    {
        Set<T> result = [];
        foreach (T item in _items)
        {
            if (other.Contains(item))
                result.Add(item);
        }
        return result;
    }
    public Set<T> Difference(Set<T> other)
    {
        Set<T> result = [];
        foreach (T item in _items)
        {
            if (!other.Contains(item))
                result.Add(item);
        }
        //foreach (T item in other)
        //{
        //    if (!Contains(item))
        //        result.Add(item);
        //}
        return result;
    }
    public Set<T> SymmetricDifference(Set<T> other)
    {
        Set<T> result = [];
        Set<T> union = Union(other);
        Set<T> intersection = Intersection(other);
        result = union.Difference(intersection);
        return result;
    }

}