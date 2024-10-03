using BinaryTreeProject;
using QueueProject;
using Terminal;
using HashingProject;
using static HashingProject.HashingString;
using static System.Console;

string input = "lorem ipsum.012";
string[] result1 = FourStringArray(input);
int[][] result2 = GetASCIKey(result1);
string[] result3 = ConvertToBinary(result2);
string[] result4 = GetStringHash(result3);
foreach (string s in result4)
{
    WriteLine(s);
}
string[] result5 = DecodeGetStringHash(result4);
foreach (string s in result5)
{
    WriteLine(s);
}

int[][] result6 = DecodeConvertToBinary(result5);

for (int i = 0; i < result6.Length; i++)
{
    for (int j = 0; j < result6[i].Length; j++)
    {
        Write(result6[i][j] + "|");
    }
    WriteLine();
}
int tcount = 0;
for (int i = 0;i < result6.Length; i++)
{
        tcount += result6[i].Length;
}
WriteLine(tcount);

string[] result7 = DecodeGetASCIKey(result6);
foreach (string s in result7)
{
    Console.WriteLine(s);
}
string result8 = DecodeFourStringArray(result7);
WriteLine(result8);