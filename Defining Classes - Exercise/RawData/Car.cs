using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {

        public string Model { get; }
                                     // properties from other classes
        public Engine Engine { get; }   
        public Cargo Cargo { get; }
        public List<Tire> Tires { get; }

        public Car(string model,      //constructor
                   int engineSpeed,
                   int enginePower,
                   int cargoWeight,
                   string cargoType,
                   string[] tiresData)
        {
            this.Model = model;
            this.Engine = new Engine(engineSpeed, enginePower);
            this.Cargo = new Cargo(cargoWeight, cargoType);
            this.Tires = new List<Tire>();
            AddTires(tiresData);
        }
        private void AddTires(string[] tiresData)
        {
            for (int i = 0; i < tiresData.Length; i += 2)
            {
                double pressure = double.Parse(tiresData[i]);

                int age = int.Parse(tiresData[i + 1]);

                Tires.Add(new Tire(pressure, age));
            }
        }

    }
}
