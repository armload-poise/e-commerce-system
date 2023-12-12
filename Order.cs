// Order.cs

using System;

public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public Product OrderedProduct { get; set; }

    public override string ToString()
    {
        return $"Order ID: {OrderId}, Date: {OrderDate}, Product: {OrderedProduct}";
    }
}
