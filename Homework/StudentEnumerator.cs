using System.Collections;
namespace Homework;
internal class StudentEnumerator : IEnumerator
{
    Student[] _students;
    int _position = -1;
    public StudentEnumerator(Student[] students)
    {
        _students = new Student[students.Length];
        _students = students;
    }
    public object Current
    {
        get
        {
            if (_position == -1 || _position >= _students.Length)
                throw new InvalidOperationException();
            return _students[_position].Name;

        }
    }
    public bool MoveNext()
    {
        for (int i = _position + 1; i < _students.Length; i++)
        {
            if (_students[i].Grade >= 80)
            {
                _position = i;
                return true;
            }
        }
        return false;
    }
    public void Reset()
    {
        _position = -1;
    }
}