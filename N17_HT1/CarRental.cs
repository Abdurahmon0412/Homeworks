using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace N17_HT1
{
    public abstract class CarRental
    {
        protected CarRental(string BrandName)
        {
            this.BrandName = BrandName;
        }
        public bool IsRented { get; set; } = false;
        public DateTime RentStartTime { get; set; }
        public double Balance { get; set; }
        public string BrandName { get; set; }
        public Guid Id { get; set; }

        public override string ToString()
        {
            return $"BrendName: {BrandName}\tRentStartTime - {RentStartTime}";
        }
    }
    public sealed class BMW : CarRental
    {
        public static string ModelName { get; set; }
        public static double RentPriceHour { get; set; }
        public  BMW(string modelName):
               base("BMW")
        {
            ModelName = modelName;
            RentPriceHour = 30;
        }
    }

    public sealed class  AUDI : CarRental
    {
        public static string ModelName { get; set; }
        public static double RentPriceHour { get; set; }
        public AUDI(string modelName) :
               base("AUDI")
        {
            ModelName = modelName;
            RentPriceHour = 30;
        }
    }



}
