using HT_N25.Interfaces;

namespace HT_N25.Models;

public class Chair:IProduct
{
    public double MaxWeight { get; set; }
    public  string Material { get; set; }


    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public double Price { get; set; }

    public Chair(double maxWeight, string material, string name, string description, bool isOrdered, double price)
    {
        MaxWeight = maxWeight;
        Material = material;
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        IsOrdered = isOrdered;
        Price = price;
    }

    public Chair(Chair chair)
    {
        this.MaxWeight = chair.MaxWeight;
        this.Material = chair.Material;
        this.Id = chair.Id;
        this.Name = chair.Name;
        this.Description = chair.Description;
        this.IsOrdered = chair.IsOrdered;
        this.Price = chair.Price;
    }

    public override string ToString()
    {
        return $"{MaxWeight} {Material} {Name} {Description} {IsOrdered} {Price}";
    }
}