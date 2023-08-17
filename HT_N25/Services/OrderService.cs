using HT_N25.Models;

namespace HT_N25.Services;

public class OrderService
{
    private readonly ProductService productService;
    private readonly PaymentService paymentService;

    public OrderService(ProductService productService, PaymentService payment)
    {
        this.productService = productService;
        paymentService = payment;
    }

    public bool Order(Guid id, DebitCard card)
    {
        var product = productService.Order(id);
        if (product is null)
            return false;
        if(paymentService.CheckOut(product.Price,card))
            return true;
        return false;
    }

    public bool Order(ProductFilterDataModel filterModel, DebitCard card)
    {
        var products = productService.Get(filterModel);
        if (products.Count == 0)
            return false;
        if (paymentService.CheckOut(products.Sum(x => x.Price), card)) return true;
        return false;
    }
    
}