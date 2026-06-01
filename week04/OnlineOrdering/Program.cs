using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ONLINE ORDERING SYSTEM =====\n");

            Console.WriteLine("ORDER #1\n");

            Address address1 = new Address("123 Main Street", "Springfield", "IL", "USA");
            Customer customer1 = new Customer("John Smith", address1);

            Order order1 = new Order(customer1);

            Product product1 = new Product("Laptop", "P100", 999.99, 1);
            Product product2 = new Product("Wireless Mouse", "P101", 24.99, 2);
            Product product3 = new Product("USB-C Cable", "P102", 12.99, 3);

            order1.AddProduct(product1);
            order1.AddProduct(product2);
            order1.AddProduct(product3);

            order1.DisplayOrderSummary();

            Console.WriteLine("\nORDER #2\n");

            Address address2 = new Address("456 Queen Street", "Toronto", "ON", "Canada");
            Customer customer2 = new Customer("Maria Garcia", address2);

            Order order2 = new Order(customer2);

            Product product4 = new Product("Smartphone", "P200", 699.99, 1);
            Product product5 = new Product("Phone Case", "P201", 19.99, 2);

            order2.AddProduct(product4);
            order2.AddProduct(product5);

            order2.DisplayOrderSummary();
            Console.WriteLine("\nORDER #3\n");
            Address address3 = new Address("789 Oak Avenue", "Austin", "TX", "United States");
            Customer customer3 = new Customer("Sarah Johnson", address3);

            Order order3 = new Order(customer3);

            Product product6 = new Product("Desk Chair", "P300", 149.99, 1);
            Product product7 = new Product("Monitor Stand", "P301", 34.99, 2);
            Product product8 = new Product("Keyboard", "P302", 59.99, 1);

            order3.AddProduct(product6);
            order3.AddProduct(product7);
            order3.AddProduct(product8);

            order3.DisplayOrderSummary();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}