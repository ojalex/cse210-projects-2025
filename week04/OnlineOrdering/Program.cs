using System;
using System.Collections.Generic;

// Address class
class Address
{
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public bool IsInKenya()
    {
        return country.Trim().ToUpper() == "KE"; //short form for Kenya (KE)
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {stateOrProvince}\n{country}";
    }
}

// Customer class
class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }

    public bool LivesInKenya()
    {
        return address.IsInKenya();
    }
}

// Product class
class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }

    public decimal GetTotalCost()
    {
        return price * quantity;
    }
}

// Order class
class Order
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

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (Product product in products)
        {
            total += product.GetTotalCost();
        }

        total += customer.LivesInKenya() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("40632 Nyamonye", "Siaya", "Nyanza", "KE");
        Address address2 = new Address("50100 Amalemba", "Kakamega", "Western", "KE");

        // Create customers
        Customer customer1 = new Customer("Jackline Otieno", address1);
        Customer customer2 = new Customer("Tom Juma", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Timberland Shoes", "I0001", 42.00m, 4));
        order1.AddProduct(new Product("Denim Jacket", "I0002", 55.50m, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Timberlan Shoes", "I0001", 42.00m, 6));
        order2.AddProduct(new Product("Trouser", "I0003", 38.99m, 4));
        order2.AddProduct(new Product("Socks", "I0004", 13.00m, 10));

        // Display orders
        //order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        //order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}\n");
    }
}
