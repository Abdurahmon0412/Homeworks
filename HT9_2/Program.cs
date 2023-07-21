namespace Homeworks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> EventName = new List<string>();
            EventName.Add("Mustaqillik kuni");
            EventName.Add("O'qtuvchi va Murabbiylar kuni");
            EventName.Add("Konstitutsiya qabul qilingan kun");
            EventName.Add("Shekspir ulgan kun");
            EventName.Add("Job Intervyu");

            List<string> counryTime = new List<string>();
            counryTime.Add("en");
            counryTime.Add("ru");
            counryTime.Add("uz");

            var Datetimes = new DateTime[]
            {
                new DateTime(2023,9,1,9,0,0),
                new DateTime(2023,10,1,13,30,0),
                new DateTime(2023,12,8,6,45,0),
                new DateTime(2023,8,15,16,0,0),
                new DateTime(2024,1,14,9,0,0)
            };

            for (var timeA = 0; timeA < Datetimes.Length; timeA++)
            {
                for (var timeB = 0; timeB < Datetimes.Length; timeB++)
                {
                    if (Datetimes[timeA] > Datetimes[timeB])
                    {
                        var Temp = Datetimes[timeA];
                        Datetimes[timeA ] = Datetimes[timeB];
                        Datetimes[timeB ] = Temp;
                    }
                }
            }

            foreach (var country in counryTime)
            {
                switch (country)
                {
                    case "en":
                        Console.WriteLine(country);
                        for (var time = 0; time < Datetimes.Length;time ++ )
                        {
                            Console.WriteLine($"{EventName[time]} - {Datetimes[time].ToString("dd.MM.yyyy hh:mm tt")}");
                        }
                        break;
                    case "ru":
                        Console.WriteLine(country);
                        for (var time = 0; time < Datetimes.Length; time++)
                        {
                            Console.WriteLine($"{EventName[time]} - {Datetimes[time].ToString("dd/MM/yyyy HH:mm")}");
                        }
                        break;

                    case "uz":
                        Console.WriteLine(country);
                        for (var time = 0; time < Datetimes.Length; time++)
                        {
                            Console.WriteLine($"{EventName[time]} - {Datetimes[time].ToString("dd.MM.yyyy HH:mm")}");
                        }
                        break;
                }
            }

        }
    }
}