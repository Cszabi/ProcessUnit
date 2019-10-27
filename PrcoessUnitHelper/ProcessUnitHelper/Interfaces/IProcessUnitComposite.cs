using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper
{
    public interface IProcessUnitComposite
    {
        int ProcessUnitID { get; set; }
        string TagNumber { get; set; }
        int Rating { get; set; }
        void PerformanceSummary();
    }
}
