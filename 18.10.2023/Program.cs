//Ахмет-Гараева и Башарова

using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;
Product product = factory.Create();

Product Product = new Product("red", "gaga");
Tshirt Tshirt = new Tshirt("red", "gaga");
Sneakers Sneakers = new Sneakers("red", "gaga");
Scarf Scarf = new Scarf("red", "gaga");
Hat Hat = new Hat("red", "gaga");
Coat Coat = new Coat("red", "gaga");
Socks Socks = new Socks("red", "gaga");
Dress Dress = new Dress("red", "gaga");
Jacket Jacket = new Jacket("red", "gaga");
Jeans Jeans = new Jeans("red", "gaga");
Skirt Skirt = new Skirt("red", "gaga");


List<Product> products = new List<Product>();
products.Add(Product);
products.Add(Tshirt);
products.Add(Sneakers);

foreach (Product c in products)
{
    string json = JsonConvert.SerializeObject(c);
    Console.WriteLine(json);
}
class Product
{
    public string color;
    public string name;
    public Product(string color, string name)
    {
        this.color = color;
        this.name = name;
        Console.WriteLine("color selected!");
        Console.WriteLine("the name is selected!");
    }

    public int weight;
    public int volume;
    public int price;
    public Product(int weight, int volume, int price)
    {
        this.weight = weight;
        this.volume = volume;
        this.price = price;
        Console.WriteLine("the weight is selected!");
        Console.WriteLine("the volume is selected!");
        Console.WriteLine("the price is selected!");
    }

    public bool fragility;
    public Product(bool fragility)
    {
        this.fragility = fragility;
        Console.WriteLine("the fragility  is selected!");
    }

    public void Done()
    {
        Console.WriteLine("the product is ready!");
    }
}

class Tshirt : Product //1
{
    public string name;
    public Tshirt(string color, string name) : base(color, name)
    {
        Console.WriteLine("Tshirt created!");
    }

    public void Cutout()
    {
        Console.WriteLine("Cutout created");
    }
}

class Sneakers : Product //2
{
    public string name;
    public Sneakers(string color, string name) : base(color, name)
    {
        Console.WriteLine("Sneakers created!");
    }

    public void Platform()
    {
        Console.WriteLine("Platform created");
    }
}

class Scarf : Product //3
{
    public string name;
    public Scarf(string color, string name) : base(color, name)
    {
        Console.WriteLine("Scarf created!");
    }

    public void Length()
    {
        Console.WriteLine("Length created");
    }
}

class Hat : Product //4
{
    public string name;
    public Hat(string color, string name) : base(color, name)
    {
        Console.WriteLine("Hat created!");
    }

    public void Warm()
    {
        Console.WriteLine("Warm hat");
    }
}

class Coat : Product //5
{
    public string name;
    public Coat(string color, string name) : base(color, name)
    {
        Console.WriteLine("Coat created!");
    }

    public void Classic()
    {
        Console.WriteLine("Classic coat");
    }
}

class Socks : Product //6
{
    public string name;
    public Socks(string color, string name) : base(color, name)
    {
        Console.WriteLine("Socks created!");
    }

    public void TwoPieces()
    {
        Console.WriteLine("Two Pieces created");
    }
}

class Jeans : Product //7
{
    public string name;
    public Jeans(string color, string name) : base(color, name)
    {
        Console.WriteLine("Jeans created!");
    }

    public void thin()
    {
        Console.WriteLine("thin jeans");
    }
}

class Skirt : Product //8
{
    public string name;
    public Skirt(string color, string name) : base(color, name)
    {
        Console.WriteLine("Skirt created!");
    }

    public void Straight()
    {
        Console.WriteLine("Straight skirt");
    }
}

class Dress : Product //9
{
    public string name;
    public Dress(string color, string name) : base(color, name)
    {
        Console.WriteLine("Dress created!");
    }

    public void Straight()
    {
        Console.WriteLine("Straight skirt");
    }
}


class Jacket : Product //10
{
    public string name;
    public Jacket(string color, string name) : base(color, name)
    {
        Console.WriteLine("Jacket created!");
    }

    public void Pockets()
    {
        Console.WriteLine("Pockets skirt");
    }
}


public static class ProductFactory
{
    public static Product CreateProduct(string color)
    {
        return new Product(color);
    }

    public static Tshirt CreateTshirt(string color)
    {
        return new Tshirt(color);
    }
}


