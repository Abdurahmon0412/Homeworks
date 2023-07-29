using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N15_HT1
{
    public class WeatherReport
    {
        protected Dictionary<DateOnly,string> InformationWeatherList = new Dictionary<DateOnly,string>();
        protected List<DateOnly> ForSortedLists = new List<DateOnly>();
        public string GetWeather(DateOnly date)
        {
            return FindWeather(date) == null ? "Berilgan kundagi obhavo topilmadi, boshqa kunlar uchun foydalanib kuring" : FindWeather(date);

        }

        private string? FindWeather(DateOnly date)
        {
            foreach (var weather in InformationWeatherList)
            {
                if(date == weather.Key)
                    return weather.Value;
            }
            return null;
        }

        public virtual void AddWeatherInformation(DateOnly date, string shortinformation)
        {
            try
            {

                if (date < DateOnly.FromDateTime(DateTime.Now))
                    throw new FormatException("Eski ob havo qabul qilinmaydi");
                else
                {
                    ForSortedLists.Add(date);
                    InformationWeatherList.Add(date, shortinformation);
                }

            }
            catch(FormatException exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

    }
}
