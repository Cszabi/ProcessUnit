using Signals;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper.Implementation.Equipment
{
    class SimpleMachine : BaseEquipment, IMachine, ISignal
    {
        public double InstalledPower => throw new NotImplementedException();

        public double ConsumedPower { get; internal set; }

        public bool isGenerateVibration { get; } = false;

        public int DigitalInput { get; set; } = 0;
        public int DigitalOutput { get; set; } = 0;
        public int AnalogInput { get; set; } = 0;
        public int AnalogOutput { get; set; } = 0;
        public int PO { get; set; } = 0;
        public int PB { get; set; } = 0;

        public void CalculateConsumedPower()
        { 
            ConsumedPower= WorkingHoursinADay* InstalledPower;
        }

        public void CalculateInstalledPower()
        {
            throw new NotImplementedException();
        }
    }
}
