using System;
using System.Collections;
using System.Collections.Generic;

interface IProductInfo
{
    void DisplayInfo();
}

interface IProductType : IProductInfo
{
    bool MatchesType(string type);
}

class Product : IProductType
{
    protected string name;
    protected double price;
    protected string manufacturer;
    protected int ageRange;

    public Product(string name, double price, string manufacturer, int ageRange)
    {
        this.name = name;
        this.price = price;
        this.manufacturer = manufacturer;
        this.ageRange = ageRange;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Товар: {name}");
        Console.WriteLine($"Ціна: {price}");
        Console.WriteLine($"Виробник: {manufacturer}");
        Console.WriteLine($"Вік, на який розрахований: {ageRange}");
    }

    public virtual bool MatchesType(string type)
    {
        return false;
    }
}

class Toy : Product
{
    protected string material;

    public Toy(string name, double price, string manufacturer, string material, int ageRange) 
        : base(name, price, manufacturer, ageRange)
    {
        this.material = material;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Матеріал: {material}");
    }

    public override bool MatchesType(string type)
    {
        return type.ToLower() == "toy";
    }
}

class Book : Product
{
    protected string author;
    protected string publisher;

    public Book(string name, double price, string author, string publisher, int ageRange) 
        : base(name, price, "", ageRange) // Опущено виробника
    {
        this.author = author;
        this.publisher = publisher;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Автор: {author}");
        Console.WriteLine($"Видавництво: {publisher}");
    }

    public override bool MatchesType(string type)
    {
        return type.ToLower() == "book";
    }
}

class SportsEquipment : Product
{
    public SportsEquipment(string name, double price, string manufacturer, int ageRange) 
        : base(name, price, manufacturer, ageRange)
    {
    }

    public override bool MatchesType(string type)
    {
        return type.ToLower() == "sportsequipment";
    }
}

class ProductCollection : IEnumerable<Product>
{
    private List<Product> products = new List<Product>();

    public void Add(Product product)
    {
        products.Add(product);
    }

    public IEnumerator<Product> GetEnumerator()
    {
        return products.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

