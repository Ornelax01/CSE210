using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Los delfines","Guadalupe","NL","MEXICO");
        Customer customer1 = new Customer("Carlos Ornelas", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop","P100",900,1));
        order1.AddProduct(new Product("Mouse","P200",25,2));

        Address address2 = new Address("456 Del valle","Victoria","TM","MEXICO");
        Customer customer2 = new Customer("Isabel Castillo", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Keyboard","P300",50,1));
        order2.AddProduct(new Product("Monitor","P400",300,1));

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}