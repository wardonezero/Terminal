namespace Terminal;
internal class Penguin
{
    private readonly int age;
    private readonly double m;
    private readonly string color;
    public Penguin()
    {
        m = 2.4;
        color = "White";
        age = 0;
    }
    public Penguin(double m, string color)
    {
        this.m = m;
        this.color = color;
        age = 0;
    }
    public Penguin(double m, string color, int age)
    {
        this.m = m;
        this.color = color;
        this.age = age;
    }
    public Penguin(Penguin pingvin)
    {
        m = pingvin.m;
        color = pingvin.color;
    }
    static Penguin()
    {

    }
    //private Penguin(double m, string name,int age)
    //{

    //}
}