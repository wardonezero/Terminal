using Terminal;
using static System.Console;
//1
Garage carLot = new();
foreach (Car c in carLot)
{
    WriteLine($"Car {c.Name} is going {c.Speed} ");
}
//2
Spectrum colors = new Spectrum();
foreach (var c in colors)
{

    WriteLine($"Color is {c}");
}