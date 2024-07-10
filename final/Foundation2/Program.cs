using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        orders.Add(new Order("Maher-shalal-hash-baz", "1234 Bible St.", "Zion", "The New Jerusalem", "The Kingdom of God"));
        orders.Add(new Order("Joe Biden", "1600 Pennsylvania Avenue NW", "Washington", "DC", "USA"));

        orders[0].addItem("The Holy Bible", 2, 10, 30);
        orders[0].addItem("Tribe of Israel", 3, 0, 13);

        orders[1].addItem("Trump to leave", 0, 0, 1);
        orders[1].addItem("Belay that!", 1, 1000000, 300);

        foreach (Order o in orders)
        {
            Console.WriteLine(o.getPackingLabel());
            Console.WriteLine(o.getShippingLabel());
            Console.WriteLine(o.getCost());
        }
    }
}