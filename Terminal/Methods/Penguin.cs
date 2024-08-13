namespace Terminal.Methods;
internal class Penguin
{
    int age = 0;
    double m;
    string color;
    public Penguin()
    {
        m = 2.4;
        color = "White";
    }
    public Penguin(double m, string color)
    {
        this.m = m;
        this.color = color;
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