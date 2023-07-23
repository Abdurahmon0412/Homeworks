using HT10_1;

namespace Homeworks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rd = new Random();
            List<Book> books = new List<Book>();
            books.Add(new Book(Guid.NewGuid(),"Odoblar xazinasi","Shayx Muhammad Sodiq Muhammad yusuf") );
            books.Add(new Book(Guid.NewGuid(),"Sariq devni minib","Xudoyberdi Tuxtaboyev") );
            books.Add(new Book(Guid.NewGuid(), "biz baxtli bulamiz", "Muhammad yusuf"));

            var Libraries = new LibraryManagement();

            foreach(Book book in books)
            {
                Libraries.AddBook(book, rd.Next(0,3));
            }
            Console.WriteLine("Olib turish uchun kitoblardan birini tanlang: 1....");
            Libraries.GetBooks();
            Console.WriteLine("Dasturdan chiqish uchun 0 ni bosing");
            var check = Console.ReadLine();
            bool checkwhile = true;
            while (checkwhile)
            {
                switch (check)
                {
                    case "0":
                        Console.WriteLine("Xizmatimizdan foydalanganingiz uchun rahmat");
                        checkwhile = false;
                        break;
                    case "1":
                        Console.WriteLine(Libraries.Checout(books[0]));
                        break;
                    case "2":
                        Console.WriteLine(Libraries.Checout(books[1]));
                        break;
                    case "3":
                        Console.WriteLine(Libraries.Checout(books[2]));
                        break;
                    default:
                        Console.WriteLine("Kechirasiz bunday kitob mavjud emas iltimos tugri raqamni tanlang");
                        break;
                }

            }
        }
    }
}


