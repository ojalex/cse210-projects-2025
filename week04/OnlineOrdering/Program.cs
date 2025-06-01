using System;
using System.Collections.Generic;
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
