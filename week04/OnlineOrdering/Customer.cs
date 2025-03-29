public class Customer
{
    private string _name;

    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUsa()
    {
        if (_address.IsInUsa())
        {
            return true;
        }
        return false;

    }
    public string getNameAndAddress()
    {
        return $"{_name}\n{_address.displayAddress()}";
    }

}