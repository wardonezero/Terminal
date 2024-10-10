using System.Diagnostics;
using System.Reflection;
using System.Text;
using static System.Console;
namespace Terminal;
internal class ContactConsoleWriter(Contact contact)
{
    //private readonly Contact _contact;
    //public ContactConsoleWriter(Contact contact) => _contact = contact;
    private ConsoleColor _color;
    [Obsolete("This will be removed in version 2", false)]
    public void Write()
    {
        OutputDebugInfo();
        OutputExtraInfo();
        UseDefaultColor();
        WriteFirstName();
        WriteAge();
    }
    private void WriteFirstName()
    {
        //WriteLine(contact.FirstName);
        PropertyInfo firstnameProperty = typeof(Contact).GetProperty(nameof(Contact.FirstName))!;
        var firstNamedisplayAttribute = (DisplayAttribute?)Attribute.GetCustomAttribute(firstnameProperty, typeof(DisplayAttribute));
        PreserveForegroundColor();
        var sb = new StringBuilder();
        if (firstNamedisplayAttribute != null)
        {
            ForegroundColor = firstNamedisplayAttribute.Color;
            sb.Append(firstNamedisplayAttribute.Lable);
        }
        sb.Append(contact.FirstName);
        WriteLine(sb);
        RestoreForegroundColor();
    }
    private void WriteAge()
    {
        WriteLine(contact.AgeInYears);
    }
    private static void UseDefaultColor()
    {
        var defaultColorAttribute = (DefaultColorAttribute?)Attribute.GetCustomAttribute(typeof(Contact), typeof(DefaultColorAttribute));
        if (defaultColorAttribute != null)
            ForegroundColor = defaultColorAttribute.Color;
    }
    private void PreserveForegroundColor() { _color = ForegroundColor; }
    private void RestoreForegroundColor() { ForegroundColor = _color; }
    //Attribute
    [Conditional("DEBUG")]
    private static void OutputDebugInfo() => WriteLine("****DEBUG MODE****");
    [Conditional("EXTRA")]
    private static void OutputExtraInfo() => WriteLine("****EXTRA INFO****");
}