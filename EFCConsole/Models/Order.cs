using System;
using System.Collections.Generic;

namespace EFCConsole.Models;

public partial class Order
{
    public int Orderid { get; set; }

    public int? Custid { get; set; }

    public int Empid { get; set; }

    public DateOnly Orderdate { get; set; }

    public DateOnly Requireddate { get; set; }

    public DateOnly? Shippeddate { get; set; }

    public int Shipperid { get; set; }

    public decimal Freight { get; set; }

    public string Shipname { get; set; } = null!;

    public string Shipaddress { get; set; } = null!;

    public string Shipcity { get; set; } = null!;

    public string? Shipregion { get; set; }

    public string? Shippostalcode { get; set; }

    public string Shipcountry { get; set; } = null!;

    public virtual Customer? Cust { get; set; }

    public virtual Employee1 Emp { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Shipper Shipper { get; set; } = null!;
}
