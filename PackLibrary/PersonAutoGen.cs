namespace Pack.Shared;
public partial class Person
{
    public string origin
    {
        get
        {
            return $"{name} was born on {homePlanet}.";
        }
    }
    public string greeting => $"{name} says 'Hello'";
    public string age => $"Her age is {DateTime.Today.Year - DateOfBirth.Year}";
    public string? favoriteIceCream { get; set; }
    private string favoritePrimaryColor = string.Empty;
    public string FavoritePrimaryColor
    {
        get
        {
            return favoritePrimaryColor;
        }
        set
        {
            switch (value.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                    favoritePrimaryColor = value;
                    break;
                default:
                    throw new ArgumentException($"{value} is not a primary color. Choose from: red, green or blue.");
            }
        }
    }
    public Person this[int index]
    {
        get
        {
            return Children[index];
        }
        set
        {
            Children[index] = value;
        }
    }
}