using System;
using System.Collections.Generic;
using System.Text;
using InstrumentHelper.Implementation;
using ProcessUnitHelper.Interfaces;

namespace ProcessUnitHelper.Implementation
{
    public abstract class CompositeMachine : BaseEquipment, IMachine
    {
        private List<ElectricalMotor> electricalMotors = new List<ElectricalMotor>();

        public List<ElectricalMotor> ElectricalMotors
        {
            get { return electricalMotors; }
            set { electricalMotors = value; }
        }
        private List<MachineEquipment> equipment = new List<MachineEquipment>();

        public List<MachineEquipment> Equipment
        {
            get { return equipment; }
            set { equipment = value; }
        }
        //private List<BaseInstrument> instruments = new List<BaseInstrument>();
        //public List<BaseInstrument> Instruments { get; private set; }
        //{
        //    get { return instruments; }
        //    set { instruments = value; }
        //}
        

        public double InstalledPower { get; internal set ; }

        public double ConsumedPower { get; internal set; }

        public bool isGenerateVibration { get; internal set; }


    public void CalculateInstalledPower()
        {
            InstalledPower = 0d;
            foreach (var motor in ElectricalMotors)
            {
                InstalledPower = InstalledPower + motor.InstalledPower;
            }
        }
        public void CalculateConsumedPower()
        {
            ConsumedPower = 0d;
            foreach (var motor in ElectricalMotors)
            {
                ConsumedPower = ConsumedPower + motor.ConsumedPower;
            }
        }

    }
}
