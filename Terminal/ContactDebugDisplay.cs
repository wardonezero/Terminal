namespace Terminal
{
    internal class ContactDebugDisplay
    {
        private readonly Contact _contact;
        public ContactDebugDisplay(Contact contact) => _contact = contact;
        public string? Uppername => _contact.FirstName.ToUpperInvariant();
        public string AgeInHex => _contact.AgeInYears.ToString("X");
    }
}