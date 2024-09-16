using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Terminal;
using static System.Console;
//1
//2
Thread myThread = new(new ThreadStart(WorkingWithThreads.MyThreadMethod));
//myThread.IsBackground = false;
myThread.Start();
//myThread.Join();
WriteLine("Hello from main thread");