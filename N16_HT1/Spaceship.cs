using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//unda quyidagi propertylar bo'lsin
//- Name - nomi ( init-only )
//-Fuel - yoqilg'i miqdori ( read-only )
//- Speed - tezligi(read - write)
//- Trajectory - trayektoriyasi(write - only)

//- bitta object yarating, speed va trajectory ni har xil qiymatlarga o'zgartirib ekranga chiqaring
namespace N16_HT1
{
    public class Spaceship
    {
        public Spaceship(string name,double fuel) 
        {
            Name = name;
            _fuel = fuel;

        }
        public string Name { get; init; }
        
        private double _trajectory;
        public double Trajectory
        {
            set { _trajectory = value; }
        } 

        private readonly double _fuel;
        public double Fuel => _fuel;
        
        private double _speed;
        public double Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        public override string ToString()
        {
            return $"{Name} - {Fuel} - {Speed}";
        }
    }
}
