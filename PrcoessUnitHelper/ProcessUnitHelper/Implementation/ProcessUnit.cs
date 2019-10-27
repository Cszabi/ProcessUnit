using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper

{
    //'Composite' class - will be branch node in tree structure
    public class ProcessUnit : IProcessUnitComposite
    {
        public int Rating { get; set; }
        public int ProcessUnitID { get; set; }
        public string TagNumber { get ; set; }
        public List<IProcessUnitComposite> ListSubEquipment = new List<IProcessUnitComposite>();

        public void PerformanceSummary()
        {
            Console.WriteLine("\nPerformance summary of supervisor: " +
                              $"{TagNumber} is {Rating} out of 5");
        }

        public void AddEquipment(IProcessUnitComposite equipment)
        {
            ListSubEquipment.Add(equipment);
        }
    }

}