using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Kolby Lind", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "K101", 49.99, 1));
        order1.AddProduct(new Product("Mouse", "M202", 25.50, 2));
        order1.AddProduct(new Product("Monitor", "MN303", 199.99, 1));

        Address address2 = new Address("55 Queen Street", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Emma Stone", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Desk Lamp", "DL404", 30.00, 2));
        order2.AddProduct(new Product("USB Hub", "UH505", 15.75, 3));
        order2.AddProduct(new Product("Laptop Stand", "LS606", 28.99, 1));

        DisplayOrder(order1);
        Console.WriteLine("----------------------------------------");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");
        Console.WriteLine();
    }
}