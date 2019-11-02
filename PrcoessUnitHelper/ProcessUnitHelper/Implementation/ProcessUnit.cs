using ProcessUnitHelper.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper

{
   
    public class ProcessUnit : TaggedElement
    {
       
        public List<BaseEquipment> ListSubEquipment = new List<BaseEquipment>();

        public List<Nozzle> Connectors = new List<Nozzle>();

        public void AddEquipment(BaseEquipment equipment)
        {
            ListSubEquipment.Add(equipment);
        }
    }

}