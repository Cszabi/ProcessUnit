using ProcessFlowHelper.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper.Implementation.Equipment
{
    public class CoarseScreen : SimpleMachine
    {
        public Flow Flow { get; private set; }
        public CoarseScreen(Flow flow, double requiredPower)
        {
            {
                Flow = flow;
                isContinousWorking = true;
                isVibratingSensitive = false;
                isWorking = true;
                HydraulicEfficiency = 0.95d;
                MechanicalEfficiency = 0.85d;
                ElectricalMotor = new ElectricalMotor(requiredPower);
                CalculateInstalledPower();
                CalculateConsumedPower();
            }

        }
    }
}
