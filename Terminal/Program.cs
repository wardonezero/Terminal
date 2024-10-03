using BinaryTreeProject;
using QueueProject;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Terminal;
using HashingProject;
using static System.Console;

string input = "lorem ipsum.123";
string[] result1 = HashingString.FourStringArray(input);
//foreach (string s in result1)
//{
//    WriteLine(s);
//}
int[][] result2 = HashingString.GetASCIKey(result1);
string[] result3 = HashingString.ConvertToBinary(result2);
foreach (string s in result3)
{
    WriteLine(s);
}