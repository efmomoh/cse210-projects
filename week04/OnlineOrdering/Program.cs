using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the OnlineOrdering Project.\n");

        // instantiate Address Object => Order 1 (USA) 
        Address address1 = new Address(
            "101 S Center St",
            "Rexburg",
            "RB",
            83460,
            "USA"
        );

        // instantiate Customer object
        Customer customer1 = new Customer("John Reading", address1);

        // declare Order ONE object
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "P101", 3.50, 4));
        order1.AddProduct(new Product("Pen", "P102", 1.25, 10));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");

        // instantiate Customer object => international customer
        Address address2 = new Address(
            "No. 99 Xuefu Road",
            "Huqiu District, Suzhou City, Jiangsu Province",
            "SC",
            215009,
            "P.R. China"
        );

        // declare second customer instance
        Customer customer2 = new Customer("Enssah Fayia Momoh", address2);

        // declare Order two object
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Backpack", "P100", 25.00, 2));
        order2.AddProduct(new Product("Water Bottle", "P200", 10.00, 1));
        order2.AddProduct(new Product("Notebook", "P500", 2.09, 5));

        // display second order details
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}\n");
    }
}