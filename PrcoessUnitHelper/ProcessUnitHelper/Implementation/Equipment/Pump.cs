using ProcessFlowHelper.Implementation;
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
            var emotor = new ElectricalMotor(ShaftPower);
            emotor.WorkingHours = 24;
            emotor.InstalledPower = 10;
            ElectricalMotors.Add(emotor);
        }
        public Flow Flow { get; private set; }
        public double Head { get; private set; }

        public void CalculateShaftPower()
        {
            ShaftPower = Head * Flow.RatedFlow / MechanicalEfficiency / HydraulicEfficiency;
        }

    }
}

