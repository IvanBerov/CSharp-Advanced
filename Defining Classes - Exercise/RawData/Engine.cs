using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {
        private int Speed { get; }
        public int Power { get; }

        public Engine(int speed , int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
    }
}
