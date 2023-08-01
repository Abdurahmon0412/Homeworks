using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N16_HT2
{
    public class Temprature
    {

        public Temprature(int extected, int currented)
        {
            CurrentTemperature = currented;
            ExtectedTemperature = extected;
        }
        public int CurrentTemperature { get; private set; }
        public int ExtectedTemperature { get; set; }
      
        
        public override string ToString()
        {
            return $"Expected - {ExtectedTemperature}, Current - {CurrentTemperature} ";
        }
    }
}
