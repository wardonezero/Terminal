using System;
using System.Collections.Generic;

namespace EFCConsole.Models;

public partial class OrderValue
{
    public int Orderid { get; set; }

    public int? Custid { get; set; }

    public int Empid { get; set; }

    public int Shipperid { get; set; }

    public DateOnly Orderdate { get; set; }

    public DateOnly Requireddate { get; set; }

    public DateOnly? Shippeddate { get; set; }

    public int? Qty { get; set; }

    public decimal? Val { get; set; }
}
