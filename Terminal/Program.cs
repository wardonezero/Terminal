using QueueProject;
using System.Collections.Generic;
using Terminal;
using static System.Console;
//1
MyQueue<int> test = new MyQueue<int>();
test.Enqueue(1);
test.Enqueue(2);
test.Enqueue(3);
test.Enqueue(4);
test.Enqueue(5);
WriteLine(test.Peek());
WriteLine(test.Dequeue());