using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentHelper.Implementation
{
    public  abstract class  BaseInstrument
    {
        int AI { get; set; }
        int AO { get; set; }
        int DI { get; set; }
        int DO { get; set; }
        int PO { get; set; }
        int PB { get; set; }

    }
}
