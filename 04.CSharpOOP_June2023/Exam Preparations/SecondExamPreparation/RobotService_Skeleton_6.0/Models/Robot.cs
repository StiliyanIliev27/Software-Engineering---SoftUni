﻿using RobotService.Models.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RobotService.Models
{
    public abstract class Robot : IRobot
    {
        private string model;
        private int batteryCapacity;
        private readonly List<int> interfaceStandarts;
        protected Robot(string model, int batteryCapacity, int convertionCapacityIndex)
        {
            Model = model;
            BatteryCapacity = batteryCapacity;
            ConvertionCapacityIndex = convertionCapacityIndex;
            BatteryLevel = batteryCapacity;

            interfaceStandarts = new List<int>();
        }

        public string Model
        { 
            get => model;
            
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ModelNullOrWhitespace);
                }
             
                model = value;
            }
        }

        public int BatteryCapacity 
        { 
            get => batteryCapacity;
           
            private set 
            { 
                if(value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.BatteryCapacityBelowZero);
                }

                batteryCapacity = value;
            }
        }

        public int BatteryLevel { get; private set; }    

        public int ConvertionCapacityIndex { get; private set; }

        public IReadOnlyCollection<int> InterfaceStandards => interfaceStandarts.AsReadOnly();

        public void Eating(int minutes)
        {
            int producedEnergy = ConvertionCapacityIndex * minutes;

            if(producedEnergy > BatteryCapacity - BatteryLevel)
            {
                BatteryLevel = BatteryCapacity;
            }
            else
            {
                BatteryLevel += producedEnergy;
            }
        }
        public void InstallSupplement(ISupplement supplement)
        {
            interfaceStandarts.Add(supplement.InterfaceStandard);

            BatteryCapacity -= supplement.BatteryUsage;
            BatteryLevel -= supplement.BatteryUsage;
        }
        public bool ExecuteService(int consumedEnergy)
        {
            if(BatteryLevel >= consumedEnergy)
            {
                BatteryLevel -= consumedEnergy;
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name} {Model}:");
            sb.AppendLine($"--Maximum battery capacity: {BatteryCapacity}");
            sb.AppendLine($"--Current battery level: {BatteryLevel}");

            string supplementsInstalled = InterfaceStandards.Any()
                ? $"{string.Join(" ", InterfaceStandards)}"
                : "none";

            sb.AppendLine($"--Supplements installed: {supplementsInstalled}");

            return sb.ToString().TrimEnd();
        }
    }
}
