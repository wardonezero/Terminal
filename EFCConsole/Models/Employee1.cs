using System;
using System.Collections.Generic;

namespace EFCConsole.Models;

public partial class Employee1
{
    public int Empid { get; set; }

    public string Lastname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Titleofcourtesy { get; set; } = null!;

    public DateOnly Birthdate { get; set; }

    public DateOnly Hiredate { get; set; }

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string? Region { get; set; }

    public string? Postalcode { get; set; }

    public string Country { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int? Mgrid { get; set; }

    public virtual ICollection<Employee1> InverseMgr { get; set; } = new List<Employee1>();

    public virtual Employee1? Mgr { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
