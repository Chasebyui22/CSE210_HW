class OutdoorGathering : Event
{
    private string _weatherForecast;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
        _type = "Outdoor Gathering";
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: {_type}\nWeather Forecast: {_weatherForecast}";
    }
}