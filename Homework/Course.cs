using System.Collections;
namespace Homework;
internal class Course : IEnumerable
{
    private Student[] _course;
    public Course(Student[] student)
    {
        _course = student;
    }
    public Course()
    {
        _course = [
            new Student("Edward", 100),
            new Student("Jessica", 40),
            new Student("Michael", 60),
            new Student("Ella", 80),
            new Student("James", 20),
            new Student("Rebecca", 50)
        ];
    }

    public IEnumerator GetEnumerator()
    {
        return new StudentEnumerator(_course);
    }
}