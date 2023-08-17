using HT_N25.Interfaces;

namespace HT_N25.Models;

public class Laptop:IProduct
{
    public string CpuBrand { get; set; }
    public string CpuModel { get; set; }
    
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public double Price { get; set; }

    public Laptop(string cpuBrand, string cpuModel, string name, string description, bool isOrdered, double price)
    {
        CpuBrand = cpuBrand;
        CpuModel = cpuModel;
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        IsOrdered = isOrdered;
        Price = price;
    }

    public Laptop(Laptop laptop)
    {
        this.CpuBrand = laptop.CpuBrand;
        this.CpuModel = laptop.CpuModel;
        this.Id = laptop.Id;
        this.Name = laptop.Name;
        this.Description = laptop.Description;
        this.IsOrdered = laptop.IsOrdered;
        this.Price = laptop.Price;
    }

    public override string ToString()
    {
        return $"{CpuModel} {CpuBrand} {Name} {Description} {IsOrdered} {Price}";

    }
}