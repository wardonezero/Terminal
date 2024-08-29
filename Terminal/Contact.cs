using System.Diagnostics;
namespace Terminal;
[DebuggerDisplay("First Name ={FirstName} and Age In Years = {AgeInYears}")]
[DebuggerTypeProxy(typeof(ContactDebugDisplay))]
internal class Contact
{
    public string? FirstName { get; set; }
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public int AgeInYears { get; set; }
}