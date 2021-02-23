using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        private int Weight { get; }
        public string Type { get; }

        public Cargo(int weight,string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
    }
}
