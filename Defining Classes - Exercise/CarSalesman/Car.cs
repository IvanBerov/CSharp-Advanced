using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public Car()
        {

        }
        public Car(string model, Engine engine)
            : this()
        {
            this.Model = model;
            this.Engine = engine;
        }
        public Car(string model, Engine engine, int weight)
            :this(model,engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine , string color )
            :this(model,engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight, string color) 
            : this(model, engine, weight)
        {
            this.Color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            int displacement = Engine.Displacement;
            string efficiency = Engine.Efficiency;

            sb.Append($"{Model}:\n");
            sb.Append($"  {Engine.Model}:\n");
            sb.Append($"    Power: {Engine.Power}\n");

            if (displacement != 0 && efficiency != null) // if we have all
            {
                sb.Append($"    Displacement: {displacement}\n");
                sb.Append($"    Efficiency: {efficiency}\n");
            }
            else if (displacement != 0 && efficiency == null)
            {
                sb.Append($"    Displacement: {displacement}\n");
                sb.Append("    Efficiency: n/a\n");
            }
            else if (displacement == 0 && efficiency != null)
            {
                sb.Append("    Displacement: n/a\n");
                sb.Append($"    Efficiency: {efficiency}\n");
            }
            else if (displacement == 0 && efficiency == null)
            {
                sb.Append("    Displacement: n/a\n");
                sb.Append("    Efficiency: n/a\n");
            }

            if (Weight != 0 && Color != null)
            {
                sb.Append($"  Weight: {Weight}\n");
                sb.Append($"  Color: {Color}");
            }
            else if (Weight != 0 && Color == null)
            {
                sb.Append($"  Weight: {Weight}\n");
                sb.Append("  Color: n/a");
            }
            else if (Weight == 0 && Color != null)
            {
                sb.Append("  Weight: n/a\n");
                sb.Append($"  Color: {Color}");
            }
            else if (Weight == 0 && Color == null)
            {
                sb.Append("  Weight: n/a\n");
                sb.Append("  Color: n/a");
            }
            return sb.ToString();
            // output
            // FordFocus:                FordMustang:            VolkswagenGolf:
            //   V4 - 33:                  V8-101:                 V4-33:
            //     Power: 140                Power: 220              Power: 140
            //     Displacement: 28          Displacement: 50        Displacement: 28
            //     Efficiency: B             Efficiency: n/a         Efficiency: B
            //   Weight: 1300              Weight: n/a             Weight: n/a
            //   Color: Silver             Color: n/a              Color: Orange
        }
    }
}
