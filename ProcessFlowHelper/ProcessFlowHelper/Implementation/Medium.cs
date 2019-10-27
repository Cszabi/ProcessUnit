using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessFlowHelper
{
    public class Medium
    {
        public string Denomination { get; private set; }
        public double Density { get; private set; }
        public double Viscosity { get; private set; }
        public double ActualTemperature { get; set; }
        public enum Phase { gas, liquid, mixedgasandliquid }
    }
}
