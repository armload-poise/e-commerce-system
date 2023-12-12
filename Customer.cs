// Customer.cs

using System.Collections.Generic;

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public List<Order> Orders { get; set; }

    public Customer()
    {
        Orders = new List<Order>();
    }

    public override string ToString()
    {
        return $"Customer ID: {CustomerId}, Name: {Name}, Orders: {Orders.Count}";
    }
}
