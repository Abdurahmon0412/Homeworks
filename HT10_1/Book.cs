using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT10_1
{
    public class Book
    {
        

        public  Book(Guid  id, string title,string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }


    }
}
