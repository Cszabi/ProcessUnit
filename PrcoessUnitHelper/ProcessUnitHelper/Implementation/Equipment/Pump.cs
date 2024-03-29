﻿using ProcessFlowHelper.Implementation;
using ProcessUnitHelper.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper
{
    public class Pump : CompositeMachine
    {
        public Pump(Flow flow, double head)
        {
            Flow = flow;
            Head = head;
            isContinousWorking = true;
            isVibratingSensitive = false;
            isWorking = true;
            HydraulicEfficiency = 0.95d;
            MechanicalEfficiency = 0.85d;
            CalculateShaftPower();
            var emotor = new ElectricalMotor(ShaftPower);
            emotor.WorkingHours = 24;
            GetElectricalMotors().Add(emotor);
            CalculateInstalledPower();
            CalculateConsumedPower();
        }

        public Flow Flow { get; private set; }
        public double Head { get; private set; }
        public override int DigitalInput { get; set; } = 0;
        public override int DigitalOutput { get; set; } = 0;
        public override int AnalogInput { get; set; } = 0;
        public override int AnalogOutput { get; set; } = 0;
        public override int PO { get; set; } = 0;
        public override int PB { get; set; } = 0;

        public void CalculateShaftPower()
        {
            ShaftPower = Head * Flow.RatedFlow / MechanicalEfficiency / HydraulicEfficiency;
        }

    }
}

