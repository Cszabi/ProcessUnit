using ProcessFlowHelper.Implementation;
using ProcessUnitHelper.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper
{
    //Leaf Class
    public class Blower : CompositeMachine
    {
        public int Rating { get; set; }
        public Flow Flow { get; private set; }
        public double Efficiency { get; private set; }
        public double DischargePressure { get; set; }
        public double SuctionPressure { get; set; }

        public Blower()
        {
            Denomination = "Blower";
            isContinousWorking = true;
            isContinousWorking = true;
            isVibratingSensitive = false;
            isGenerateVibration = false;
            isWorking = true;
            HydraulicEfficiency = 0.95d;
            MechanicalEfficiency = 0.8d;
        }


        public void CalculateShaftPower()
        {
            ShaftPower= (DischargePressure - SuctionPressure) * Flow.RatedFlow/MechanicalEfficiency/HydraulicEfficiency;
        }

        
     }
}

