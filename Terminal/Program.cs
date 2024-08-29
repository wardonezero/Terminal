using Terminal;
using static System.Console;
//1
Contact sarah = new()
{
    FirstName = "Sarah",
    AgeInYears = 42
};
var sarahWriter = new ContactConsoleWriter(sarah);
sarahWriter.Write();