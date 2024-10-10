using System.Diagnostics;

namespace Homework;
internal class Student
{
    private string _name;
    private readonly byte _grade;
    public byte Grade { get { return _grade; } }
    public string Name { get { return _name; } }
    public Student(string name, byte grade)
    {
        _name = name;
        _grade = grade;
    }
}