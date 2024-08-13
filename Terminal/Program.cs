using Terminal;
using static System.Console;
//1
Square object1 = new(24);
WriteLine($"Area of the square is {object1.GetArea()}");
//2
DerivedClass object2 = new DerivedClass();
object2.AbstractMethod();
WriteLine($"X = {object2.X} Y = {object2.Y}");
//3
ImplementationClass object3 = new ImplementationClass();
object3.SampleMethod();
ISampleInterface object4 = new ImplementationClass();
object4.SampleMethod();
ImplementationClassA objectA = new ImplementationClassA();
ImplementationClassB objectB = new ImplementationClassB();
ISampleInterface iOb = objectA;
iOb.SampleMethod();
iOb = objectB;
iOb.SampleMethod();
if (iOb is ISampleInterface)
{
    WriteLine("DoneA");
    WriteLine("DoneB");
}
else
{
    WriteLine("Class a and b do not implement any interface");
}
try
{

}