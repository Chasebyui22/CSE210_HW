using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "84101", "USA");
        Customer customer1 = new Customer("Lebron James", address1);

        Product product1 = new Product("Golden Basketball", "P001", 1000.00f, 1);
        Product product2 = new Product("Nike Headband", "P002", 200.00f, 2);
        
        Order order1 = new Order(customer1, new List<Product> { product1, product2 });

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "M5H 2N2", "Canada");
        Customer customer2 = new Customer("Justin Biber", address2);

        Product product3 = new Product("Microphone", "P003", 500.00f, 1);
        Product product4 = new Product("Shampoo", "P004", 100.00f, 1);
        
        Order order2 = new Order(customer2, new List<Product> { product3, product4 });
        
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}