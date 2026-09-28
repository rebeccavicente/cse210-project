using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address(
            "123 Main Street",
            "Provo",
            "UT",
            "USA"
        );

        Address address2 = new Address(
            "45 Avenida Paulista",
            "São Paulo",
            "SP",
            "Brazil"
        );

        // Create customers
        Customer customer1 = new Customer(
            "John Smith",
            address1
        );

        Customer customer2 = new Customer(
            "Maria Silva",
            address2
        );

        // Create products for order 1
        Product product1 = new Product(
            "Laptop",
            "P001",
            800.00,
            1
        );

        Product product2 = new Product(
            "Wireless Mouse",
            "P002",
            25.00,
            2
        );

        Product product3 = new Product(
            "Keyboard",
            "P003",
            45.00,
            1
        );

        // Create first order
        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Create products for order 2
        Product product4 = new Product(
            "Headphones",
            "P004",
            60.00,
            2
        );

        Product product5 = new Product(
            "USB Cable",
            "P005",
            10.00,
            3
        );

        Product product6 = new Product(
            "Webcam",
            "P006",
            75.00,
            1
        );

        // Create second order
        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // Display Order 1
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine();

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        Console.WriteLine();
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}