
class Inventory
{
    private List<Product> _products = new List<Product>();

    public void AddProduct(string name, double price, int quantity)
    {
        _products.Add(new Product(name, price, quantity));
        Console.WriteLine($"\nProduct '{name}' added successfully!");
    }

    public void ViewProducts()
{
    if (_products.Count == 0)
    {
        Console.WriteLine("\nInventory is empty.");
        return;
    }

    Console.WriteLine("\n--- Inventory List ---");
    foreach (Product product in _products)
        Console.WriteLine(product);
}

    public void EditProduct(string name)
{
    Product? product = FindProduct(name);

    if (product == null)
    {
        Console.WriteLine($"\nProduct '{name}' not found.");
        return;
    }

    Console.Write("New name: ");
    product.Name = Console.ReadLine()!;

    Console.Write("New price: ");
    product.Price = double.Parse(Console.ReadLine()!);

    Console.Write("New quantity: ");
    product.Quantity = int.Parse(Console.ReadLine()!);

    Console.WriteLine("\nProduct updated successfully!");
}

private Product? FindProduct(string name)
{
    return _products.Find(p => p.Name.ToLower() == name.ToLower());
}
}