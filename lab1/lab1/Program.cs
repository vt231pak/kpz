using System;
using System.Collections.Generic;

public interface IMoney
{
    int Units { get; set; }
    int Cents { get; set; }

    void Display();
}
public class UkrainianHryvnia : IMoney
{
    public int Units { get; set; }
    public int Cents { get; set; }

    public UkrainianHryvnia(int units, int cents)
    {
        Units = units;
        Cents = cents;
    }

    public void Display()
    {
        Console.WriteLine($"{Units}грн {Cents}коп");
    }
}
public class Euro : IMoney
{
    public int Units { get; set; }
    public int Cents { get; set; }

    public Euro(int units, int cents)
    {
        Units = units;
        Cents = cents;
    }

    public void Display()
    {
        Console.WriteLine($"{Units}Є {Cents}ц");
    }
}
public class Dollar : IMoney
{
    public int Units { get; set; }
    public int Cents { get; set; }

    public Dollar(int units, int cents)
    {
        Units = units;
        Cents = cents;
    }

    public void Display()
    {
        Console.WriteLine($"{Units}$ {Cents}ц");
    }
}
public class Product
{
    public string Name { get; set; }
    public IMoney Price { get; set; }

    public Product(string name, IMoney price)
    {
        Name = name;
        Price = price;
    }

    public void DecreasePrice(int amount)
    {
        if (Price is UkrainianHryvnia hryvniaPrice)
        {
            hryvniaPrice.Units -= amount;
        }
        else if (Price is Euro euroPrice)
        {
            euroPrice.Units -= amount;
        }
        else if (Price is Dollar dollarPrice)
        {
            dollarPrice.Units -= amount;
        }
    }
}
public class Warehouse
{
    public string Name { get; set; }
    public string Unit { get; set; }
    public IMoney UnitPrice { get; set; }
    public int Quantity { get; set; }
    public DateTime LastStockDate { get; set; }

    public Warehouse(string name, string unit, IMoney unitPrice, int quantity, DateTime lastStockDate)
    {
        Name = name;
        Unit = unit;
        UnitPrice = unitPrice;
        Quantity = quantity;
        LastStockDate = lastStockDate;
    }
}
public class Reporting
{
    public void RegisterIncoming(Product product, int quantity)
    {
        Console.WriteLine($"Надходження накладна на {quantity} {product.Name}(s)");
    }

    public void RegisterOutgoing(Product product, int quantity)
    {
        Console.WriteLine($"Відвантаження накладна на {quantity} {product.Name}(s)");
    }

    public void InventoryReport(List<Warehouse> warehouses)
    {
        foreach (var warehouse in warehouses)
        {
            Console.WriteLine($"Сховище: {warehouse.Name}, Кількість: {warehouse.Quantity}, Останній день завозу: {warehouse.LastStockDate}");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Euro euroPrice = new Euro(10, 99);
        Product euroProduct = new Product("Книга", euroPrice);

        Console.WriteLine("Початкова ціна продукту в євро:");
        euroProduct.Price.Display();

        euroProduct.DecreasePrice(2);

        Console.WriteLine("Зменшення ціни продукту в євро на 2:");
        euroProduct.Price.Display();

        Dollar dollarPrice = new Dollar(5, 18);
        Product dollarProduct = new Product("Ручка", dollarPrice);

        Console.WriteLine("Початкова ціна продукту в доларах:");
        dollarProduct.Price.Display();

        dollarProduct.DecreasePrice(3);

        Console.WriteLine("Зменшення ціни продукту в доларах на 3:");
        dollarProduct.Price.Display();

        UkrainianHryvnia hryvniaPrice = new UkrainianHryvnia(50, 0);
        Product hryvniaProduct = new Product("Блокнот", hryvniaPrice);

        Console.WriteLine("Початкова ціна продукту в гривнях:");
        hryvniaProduct.Price.Display();

        hryvniaProduct.DecreasePrice(26);

        Console.WriteLine("Зменшення ціни продукту в гривнях на 26:");
        hryvniaProduct.Price.Display();

        Warehouse warehouse = new Warehouse("Склад А", "шт", euroPrice, 70, DateTime.Now);

        Reporting reporting = new Reporting();
        reporting.RegisterIncoming(euroProduct, 50);
        reporting.RegisterOutgoing(euroProduct, 20);

        List<Warehouse> warehouses = new List<Warehouse>();
        warehouses.Add(warehouse);
        reporting.InventoryReport(warehouses);
    }
}