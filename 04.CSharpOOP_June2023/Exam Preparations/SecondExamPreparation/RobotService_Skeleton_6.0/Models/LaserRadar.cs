﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Models
{
    public class LaserRadar : Supplement
    {
        private const int InterfaceStandard = 20_082;
        private const int BatteryUsage = 5_000;
        public LaserRadar() 
            : base(InterfaceStandard, BatteryUsage)
        {
        }
    }
}
