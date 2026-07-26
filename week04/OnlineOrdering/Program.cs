using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Chuck Norris Street", "Provo", "UT", "USA");
        Customer customer1 = new Customer("John Deer", address1);
        Order order1 = new Order(customer1);

        Product p1 = new Product("Hatchet", "H310", 29.99, 3);
        Product p2 = new Product("Fire Starter", "F45", 9.99, 5);

        order1.AddProduct(p1);
        order1.AddProduct(p2);

        Console.WriteLine("=============== Order 1 ===============");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateOrderTotal():F2}\n");

        Address address2 = new Address("456 Arnold Way", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Fred Warner", address2);
        Order order2 = new Order(customer2);

        Product p3 = new Product("Hatchet", "H310", 29.99, 3);
        Product p4 = new Product("Fire Starter", "F45", 9.99, 5);

        order2.AddProduct(p3);
        order2.AddProduct(p4);
        order2.AddProduct(p5);

        Console.WriteLine("=============== Order 1 ===============");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateOrderTotal():F2}\n");



    }
}