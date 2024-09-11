using System.Diagnostics.CodeAnalysis;
using Terminal;
using static System.Console;
//1
WriteLine("Dude");
Foo foo = new Foo();
//foo.SuspendEvents();
//try
//{
//    WriteLine("Main1");
//}
//finally
//{
//    foo.ResumeEvents();
//}
using (foo.SuspendEvents())
{
    Console.WriteLine("Main Version 2");
}