using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace N15_HT1
{
    public class UltimateWeatherReport : ValidatedWeahterReport
    {
        public List<string>? GetWeather(DateOnly date, int days)
        {
            var ForSortedList = SortWether(ForSortedLists);
            try { 
                List<string> Forreturn = new List<string>();
                int index = -1;
                for(int i = 0; i < ForSortedList.Count; i++)
                {
                    if (ForSortedList[i] == date)
                        index = i;
                }
                if (index < 0 || ForSortedList.Count - index < days) throw new ArgumentException("Uzr, to'liq ma'lumot yo'q");

                for(int dates = index; dates < days;dates++)
                {
                    Forreturn.Add(Convert.ToString(ForSortedList[dates]) + " " + InformationWeatherList[ForSortedList[dates]]);
                }
                return Forreturn;
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public List<string> GetWeather(int days)
        {
            try 
            { 
                var ForSortedList = SortWether(ForSortedLists);

                List<string> Forreturn = new List<string>();

                if (days > ForSortedList.Count) throw new ArgumentException("Uzr, to'liq ma'lumot yo'q");

                else
                {
                    for (int dates = 0; dates < days; dates++)
                    {
                        Forreturn.Add(Convert.ToString(ForSortedList[dates]) + "  " + InformationWeatherList[ForSortedList[dates]]);
                    }
                    return Forreturn;
                }
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
}

        private List<DateOnly> SortWether(List<DateOnly> ForSortedListsA)
        {
            ForSortedListsA.Sort();
            return ForSortedListsA;
        }

        


    }
}
