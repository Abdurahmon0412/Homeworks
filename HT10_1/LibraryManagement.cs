using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT10_1
{
   public class LibraryManagement
   {
        public Dictionary<Book,int> Books = new Dictionary<Book,int>();
        public void GetBooks()
        {
            int i = 1;
            foreach (var item in Books) 
            {
                Console.WriteLine($"{i}: {item.Key.Title} ({item.Key.Author})  Book amount: {item.Value}");
                i++;
            }
        }

        public void AddBook(Book book,int amount)
        {
            foreach (var item in Books) {
                if (item.Key.Title.ToString().Contains(book.Title,StringComparison.OrdinalIgnoreCase))
                {
                    Books[item.Key] = item.Value + amount;
                    return;
                }
            }
            Books.Add(book, amount);
        }

        public bool Checout(Book book)
        {
            foreach(var item in Books)
            {
                if(item.Key.Title.ToString().Contains(book.Title, StringComparison.OrdinalIgnoreCase) && item.Value > 0)
                {
                    Books[item.Key] = item.Value - 1;
                    return true;
                }
            }
            return false;
        }

        public int GetBookAmount(Book book)
        {
            foreach (var item in Books)
            {
                if(item.Key.Title.ToString().Contains(book.Title, StringComparison.OrdinalIgnoreCase))
                {
                    return item.Value;
                }
            }
            return 0;
        }

        
   }
}
