public class Product
{
    private String _name;
    private int _id;
    private float _price;
    private int _quantity;

    public Product(String name, int id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public float getPrice()
    {
        return _price * _quantity;
    }

    public String getLabel()
    {
        return $"{_name} {_id}";
    }
}