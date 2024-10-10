namespace Terminal;
[AttributeUsage(AttributeTargets.Class)]
internal class DefaultColorAttribute : Attribute
{
    public ConsoleColor Color { get; set; } = ConsoleColor.Yellow;
}