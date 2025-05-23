public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUsa()
    {
        if (_country == "Usa")
        {
            return true;
        }
        return false;
    }
    public string displayAddress()
    {
        string address = $"{_streetAddress}, {_city}, {_state}\n{_country}";
        return address;
    }
}