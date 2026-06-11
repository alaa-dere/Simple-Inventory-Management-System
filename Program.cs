
Inventory inventory = new Inventory();

while (true)
{
    Console.WriteLine("\n1. Add a product");
    Console.WriteLine("2. View all products");
    Console.WriteLine("3. Edit a product");
    Console.WriteLine("4. Delete a product");
    Console.WriteLine("5. Search for a product");
    Console.WriteLine("6. Exit");
    Console.Write("Enter your choice: ");

    string choice = Console.ReadLine()!;

    switch (choice)
    {
        case "1":
            Console.Write("Product name: ");
            string name = Console.ReadLine()!;

            Console.Write("Price: ");
            if (!double.TryParse(Console.ReadLine(), out double price))
            {
                Console.WriteLine("Invalid price. Please enter a number.");
                break;
            }
            Console.Write("Quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity))
            {
                Console.WriteLine("Invalid quantity. Please enter a whole number.");
                break;
            }

            inventory.AddProduct(name, price, quantity);
            break;

        case "2":
            inventory.ViewProducts();
            break;
        case "3":
            Console.Write("Enter product name to edit: ");
            inventory.EditProduct(Console.ReadLine()!);
            break;    
        case "4":
            Console.Write("Enter product name to delete: ");
            inventory.DeleteProduct(Console.ReadLine()!);
            break;    
        case "5":
            Console.Write("Enter product name to search: ");
            inventory.SearchProduct(Console.ReadLine()!);
            break;    

        case "6":
            Console.WriteLine("\nGoodbye!");
            Environment.Exit(0);
            break;
    }
}