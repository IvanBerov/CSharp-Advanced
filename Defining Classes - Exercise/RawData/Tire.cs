using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public double Pressure { get; }
        private int Age { get; }

        public Tire(double pressure , int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }
    }
}
