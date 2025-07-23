using System;

class Program
{
    static void Main(string[] args)
    {
        // Address and customer 1
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        // Order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L123", 899.99, 1));
        order1.AddProduct(new Product("Mouse", "M456", 19.99, 2));

        // Address and customer 2
        Address address2 = new Address("45 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Emily Chen", address2);

        // Order 2
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "H789", 59.99, 1));
        order2.AddProduct(new Product("Microphone", "MIC101", 89.99, 1));
        order2.AddProduct(new Product("Webcam", "W202", 74.99, 1));

        // Display order 1
        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalCost());
        Console.WriteLine();

        // Display order 2
        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalCost());
    }
}
