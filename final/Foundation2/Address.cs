public class Address
{
    private String _streetAddr;
    private String _city;
    private String _stateOrProvince;
    private String _country;

    public Address(String stAddr, String city, String sop, String country)
    {
        _streetAddr = stAddr;
        _city = city;
        _stateOrProvince = sop;
        _country = country;
    }

    public String getAddrString()
    {
        return $"{_streetAddr}\n{_city}, {_stateOrProvince}\n{_country}";
    }

    public bool inUS()
    {
        return _country == "US";
    }
}