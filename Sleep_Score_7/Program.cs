namespace Homeworks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TimeSpan Alternative = TimeSpan.FromHours(8);
            DateOnly[] FiveDays = new DateOnly[]
            {
                new DateOnly(2022,07,10),
                new DateOnly(2022,07,20),
                new DateOnly(2022,07,21),
                new DateOnly(2022,07,22),
                 new DateOnly(2022,07,23)
            };

            TimeSpan[] Duration = new TimeSpan[]
            {
                TimeSpan.FromHours(7),
                TimeSpan.FromHours(9),
                TimeSpan.FromHours(7),
                TimeSpan.FromHours(5),
                TimeSpan.FromHours(12),
            };
            /*TimeSpan[] Insufficient = new TimeSpan[]
            {
                TimeSpan.FromHours(0),
                TimeSpan.FromHours(0),
                TimeSpan.FromHours(0),
                TimeSpan.FromHours(0),
                TimeSpan.FromHours(0),
            };*/

            int[] Insufficient = new int[] { 0,0,0,0,0};
            float[] AwakeningIndex = new float[]
            {
                0f,4f,2f,1f,3f
            };

            for (int designation = 1; designation < 5; designation++)
            {
                if (Duration[designation - 1].Hours < 8)
                {
                    Insufficient[designation] = Math.Abs(Duration[designation - 1].Hours - 8);
                }
            }
            for (int i = 0; i < FiveDays.Length ; i++)
            {
                for(int j = i;j < FiveDays.Length; j++)
                {
                    if(DateTime.Now.DayOfYear - FiveDays[i].DayOfYear > DateTime.Now.DayOfYear - FiveDays[j].DayOfYear)
                    {
                        var TempFivedays = FiveDays[i];
                        FiveDays[i] = FiveDays[j];
                        FiveDays[j] = TempFivedays;

                        var TempDuration = Duration[i];
                        Duration[i] = Duration[j];
                        Duration[j] = TempDuration;

                        var TempInsufficents = Insufficient[i];
                        Insufficient[i] = Insufficient[j];
                        Insufficient[j] = TempInsufficents;

                        var TempAwekindex = AwakeningIndex[i];
                        AwakeningIndex[i] = AwakeningIndex[j];
                        AwakeningIndex[j] = TempAwekindex;

                    }
                }
            }



            for (int Practice = 0; Practice < 5; Practice++)
            {
                var score = (Duration[Practice].Hours - (AwakeningIndex[Practice] / Duration[Practice].Hours)) / (Alternative.Hours + Insufficient[Practice] ) * 10;
                Console.WriteLine($"{FiveDays[Practice]} - " +
                    $"{Duration[Practice].Hours} hours  -  " +
                    $"{score.ToString("F2")}  score");
            }

        }
    }
}