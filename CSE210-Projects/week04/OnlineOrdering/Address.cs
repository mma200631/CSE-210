public class Address
{
    private string _street;
    private string _state;
    private string _city;
    private string _country;

    public Address(string street, string state, string city, string country)
    {
        _street=street;
        _state=state;
        _city=city;
        _country=country;
    }

    public bool IsInUsa()
    {
        return _country.ToLower()=="usa";
    }  

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

}