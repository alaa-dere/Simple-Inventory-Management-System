using System;
using InventoryManagement;

Inventory inventory = new Inventory();

while (true)
{
    Console.WriteLine("\n--- Main Menu ---");
    Console.WriteLine("1. Add a product");
    Console.WriteLine("6. Exit");
    Console.Write("Enter your choice: ");

    string choice = Console.ReadLine()!;

    switch (choice)
    {
        case "1":
            Console.Write("Product name: ");
            string name = Console.ReadLine()!;

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine()!);

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine()!);

            inventory.AddProduct(name, price, quantity);
            break;

        case "6":
            Console.WriteLine("Exiting... Goodbye!");
            return;
            
        default:
            Console.WriteLine("Invalid choice, try again.");
            break;
    }
}