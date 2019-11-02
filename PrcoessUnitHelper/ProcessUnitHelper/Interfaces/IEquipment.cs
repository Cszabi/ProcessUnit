using ProcessUnitHelper.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper.Interfaces
{
    public interface IEquipment
    {
        public List<Nozzle> Nozzles { get; set; }
        public Dictionary<string, string> Materials { get; set; }
    }
}
