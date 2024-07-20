class Address {
    private string _street;
    private string _city;
    private string _state;
    private string _zip;
    public string _country;
    public string GetfullAddress() 
    {
        return $"{_street}, {_city}, {_state}, {_zip}, {_country}\n";
    }
    public Address(string street, string city, string state, string zip, string country) {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;
    }
}