using System;
using System.Collections.Generic;

namespace EFCConsole.Models;

public partial class EmpOrder
{
    public int Empid { get; set; }

    public DateOnly? Ordermonth { get; set; }

    public int? Qty { get; set; }

    public decimal? Val { get; set; }

    public int? Numorders { get; set; }
}
