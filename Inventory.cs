
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
}