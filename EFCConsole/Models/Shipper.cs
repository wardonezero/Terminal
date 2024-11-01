using System;
using System.Collections.Generic;

namespace EFCConsole.Models;

public partial class Shipper
{
    public int Shipperid { get; set; }

    public string Companyname { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
