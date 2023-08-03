using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT1
{
    public class CarRentalManagement
    {
        private List<CarRental> Cars { get;set; }
        
        public CarRentalManagement() 
        {

            Cars = new List<CarRental>();
        }

        public void Add(CarRental car)
        {
            Cars.Add(car);
        }

        public CarRental? Rent(string brendname)
        {
            foreach (var car in Cars)
            {
                if (car.BrandName.Contains(brendname) && car.IsRented == false){
                    car.RentStartTime = DateTime.Now;
                    car.IsRented = true;
                    return car;
                }
            }
            return null;
        }

        public CarRental? Return(CarRental car)
        {
            foreach(var Car in Cars)
            {
                if(Car.Id == car.Id)
                {
                    Car.IsRented = false;
                    if(car.BrandName == "BMW")
                    {

                        Car.Balance = (DateTime.Now - car.RentStartTime).TotalSeconds * BMW.RentPriceHour;
                    }
                    else if(car.BrandName == "AUDI")
                    {
                        Car.Balance = (DateTime.Now - car.RentStartTime).TotalSeconds * AUDI.RentPriceHour;

                    }
                }
            }
            return null;
        }
        public void CalculateBalance()
        {
            double calculatebalance = 0;
            foreach (CarRental car in Cars)
            {
                calculatebalance += car.Balance;
            }
            Console.WriteLine(calculatebalance);
        }

    }
}
