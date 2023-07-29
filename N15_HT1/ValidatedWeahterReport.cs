using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N15_HT1
{
    public class ValidatedWeahterReport:WeatherReport
    {

        public override void AddWeatherInformation(DateOnly date, string shortinformation)
        {
            foreach (var inf in InformationWeatherList.Keys)
            {
                if(inf == date)
                {

                    InformationWeatherList[inf] = shortinformation;
                    return;
                }
            }
            base.AddWeatherInformation(date, shortinformation);
        }
    }
}
