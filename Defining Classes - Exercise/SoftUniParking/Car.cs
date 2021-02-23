using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = registrationNumber;
        }

        //Make: string
        //Model: string
        //HorsePower: int
        //RegistrationNumber: string

        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            string result = $"Make: {this.Make}" + Environment.NewLine;
            result += $"Model: {this.Model}" + Environment.NewLine;
            result += $"HorsePower: {this.HorsePower}" + Environment.NewLine;
            result += $"RegistrationNumber: {this.RegistrationNumber}" + Environment.NewLine;

            return result;
        }
    }
}
