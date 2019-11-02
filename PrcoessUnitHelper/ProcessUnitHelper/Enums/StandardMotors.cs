using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper.Enums
{
    public class StandardMotorPower
    {
        private List<double> StandardMotors { get; set; } = new List<double>();
        public StandardMotorPower()
        {
            StandardMotors = new List<double>();
            StandardMotors.Add(3.7);
            StandardMotors.Add(5);
            StandardMotors.Add(10);
            StandardMotors.Add(100000);
            StandardMotors.Sort();
        }
        public double SelectStandardMotor(double requiredpower)
        {
            foreach (var item in StandardMotors)
            {
                if (item > requiredpower)
                {
                    return item;
                }
            }
            return 0;
        }
    }
}

