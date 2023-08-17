using HT_N25.Interfaces;

namespace HT_N25.Models;

public class Monitor:IProduct
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public double Price { get; set; }
    
    public  double DisplaySize { get; set; }
    public  int RefreshRate { get; set; }

    public Monitor(string name, string description, bool isOrdered, double price, double displaySize, int refreshRate)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        IsOrdered = isOrdered;
        Price = price;
        DisplaySize = displaySize;
        RefreshRate = refreshRate;
    }

    public Monitor(Monitor monitor)
    {
        this.Id = monitor.Id;
        this.Name = monitor.Name;
        this.Description = monitor.Description;
        this.IsOrdered = monitor.IsOrdered;
        this.Price = monitor.Price;
        this.DisplaySize = monitor.DisplaySize;
        this.RefreshRate = monitor.RefreshRate;

    }

    public override string ToString()
    {
        return $"{DisplaySize} {RefreshRate} {Name} {Description} {IsOrdered} {Price}";

    }
}