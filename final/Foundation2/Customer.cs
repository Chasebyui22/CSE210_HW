class Customer {
    public string _name;
    public Address _address;

    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }
    public bool LivesInUSA() {
        return _address._country == "USA";
    } 
}