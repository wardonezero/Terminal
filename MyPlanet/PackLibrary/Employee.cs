using static System.Console;
namespace Pack.Shared;
public class Employee : Person
{
    public string? EmployeeCode { get; set; }
    public DateTime HireDate { get; set; }
    public override void WriteToConsole()
    {
        WriteLine($"{name} was born on {DateOfBirth:dd/MM/yy} and hired on {HireDate:dd//MM/yy}");
    }
    public override string ToString()
    {
        return $"{name}'s code is {EmployeeCode}";
    }
}