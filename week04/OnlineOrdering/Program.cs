using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LPT123", 899.99, 1));
        order1.AddProduct(new Product("Mouse", "MSE456", 25.50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}\n");

        // Order 2 - International
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "HP789", 150.00, 1));
        order2.AddProduct(new Product("Microphone", "MC123", 85.75, 1));
        order2.AddProduct(new Product("Webcam", "WC999", 60.00, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}