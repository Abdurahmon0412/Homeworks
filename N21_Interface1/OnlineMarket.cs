using N21_Interface1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using N21_Interface1.Cards;
namespace N21_Interface1
{
    public class OnlineMarket
    {
        private  IDebitCard BankAccount = new KapitalUzcard("OnlaynBankCard", "Hamkorbank", 0);
        private readonly IPaymentProvider _paymentProvider;
        private readonly List<Product> _products;
        public OnlineMarket(IPaymentProvider paymentProvider)
        {
             
            _paymentProvider = paymentProvider; 
            _products = new List<Product>();

        }

        public void Add(Product product)
        {
            _products.Add(product);
        }
        //Buy(name, number, card ) - product lar ichidan berilgan nomdagi produktni berilgan sonda hisoblab,
        //    kartadan pul yechishni payment provider orqali amalga oshirsin
        public void Buy(string name, int number, IDebitCard card)
        {
            foreach (Product product in _products)
            {
                if(product.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        if(_paymentProvider.Transfer( card, BankAccount, product.Price * number))
                        {
                            Console.WriteLine("harid muvaffaqiyatli amalga oshirildi");
                        }
                        else { throw new ArgumentNullException("Mahsulot sotib olish uchun yetarli mablag' mavjud emas"); }

                    }
                    catch(ArgumentNullException arg)
                    {
                        Console.WriteLine(arg.Message);
                    }

                }
            }
        }

    }
}
