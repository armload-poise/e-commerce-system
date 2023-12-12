// Product.cs

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"Product ID: {ProductId}, Name: {Name}, Price: {Price:C}";
    }
}
