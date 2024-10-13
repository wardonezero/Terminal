using static System.Console;
namespace Pack.Shared;
public partial class Person : object
{
    public string name = "";
    public DateOnly DateOfBirth;
    public WonderOfTheAnciantWorld FavoriteAncientWonder;
    public WonderOfTheAnciantWorld BucketList;
    public List<Person> Children = [];
    public const string Species = "Homo Sapien";
    public readonly string homePlanet = "Earth";
    public readonly DateTime Instantiated;
    public Person()
    {
        name = "Unknown";
        Instantiated = DateTime.Now;
    }
    public Person(string initialName, string homePlanet)
    {
        name = initialName;
        this.homePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }
    public virtual void WriteToConsole()
    {
        WriteLine($"{name} was born on a {DateOfBirth:dddd}.");
    }
}