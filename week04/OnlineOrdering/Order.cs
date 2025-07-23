using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product p in products)
        {
            total += p.GetTotalCost();
        }

        if (customer.LivesInUSA())
        {
            total += 5; // USA shipping
        }
        else
        {
            total += 35; // International shipping
        }

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder(); // Using StringBuilder for efficiency
        foreach (Product p in products)
        {
            label.AppendLine($"Product: {p.GetName()}, ID: {p.GetProductId()}");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Name: {customer.GetName()}\nAddress:\n{customer.GetAddress().GetFullAddress()}";
    }
}
