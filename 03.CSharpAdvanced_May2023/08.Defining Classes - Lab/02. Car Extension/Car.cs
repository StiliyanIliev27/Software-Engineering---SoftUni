﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
   public class Car
   {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make 
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }
        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                this.fuelQuantity = value;
            }
        }
        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }
        public void Drive(double distance)
        {
            if(FuelQuantity - distance * fuelConsumption >= 0)
            {
                FuelQuantity -= distance * fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.AppendLine($"Fuel: {this.FuelQuantity:F2}");

            return result.ToString().Trim();
        }

    }
}
