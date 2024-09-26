using System.Collections.Generic;
using Terminal;
using static System.Console;
//1
PostfixCalculator num = new();
num.Postfix();
foreach(var n in num.mystack)
{
    WriteLine(n);
}