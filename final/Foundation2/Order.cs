using Microsoft.VisualBasic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _buyer;

    public Order(String name, String sa, String city, String sop, String country)
    {
        _buyer = new Customer(name, sa, city, sop, country);
    }

    public float getCost()
    {
        float total = 0;

        foreach (Product p in _products)
        {
            total += p.getPrice();
        }

        if (_buyer.inUS())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public String getPackingLabel()
    {
        String accum = "";

        for(int i = 0; i < _products.Count(); i ++)
        {
            accum += _products[i].getLabel();

            if (i < _products.Count - 1)
            {
                accum += "\n";
            }
        }

        return accum;
    }

    public String getShippingLabel()
    {
        return $"{_buyer.getName()} {_buyer.getAddr()}";
    }
    
    public void addItem(String name, int id, float price, int quantity)
    {
        _products.Add(new Product(name, id, price, quantity));
    }
}