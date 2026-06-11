
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
if (!double.TryParse(Console.ReadLine(), out double newPrice))
{
    Console.WriteLine("Invalid price.");
    return;
}
product.Price = newPrice;

Console.Write("New quantity: ");
if (!int.TryParse(Console.ReadLine(), out int newQuantity))
{
    Console.WriteLine("Invalid quantity.");
    return;
}
product.Quantity = newQuantity;

    Console.WriteLine("\nProduct updated successfully!");
}

private Product? FindProduct(string name)
{
    return _products.Find(p => p.Name.ToLower() == name.ToLower());
}

public void DeleteProduct(string name)
{
    Product? product = FindProduct(name);

    if (product == null)
    {
        Console.WriteLine($"\nProduct '{name}' not found.");
        return;
    }

    _products.Remove(product);
    Console.WriteLine($"\nProduct '{name}' deleted successfully!");
}

public void SearchProduct(string name)
{
    Product? product = FindProduct(name);

    if (product == null)
    {
        Console.WriteLine($"\nProduct '{name}' not found.");
        return;
    }

    Console.WriteLine("\n--- Product Found ---");
    Console.WriteLine(product);
}
}