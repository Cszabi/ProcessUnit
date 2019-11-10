using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper
{
    interface ISignal
    {
        int DigitalInput { get; set; }
        int DigitalOutput { get; set; }
        int AnalogInput { get; set; }
        int AnalogOutput { get; set; }
        int PO { get; set; }
         int PB { get; set; }
    }
}
