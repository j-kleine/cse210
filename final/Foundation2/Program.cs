using System;

class Program
{
    static void Main()
    {
// ---- Create customer1 address -------------------------------------------------------------------
        Address customer1Address = new Address("123 Main St", "Cityville", "CA", "USA");

        // Create customer
        Customer customer1 = new Customer("John Doe", customer1Address);

        // Create order
        Order order1 = new Order(customer1);

        // Create products
        Product product1_1 = new Product("Apple", "1234", 0.99m, 5);
        Product product1_2 = new Product("Banana", "516", 1.39m, 2);

        // Add products to order
        order1.AddProduct(product1_1);
        order1.AddProduct(product1_2);

        // Calculate total price
        decimal totalPrice1 = order1.CalculateTotalPrice();

        // Get packing label
        string packingLabel1 = order1.GetPackingLabel();

        // Get shipping label
        string shippingLabel1 = order1.GetShippingLabel();

        // Display the results
        Console.Clear();
        Console.WriteLine("********************************");
        Console.WriteLine("******** Order Details: ********");
        Console.WriteLine("********************************");
        Console.WriteLine(packingLabel1);
        Console.WriteLine($"Total Price: {totalPrice1} $\n");
        Console.WriteLine("--------------------------------\n");
        Console.WriteLine(shippingLabel1);
        Console.WriteLine();

// ---- Create customer2 address -------------------------------------------------------------------
        Address customer2Address = new Address("Musterstrasse 45", "Neustadt", "SH", "GER");

        // Create customer
        Customer customer2 = new Customer("Max Mustermann", customer2Address);

        // Create order
        Order order2 = new Order(customer2);

        // Create products
        Product product2_1 = new Product("Pineapple", "276418", 2.01m, 2);
        Product product2_2 = new Product("Pear", "2419", 1.09m, 3);
        Product product2_3 = new Product("Cherry", "101141213", 0.49m, 20);

        // Add products to order
        order2.AddProduct(product2_1);
        order2.AddProduct(product2_2);
        order2.AddProduct(product2_3);

        // Calculate total price
        decimal totalPrice2 = order2.CalculateTotalPrice();

        // Get packing label
        string packingLabel2 = order2.GetPackingLabel();

        // Get shipping label
        string shippingLabel2 = order2.GetShippingLabel();

        // Display the results
        Console.WriteLine("********************************");
        Console.WriteLine("******** Order Details: ********");
        Console.WriteLine("********************************");
        Console.WriteLine(packingLabel2);
        Console.WriteLine($"Total Price: {totalPrice2} $\n");
        Console.WriteLine("--------------------------------\n");
        Console.WriteLine(shippingLabel2);
        Console.WriteLine();
    }
}
