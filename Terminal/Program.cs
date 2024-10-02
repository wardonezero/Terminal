using BinaryTreeProject;
using QueueProject;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Terminal;
using HasingProject;
using static System.Console;

string input = "lorem ipsum.123";
string[] result = HasingString.FourStringArray(input);
foreach (string s in result)
{
    WriteLine(s);
}