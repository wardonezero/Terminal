namespace Homework;
internal class Student
{
    private string _name;
    private readonly byte _grand;
    public byte Grand {  get { return _grand; } }
    public string Name { get { return _name; } }
    public Student(string name, byte grand)
    {
        _name = name;
        _grand = grand;
    }
}