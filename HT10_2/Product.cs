using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT10_2
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        
        public Product(Guid id, string name)
        {
            Name = name;
            Id = id;
        }
        
       

        

    }
}
