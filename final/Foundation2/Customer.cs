public class Customer
{
    private String _name;
    private Address _address;

    public Customer(String name, String sa, String city, String sop, String country)
    {
        _name = name;
        _address = new Address(sa, city, sop, country);
    }

    public bool inUS()
    {
        return _address.inUS();
    }

    public String getName()
    {
        return _name;
    }

    public String getAddr()
    {
        return _address.getAddrString();
    }
}