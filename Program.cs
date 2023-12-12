// Program.cs

using System;

class Program
{
    static void Main()
    {
        // Create products
        Product product1 = new Product { ProductId = 1, Name = "Laptop", Price = 999.99 };
        Product product2 = new Product { ProductId = 2, Name = "Smartphone", Price = 599.99 };

        // Create customers
        Customer customer1 = new Customer { CustomerId = 101, Name = "Alice" };
        Customer customer2 = new Customer { CustomerId = 102, Name = "Bob" };

        // Create orders
        Order order1 = new Order { OrderId = 1, OrderDate = DateTime.Now, OrderedProduct = product1 };
        Order order2 = new Order { OrderId = 2, OrderDate = DateTime.Now, OrderedProduct = product2 };

        // Associate orders with customers
        customer1.Orders.Add(order1);
        customer2.Orders.Add(order2);

        // Display information
        Console.WriteLine("Product Information:");
        Console.WriteLine(product1);
        Console.WriteLine(product2);

        Console.WriteLine("\nCustomer Information:");
        Console.WriteLine(customer1);
        Console.WriteLine(customer2);

        Console.WriteLine("\nOrder Information:");
        Console.WriteLine(order1);
        Console.WriteLine(order2);
    }
}
