namespace Terminal;
[AttributeUsage(AttributeTargets.Property)]
internal class DisplayAttribute(string lable, ConsoleColor color = ConsoleColor.Yellow) : Attribute
{
    public string Lable { get; } = lable ?? throw new ArgumentNullException(nameof(lable));
    public ConsoleColor Color { get; } = color;
}