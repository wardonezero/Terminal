//Write a query that returns the maximum value in the orderdate column for each employee.
using EFCConsole.Data;
using EFCConsole.Models;
using Microsoft.EntityFrameworkCore;
using (var context = new Tsqlv4Context())
{
    var ex1 = context.Orders 
        .GroupBy(o => o.Empid).OrderBy(o => o.Key)
        .Select(g => new { Empid = g.Key, MaxOrderDate = g.Max(o => o.Orderdate) }).ToList();
    foreach (var e in ex1)
    {
        Console.WriteLine(e);
    }
}        