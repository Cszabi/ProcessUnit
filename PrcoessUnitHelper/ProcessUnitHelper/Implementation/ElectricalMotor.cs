using ProcessUnitHelper.Enums;
using ProcessUnitHelper.Interfaces;
using Signals;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper.Implementation
{
    public class ElectricalMotor : ElectricalConsumer
    {
        private StandardMotorPower StdMotorPower { get; set; }
        
        public double InstalledPower {get;set;}
       
        public ElectricalMotor(double requiredpower)
        {
            StdMotorPower = new StandardMotorPower();
            InstalledPower =StdMotorPower.SelectStandardMotor(requiredpower);
        }
    }
}
