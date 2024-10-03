using BinaryTreeProject;
using QueueProject;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Terminal;
using HasingProject;
using static System.Console;

string input = "lorem ipsum.123";
string[] result1 = HasingString.FourStringArray(input);
//foreach (string s in result1)
//{
//    WriteLine(s);
//}
int[] result2 = HasingString.GetASCIKey(result1);
foreach (int s in result2)
{
    WriteLine(s);
}