﻿using Signals;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper.Implementation.Equipment
{
    public abstract class SimpleMachine : BaseEquipment, IMachine
    {

        public bool isGenerateVibration { get; } = false;

        public override int DigitalInput { get; set; } = 0;
        public override int DigitalOutput { get; set; } = 0;
        public override int AnalogInput { get; set; } = 0;
        public override int AnalogOutput { get; set; } = 0;
        public override int PO { get; set; } = 0;
        public override int PB { get; set; } = 0;

        public ElectricalMotor ElectricalMotor { get; internal set; }

        public double InstalledPower { get; internal set; }

        public double ConsumedPower { get; internal set; }

        public void CalculateConsumedPower()
        { 
            ConsumedPower= ElectricalMotor.ConsumedPower;
        }

        public void CalculateInstalledPower()
        {
            InstalledPower = ElectricalMotor.InstalledPower;
        }

    }
}
