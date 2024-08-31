namespace Terminal;
internal class ContactDebugDisplay(Contact contact)
{
    //private readonly Contact _contact;
    //public ContactDebugDisplay(Contact contact) => _contact = contact;
    public string? Uppername => contact.FirstName.ToUpperInvariant();
    public string AgeInHex => contact.AgeInYears.ToString("X");
}