using System;
using System.Collections.Generic;
using System.Text;
using InstrumentHelper.Implementation;
using ProcessUnitHelper.Interfaces;
using Signals;

namespace ProcessUnitHelper.Implementation
{
    public abstract class CompositeMachine : BaseEquipment, IMachine
    {
        private List<ElectricalMotor> electricalMotors = new List<ElectricalMotor>();

        public List<ElectricalMotor> GetElectricalMotors()
        { return electricalMotors; }

        public void SetElectricalMotors(List<ElectricalMotor> value)
        { electricalMotors = value; }

        public List<IEquipment> Equipment { get; set; } = new List<IEquipment>();
        private List<BaseInstrument> instruments = new List<BaseInstrument>();
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
            foreach (var motor in GetElectricalMotors())
            {
                InstalledPower = InstalledPower + motor.InstalledPower;
            }
        }
        public void CalculateConsumedPower()
        {
            ConsumedPower = 0d;
            foreach (var motor in GetElectricalMotors())
            {
                ConsumedPower = ConsumedPower + motor.ConsumedPower;
            }
        }

    }
}
