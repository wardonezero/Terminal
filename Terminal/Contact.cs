using System.Diagnostics;
namespace Terminal;
[DebuggerDisplay("First Name = {FirstName} and Age In Years = {AgeInYears}")]
[DebuggerTypeProxy(typeof(ContactDebugDisplay))]
[DefaultColor(Color = ConsoleColor.Magenta)]
internal class Contact
{
    [Display("FirstName: ", ConsoleColor.Green)]
    public required string? FirstName { get; set; }
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public int AgeInYears { get; set; }
}