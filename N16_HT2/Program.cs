//unda quyidagi methodlar bo'lsin
//- Activate methodi yordamida ishga tushiriladigan ( activate ) qilinadigan bo'lsin
//- DisplayHomeTemperature - bunda vaqt davomida foydalanuvchi xohlagan va SmartHome ta'minlay olgan temperatura chiqsin

//- temperaturani expected va current qiymatlarini saqlash uchun Temperature modelidan foydalanish mumkin

//Exmaple

//foydaluvchi xohlagan va SmartHome ta'minlay olgan temperaturani quyidagicha dastur o'zida kiritsangiz bo'ladi

//ExpectedTemperature = 20
//CurrentTemperature = 22
//CurrentTemperature = 23
//CurrentTemperature = 21
//CurrentTemperature = 20
//ExpectedTemperature = 25
//CurrentTemperature = 21
//CurrentTemperature = 22
//CurrentTemperature = 23

//DisplayHomeTemperature natijasi 

//Expected - 20, Current - 22
//Expected - 20, Current - 23
//Expected - 20, Current - 21
//Expected - 20, Current - 20
//Expected - 25, Current - 21
//Expected - 25, Current - 22
//Expected - 25, Current - 23

namespace N16_HT2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tempratures = new List<Temprature>();
            Tempratures.Add(new Temprature(20, 22));
            Tempratures.Add(new Temprature(20, 23));
            Tempratures.Add(new Temprature(20, 21));
            Tempratures.Add(new Temprature(20, 20));
            Tempratures.Add(new Temprature(25, 21));
            Tempratures.Add(new Temprature(25, 22));
            Tempratures.Add(new Temprature(25, 23));


            var SmartHouse = new SmartHomeService("Deviser", Tempratures);
            SmartHouse.Activated();
            SmartHouse.DisplayHomeTemperature();
        }
    }
}




