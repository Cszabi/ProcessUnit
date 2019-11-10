using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper.Implementation.Equipment
{
    public class ChemicalTank : SimpleEquimpent
    {
        private double volume;

        public double Volume
        {
            get => volume; 
            set
            {
             //   volume = SelectFromStandarVolumes();
            }
        }

        public ChemicalTank(double requiredVolume)
        {

        }

    }
}
