using HT_N25.Interfaces;

namespace HT_N25.Models;

public class ProductFilterDataModel
{
    public List<string> ProductTypes { get;}
    public ProductFilterDataModel(List<IProduct> products)
    {
        if (products.Count == 0 )
            ProductTypes = new List<string>();
        else
            ProductTypes = products.Select(item => item.GetType()
                .FullName).Distinct().ToList();
    }
}