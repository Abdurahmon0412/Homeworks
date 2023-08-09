using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_Interface1
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            if(!string.IsNullOrWhiteSpace( name))
                Name = name;
            if(price > 0)
                Price = price;
        }
    }
}
