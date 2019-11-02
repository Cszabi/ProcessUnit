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

        public override int DigitalInput { get; set; } = 1;

        public override int DigitalOutput { get; set; } = 0;
        
        public override int AnalogInput { get; set; } = 0;
        
        public override int AnalogOutput { get; set; } = 0;
        
        public override int PO { get; set; } = 0;
        
        public override int PB { get; set; } = 0;

        public Blower()
        {
            //default values set
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

