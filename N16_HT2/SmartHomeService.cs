using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N16_HT2
{
    public class SmartHomeService
    {
        public bool _isActivated { get; private set; }
        public bool IsActivated => _isActivated;
        private string _deviceName;
        
        public string DeviceName
        {
            get => _deviceName;

            init => _deviceName = value;
        }
        private  List<Temprature> ListTemperature = new List<Temprature>();
        


        public SmartHomeService(string device,List<Temprature> listTemprature) 
        {
            DeviceName = device;
            ListTemperature = listTemprature;
        }

        public bool Activated()
        {
            _isActivated = true;
            return _isActivated;
        }

        public void DisplayHomeTemperature()
        {
            if(IsActivated== false)
            {
                throw new ArgumentNullException("Temperaturea umuman mavjud emas");
            }
            else
            {
                foreach(var temp in ListTemperature)
                {
                    Console.WriteLine(temp);
                }
            }

        }
    }
}
