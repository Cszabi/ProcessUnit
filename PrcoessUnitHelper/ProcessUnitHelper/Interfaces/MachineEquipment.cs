using ProcessUnitHelper.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper.Interfaces
{
    public abstract class MachineEquipment : BaseEquipment
    {
        public List<Nozzle> Nozzles { get; private set; }
        public Dictionary<string, string> Materials { get; private set; }
    }
}
