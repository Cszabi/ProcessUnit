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

        public  int DigitalInput { get; set; } = 1;

        public int DigitalOutput { get; set; } = 0;
        
        public int AnalogInput { get; set; } = 0;
        
        public int AnalogOutput { get; set; } = 0;
        
        public int PO { get; set; } = 0;
        
        public int PB { get; set; } = 0;

        public Blower(double dischargepressure, double suctionpressure, Flow flow)
        {
            //default values set
            Denomination = "Blower";
            Flow = flow;
            SuctionPressure = suctionpressure;
            DischargePressure = dischargepressure;

            isContinousWorking = true;
            isContinousWorking = true;
            isVibratingSensitive = false;
            isGenerateVibration = false;
            isWorking = true;
            HydraulicEfficiency = 0.95d;
            MechanicalEfficiency = 0.8d;
            CalculateShaftPower();
            var emotor = new ElectricalMotor(ShaftPower);
            emotor.WorkingHours = 24;
            GetElectricalMotors().Add(emotor);
            CalculateInstalledPower();
            CalculateConsumedPower();
        }


        public void CalculateShaftPower()
        {
            ShaftPower= (DischargePressure - SuctionPressure) * Flow.RatedFlow/MechanicalEfficiency/HydraulicEfficiency;
        }
        
     }
}

