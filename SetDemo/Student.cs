namespace SetDemo;
internal class Student(string name, byte id, Gender gender) : IComparable<Student>
{
    public string Name { get; private set; } = name;
    public byte StudentID { get; private set; } = id;
    public Gender Gender { get; private set; } = gender;

    public int CompareTo(Student other) => StudentID.CompareTo(other.StudentID);
}
public enum Gender
{
    Male,
    Female
}
