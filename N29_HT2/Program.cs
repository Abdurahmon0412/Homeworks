// See https://aka.ms/new-console-template for more information
using N29_HT2;
Console.WriteLine("Dastur uz ishini boshladi!");
//Employee - xodim
//Hire - ishga oilsh, xodim sifatida ro'yxatdan o'tkazish

//Employee modeldan foydalaning ( id, firstname, lastname )

//EmployeeService servicedan foydalaning

//unda HireAsync(firstname, lastname) methodi bo'lsin

//bunda 
//- xodimga confirmation email jo'nating 
//- email jo'natilgungacha $"{firstname} {lastname}`s employment contract.docs" faylini yarating
//- confirmation email jo'natib bo'lingach, welcome on board email ni jo'nating
//- fayl yaratib bo'lingach ichiga employment contract textini yozib qo'ying
//- welcome on board email jo'natib bo'lingach, office policies emailini jo'nating


var employee1 = new Employee("Firdavs", "Asadov", "toshmurodovj13@gmail.com");

var employeeService = new EmployeeService();
var result = employeeService.HireAsync(employee1);
await Task.WhenAll(result);
Console.WriteLine("Hello, World!");
