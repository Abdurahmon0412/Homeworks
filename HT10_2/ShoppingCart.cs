using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT10_2
{
    public class ShoppingCart
    {
        public Dictionary<Product,int> Items = new Dictionary<Product,int>();
         public Random rd = new Random();
        public void Add(Product product)
        {
            foreach (var item in Items)
            {
                if (item.Key.Name.ToString().Contains(product.Name, StringComparison.OrdinalIgnoreCase))
                {
                    Items[item.Key] = item.Value + 1;
                    return;
                }
            }
            Items.Add(product, rd.Next(1,6));
        }

        public bool Remove(Product product)
        {
            foreach(var item in Items)
            {
                if (item.Key.Name == product.Name && item.Value > 0)
                {
                    Items[item.Key] = item.Value - 1;
                    return true;
                }
            }
            return false;
        }

        public void AllProducts() 
        {
            int i = 1;
            foreach (var item in Items)
            {
                Console.WriteLine($"{i}: {item.Key.Name} amount: {item.Value}");
                i++;
            }

        }

    }
}
