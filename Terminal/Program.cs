using System.Runtime.InteropServices;
using Terminal;
using static System.Console;
//int i = 123;
//object o = i;
//try
//{
//    int j = (short)o;
//    Write("Unboxing OK.");
//}
//catch(InvalidCastException e)
//{
//    Write($"{e.Message} Error : Incorrect unboxing");
//}
int x1 = 3;
int y1 = x1;
//x1 = 5;
WriteLine($"x1 = {x1}");
WriteLine($"y1 = {y1}");
GCHandle gchX1 = GCHandle.Alloc(x1, GCHandleType.Pinned);
IntPtr pX1 = gchX1.AddrOfPinnedObject();
WriteLine($"Addres of x1:{pX1.ToString()}");

GCHandle gchY1 = GCHandle.Alloc(y1, GCHandleType.Pinned);
IntPtr pY1 = gchY1.AddrOfPinnedObject();
WriteLine($"Addres of y1:{pY1.ToString()}");

string x2 = "stringValue1";
string y2 = x2;
//x2 = "stringValue2";
WriteLine($"x2 = {x2}");
WriteLine($"y2 = {y2}");
GCHandle gchX2 = GCHandle.Alloc(x2, GCHandleType.Pinned);
IntPtr pX2 = gchX2.AddrOfPinnedObject();
WriteLine($"Addres of x2:{pX2.ToString()}");

GCHandle gchY2 = GCHandle.Alloc(y2, GCHandleType.Pinned);
IntPtr pY2 = gchY2.AddrOfPinnedObject();
WriteLine($"Addres of y2:{pY2.ToString()}");


P x3 = new P { a = "aravot", b = "ereko" };
P y3 = x3;
y3.a = "barev";
WriteLine($"x3 = {x3.a}");
WriteLine($"y3 = {y3.a}");
y3.b = "hajox";
WriteLine($"x3 = {x3.b}");
WriteLine($"y3 = {y3.b}");

GCHandle gchX3a = GCHandle.Alloc(x3.a, GCHandleType.Pinned);
IntPtr pX3a = gchX3a.AddrOfPinnedObject();
WriteLine($"Addres of x3a:{pX3a.ToString()}");
GCHandle gchX3b = GCHandle.Alloc(x3.b, GCHandleType.Pinned);
IntPtr pX3b = gchX3b.AddrOfPinnedObject();
WriteLine($"Addres of x3b:{pX3b.ToString()}");

GCHandle gchY3a = GCHandle.Alloc(y3.a, GCHandleType.Pinned);
IntPtr pY3a = gchY3a.AddrOfPinnedObject();
WriteLine($"Addres of y3a:{pY3a.ToString()}");
GCHandle gchY3b = GCHandle.Alloc(y3.b, GCHandleType.Pinned);
IntPtr pY3b = gchY3b.AddrOfPinnedObject();
WriteLine($"Addres of y3b:{pY3b.ToString()}");