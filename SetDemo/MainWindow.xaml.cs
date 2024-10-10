using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SetProject;

namespace SetDemo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    private Set<Student> students = [];
    private Set<Student> _male = [];
    private Set<Student> _female = [];
    private Set<Student> _reading = [];
    private Set<Student> _writing = [];
    private Set<Student> _result = [];

    public MainWindow()
    {
        InitializeComponent();
        LoadStudents();
        SeparateStudents();
    }

    private void LoadStudents()
    {
        students.Add(new Student("Alice", 1, Gender.Female));
        students.Add(new Student("Bob", 2, Gender.Male));
        students.Add(new Student("Carol", 3, Gender.Female));
        students.Add(new Student("Dave", 4, Gender.Male));
        students.Add(new Student("Eve", 5, Gender.Female));
        students.Add(new Student("Frank", 6, Gender.Male));
        students.Add(new Student("Grace", 7, Gender.Female));
        students.Add(new Student("Hank", 8, Gender.Male));
        _writing.Add(students.GetItem(0));
        _writing.Add(students.GetItem(1));
        _writing.Add(students.GetItem(6));
        _writing.Add(students.GetItem(7));
        _reading.Add(students.GetItem(3));
        _reading.Add(students.GetItem(2));
        _reading.Add(students.GetItem(5));
        _reading.Add(students.GetItem(4));
    }

    private void SeparateStudents()
    {
        IEnumerable<Student> male =
            from student in students
            where student.Gender == Gender.Male
            select student;
        foreach (Student student in male)
        {
            _male.Add(student);
        }
        IEnumerable<Student> female =
            from student in students
            where student.Gender == Gender.Female
            select student;
        foreach (Student student in female)
        {
            _female.Add(student);
        }
    }

    private void LeftSet_SelectionChanged(object sender, SelectionChangedEventArgs e) => UpdateList(LeftSet, LeftList);

    private void RightSet_SelectionChanged(object sender, SelectionChangedEventArgs e) => UpdateList(RightSet, RightList);

    private void UpdateList(ComboBox comboBox, ListBox listBox)
    {
        if (comboBox.SelectedItem is ComboBoxItem selectedItem)
        {
            string? selectedSet = selectedItem.Content.ToString();
            Set<Student> filteredStudents = [];
            filteredStudents = selectedSet switch
            {
                "All Students" => students,
                "Female" => _female,
                "Male" => _male,
                "Reading" => _reading,
                "Writing" => _writing,
                _ => _result,
            };
            listBox.Items.Clear();
            foreach (Student student in filteredStudents)
            {
                listBox.Items.Add($"{student.StudentID}. {student.Name}");
            }
        }
    }

    private void Operation_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void Evaluate_Button_Click(object sender, RoutedEventArgs e)
    {
        Set<Student> left = GetSelectedSet(LeftSet);
        Set<Student> right = GetSelectedSet(RightSet);
        Set<Student> result = [];

        if (Operation.SelectedItem is ComboBoxItem selectedOperation)
        {
            string? operation = selectedOperation.Content.ToString();

            result = operation switch
            {
                "Union" => left.Union(right),
                "Intersection" => left.Intersection(right),
                "Difference" => left.Difference(right),
                "Symmetric Difference" => left.SymmetricDifference(right),
                _ => result
            };
        }
        _result = result;
        UpdateList(Operation,ResultList);
    }

    private Set<Student> GetSelectedSet(ComboBox comboBox)
    {
        if (comboBox.SelectedItem is ComboBoxItem selectedItem)
        {
            string? selected = selectedItem.Content.ToString();
            return selected switch
            {
                "Female" => _female,
                "Male" => _male,
                "Reading" => _reading,
                "Writing" => _writing,
                _ => students
            };
        }
        return [];
    }
}