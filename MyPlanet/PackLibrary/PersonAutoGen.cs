namespace Pack.Shared;
public partial class Person
{
    public string Origin
    {
        get
        {
            return $"{name} was born on {homePlanet}.";
        }
    }
    public string Greeting => $"{name} says 'Hello'";
    public string Age => $"Her age is {DateTime.Today.Year - DateOfBirth.Year}";
    public string? FavoriteIceCream { get; set; }
    private string favoritePrimaryColor = string.Empty;
    public string FavoritePrimaryColor
    {
        get
        {
            return favoritePrimaryColor;
        }
        set
        {
            favoritePrimaryColor = value.ToLower() switch
            {
                "red" or "green" or "blue" => value,
                _ => throw new ArgumentException($"{value} is not a primary color. Choose from: red, green or blue."),
            };
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