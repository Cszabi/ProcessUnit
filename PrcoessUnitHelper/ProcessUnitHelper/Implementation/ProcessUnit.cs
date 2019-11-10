using ProcessUnitHelper.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper

{
   
    public class ProcessUnit : TaggedElement, IMachine
    {
        public ProcessUnit()
        {
            
        }
       
        public List<BaseEquipment> ListSubEquipment = new List<BaseEquipment>();

        public List<Nozzle> Connectors = new List<Nozzle>();

        public double InstalledPower { get; private set; }

        public double ConsumedPower { get; private set; }

        public bool isGenerateVibration { get; private set; }
        public int DigitalInput { get ; set; }
        public int DigitalOutput { get; set; }
        public int AnalogInput { get; set; }
        public int AnalogOutput { get; set; }
        public int PO { get; set; }
        public int PB { get; set; }

        public void AddEquipment(BaseEquipment equipment)
        {
            ListSubEquipment.Add(equipment);
            CalculateInstalledPower();
            CalculateConsumedPower();
        }

        public void CalculateConsumedPower()
        {
            double cp = 0.0d;
            foreach (var item in ListSubEquipment)
            {
                if (item is IMachine)
                {
                    var machine = (IMachine)item;
                    cp += machine.ConsumedPower;
                }
            }
            ConsumedPower = cp;
        }

        public void CalculateInstalledPower()
        {
            double ip = 0.0d;
            foreach (var item in ListSubEquipment)
            {
                if (item is IMachine)
                {
                    var machine = (IMachine)item;
                    ip += machine.InstalledPower;
                }
            }
            InstalledPower = ip;
        }
      
    }

}