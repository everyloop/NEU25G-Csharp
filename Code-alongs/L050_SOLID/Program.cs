var dbReader = new DatabaseReader("127.0.0.1", "ShopCartDB");
var fileReader = new FileReader("products.dat");

ShoppingCart cartA = new ShoppingCart(dbReader);
cartA.LoadProducts();
cartA.ShowProducts();

Console.WriteLine();

ShoppingCart cartB = new ShoppingCart(fileReader);
cartB.LoadProducts();
cartB.ShowProducts();

class Product
{
    public Product(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}

class ShoppingCart
{
    private List<Product> products;
    private IReader reader;

    public ShoppingCart(IReader reader)
    {
        this.reader = reader;
    }

    public void ShowProducts()
    {
        products.ForEach(p => Console.WriteLine(p.Name));
    }

    public void LoadProducts()
    {
        //var dbReader = new FileReader(); // New is glue.
        products = reader.LoadProducts();
    }
}

class DatabaseReader : IReader
{
    private string serverName;
    private string databaseName;

    public DatabaseReader(string serverName, string databaseName)
    {
        this.serverName = serverName;
        this.databaseName = databaseName;
    }

    public List<Product> LoadProducts()
    {
        var products = new List<Product>();
        Console.WriteLine($"Loading products from database {databaseName} on server {serverName}");

        // Kod som hämtar produkter från en databas ...
        products = new List<Product>();
        products.Add(new Product("Database product A"));
        products.Add(new Product("Database product B"));

        return products;
    }
}

class FileReader : IReader
{
    private string filepath;

    public FileReader(string filepath)
    {
        this.filepath = filepath;
    }

    public List<Product> LoadProducts()
    {
        var products = new List<Product>();
        Console.WriteLine($"Loading products from '{filepath}'");

        // Kod som hämtar produkter från en databas ...
        products = new List<Product>();
        products.Add(new Product("File product A"));
        products.Add(new Product("File product B"));
        products.Add(new Product("File product C"));

        return products;
    }
}

interface IReader
{
    public List<Product> LoadProducts();
}
