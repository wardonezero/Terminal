using Terminal;
using static System.Console;
//1
//Car car = new();
//string color = car.CarColor();
//WriteLine(color);
//WriteLine(car.CarColor());
////2
//string ch = "aabdbaa";
//WriteLine(ch.IsPaliandrom());
//3
int sn = 0;
while (true)
{
    WriteLine($"{sn} = {sn.IsPrime()} ");
    sn++;
    if (sn == 1000) break;
}