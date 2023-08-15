using System.Net;
using N23_HT24.Services;

//PS : UserCredentialsService da parameterized konstruktor bo'lsin, u orqali
//IUserService va IUserCredentialsService implementatsiya qilgan tipdan object berib, fieldga saqlanadigan bo'lsin
//( biz buni AccountService misolida ko'rganmiz )

//- dasturda UserCredentialsService dan object yarating
//- bir nechta userlar qo'shing va natijasini ekranga chiqaring
//- konsoldan keyword kiritib, userlar ni search qilib ekranga chiqaring
var userService = new UserService();
var UserCredentials = new UserCredentialsService();
var register = new RegistrationService(userService,UserCredentials);


register.Register("John", "Doe", "john.doe@example.com", "securepassword123");
register.Register("Jane", "Smith", "jane.smith@example.com", "strongpassword456");
register.Register("Michael", "Johnson", "michael.johnson@example.com", "mypassword789");
register.Register("Emily", "Brown", "emily.brown@example.com", "safepassword2023");
register.Register("William", "Jones", "william.jones@example.com", "complexpass321");
register.Register("Olivia", "Garcia", "olivia.garcia@example.com", "password987654");
register.Register("James", "Miller", "james.miller@example.com", "myp@ssw0rd");
register.Register("Sophia", "Davis", "sophia.davis@example.com", "newpassw0rd");
register.Register("Benjamin", "Martinez", "benjamin.martinez@example.com", "securepass123");
register.Register("Ava", "Rodriguez", "ava.rodriguez@example.com", "password2023");
register.Register("Liam", "Lopez", "liam.lopez@example.com", "strongpass789");
register.Register("Emma", "Hernandez", "emma.hernandez@example.com", "safe123456");
register.Register("Noah", "Moore", "noah.moore@example.com", "password21");
register.Register("Isabella", "Lee", "isabella.lee@example.com", "passcode123");
register.Register("Ethan", "Clark", "ethan.clark@example.com", "newpassword456");
register.Register("Mia", "Lewis", "mia.lewis@example.com", "securepassw0rd");
register.Register("Aiden", "Walker", "aiden.walker@example.com", "password987");
register.Register("Lily", "Hall", "lily.hall@example.com", "strongpass2023");
register.Register("Carter", "Young", "carter.young@example.com", "safe456789");
register.Register("Grace", "Allen", "grace.allen@example.com", "mypassword123");

//userService.Get(10,1).ForEach(user => Console.WriteLine($"{user.FirstName} {user.LastName} - {user.EmailAddress}"));
userService.Search("e",10,1).ForEach(user => Console.WriteLine($"{user.FirstName} {user.LastName} - {user.EmailAddress}"));