using System;
using System.Collections.Generic;

namespace EFCConsole.Models;

public partial class Employee
{
    public int Empid { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public DateOnly Hiredate { get; set; }

    public int? Mgrid { get; set; }

    public string? Ssn { get; set; }

    public decimal Salary { get; set; }
}
