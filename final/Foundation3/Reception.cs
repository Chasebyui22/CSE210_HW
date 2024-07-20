class Reception : Event
{
    private string _rsvpEmail;
    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
        _type = "Reception";
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: {_type}\nRSVP Email: {_rsvpEmail}";
    }
}