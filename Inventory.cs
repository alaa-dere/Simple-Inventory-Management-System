namespace InventoryManagement;

class Inventory
{
    private List<Product> _products = new List<Product>();

    public void AddProduct(string name, double price, int quantity)
    {
        _products.Add(new Product(name, price, quantity));
        Console.WriteLine($"\nProduct '{name}' added successfully!");
    }
}