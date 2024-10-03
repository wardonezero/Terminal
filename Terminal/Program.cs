using BinaryTreeProject;
using QueueProject;
using Terminal;
using HashingProject;
using static HashingProject.HashingString;
using static System.Console;

string input = "lorem ipsum.123";
string[] result1 = FourStringArray(input);
int[][] result2 = GetASCIKey(result1);
string[] result3 = ConvertToBinary(result2);
string[] result4 = GetStringHash(result3);
foreach (string s in result4)
{
    WriteLine(s);
}