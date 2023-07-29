using N15_HT1;


//Birinchi shart
//var Day1 = new WeatherReport();
//Day1.AddWeatherInformation(new DateOnly(2023,07,29), "Bugun havo ancha issiq");
//Day1.AddWeatherInformation(new DateOnly(2023, 07, 30), "Ertaga havo harorati uzgarib turadi");
//Day1.AddWeatherInformation(new DateOnly(2023,07,31),"Abidgacha dimm bulatti Abittan kiyin jijja yomgir yogib rasa osh yikon havo buladi");
//Day1.AddWeatherInformation(new DateOnly(2023, 08, 1),"Endi urtogla erta toza ochu havo buluriddi");
//Day1.AddWeatherInformation(new DateOnly(2023, 08, 2), "Abidgacha nam havo buladi abiddan kiyin kam havo buladi");
//Day1.AddWeatherInformation(new DateOnly(2023, 08, 3), "Efirda ohi bobo : Yengil shabada esodi");


var Day1 = new UltimateWeatherReport();
Day1.AddWeatherInformation(new DateOnly(2023, 07, 29), "Bugun havo ancha issiq");
Day1.AddWeatherInformation(new DateOnly(2023, 07, 30), "Ertaga havo harorati uzgarib turadi");
Day1.AddWeatherInformation(new DateOnly(2023, 07, 31), "Abidgacha dimm bulatti Abittan kiyin jijja yomgir yogib rasa osh yikon havo buladi");
Day1.AddWeatherInformation(new DateOnly(2023, 08, 1), "Endi urtogla erta toza ochu havo buluriddi");
Day1.AddWeatherInformation(new DateOnly(2023, 08, 2), "Abidgacha nam havo buladi abiddan kiyin kam havo buladi");
Day1.AddWeatherInformation(new DateOnly(2023, 08, 3), "garbdan shamol yomon esadi oma likin");
Day1.AddWeatherInformation(new DateOnly(2023, 08, 4), "Tufon bumaydi ");
Day1.AddWeatherInformation(new DateOnly(2023, 08, 5), "Buron bumaydi unaqa ob havoni bizani yuragimiz kutarmaydi");
Day1.AddWeatherInformation(new DateOnly(2023, 08, 6), "Jala quyadi ");
Day1.AddWeatherInformation(new DateOnly(2023, 08, 7), "Qor yogsa kerak");



var GetWet1 = Day1.GetWeather(new DateOnly(2023,07,29),6);
foreach(var b in GetWet1)
{
    Console.WriteLine(b);
}

Console.WriteLine();
var Getwet2  = Day1.GetWeather(6);
foreach (var b in Getwet2)
{
    Console.WriteLine(b);
}

