using HT_N25.Interfaces;
using HT_N25.Models;
using Monitor = HT_N25.Models.Monitor;

namespace HT_N25.Services;

public class ProductService
{
    /*ProductService dan foydalaning 
    - Inventory - IProduct tipidagi kolleksiya
    - Add ( product ) - inventoryga product qo'shsin
    - GetFilterData - filter data model yasab qaytarsin, 
    agar birorta produkt bo'lmasa filter model da empty value bo'lsin 
    ( list uchun empty list )

        - Get ( filterModel ) - filter bo'yicha topilgan produktlarni copy 
        constructor orqali nusxasini qaytarsin 
    - Order ( product id ) - berilgan produktni topib, o'sha produktni
     isOrdered = true qilsin va copy konstruktor orqali nusxasini qaytarsin, 
     topilmasa exception
    - Return ( product id ) - berilgan produktni topib, o'sha produktni 
    isOrdered = false qilsin va copy konstruktor orqali nusxasini qaytarsin, topilmasa exception
    */

    public List<IProduct> _inventories { get; set; } = new();

    public void Add(IProduct product) => _inventories.Add(product);

    public ProductFilterDataModel GetFilterData() => new ProductFilterDataModel(_inventories);


    public List<IProduct> Get(ProductFilterDataModel filter)
    {
        var filterProducts = _inventories.Where(item => filter.ProductTypes.Contains(item.GetType().FullName)).ToList();
        var result = new List<IProduct>(filterProducts);
        return result;
    }

    //Order ( product id ) - berilgan produktni topib, o'sha produktni isOrdered = true qilsin va copy konstruktor orqali nusxasini qaytarsin, topilmasa exception
    public IProduct Order(Guid productid)
    {
        var findProduct = _inventories.Find(item => item.Id == productid);
        findProduct.IsOrdered = true;
        return CopyProduct(findProduct) == null ? throw new Exception("Product type not found")
            : CopyProduct(findProduct);

    }

    public IProduct Return(Guid productid)
    {
        var findProduct = _inventories.Find(item => item.Id == productid);
        findProduct.IsOrdered = false;
        return CopyProduct(findProduct) == null ? throw new Exception("Product type not found")
            : CopyProduct(findProduct);
    }
    private IProduct CopyProduct(IProduct product)
    {
        if (product is Monitor monitor)
        {
            var obj = new Monitor(monitor);
            return obj;
        }
        else if (product is Chair chair)
        {
            var obj = new Chair(chair);
            return obj;
        }
        else if (product is Laptop laptop)
        {
            var obj = new Laptop(laptop);
            return obj;
        }
        return null;
    }
    
}