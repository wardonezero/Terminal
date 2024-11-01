using System;
using System.Collections.Generic;

namespace EFCConsole.Models;

public partial class CustOrder
{
    public int? Custid { get; set; }

    public DateOnly? Ordermonth { get; set; }

    public int? Qty { get; set; }
}
