using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper.Interfaces
{
    public abstract class ElectricalConsumer
    {
        public double WorkingHours { get; set; }
        
        public  double InstalledPower { get; internal set; }

        public double Voltage { get; internal set; } 

        public int NumberofPhase { get; internal set; }

        private double consumedPower;
        
        public double ConsumedPower { get => consumedPower; set => consumedPower = InstalledPower * WorkingHours / 24; }

       
    }
}
