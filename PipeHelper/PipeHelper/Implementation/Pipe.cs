using System;
using System.Collections.Generic;
using System.Text;

namespace PipeHelper.Interfaces
{
    using ProcessUnitHelper;
    using System;
    using System.Collections.Generic;
    using System.Text;
    
        public class Pipe 
        {
            public int PipeID { get; set; }
            public string TagNumber { get; set; }
            public  string PressureRating { get; set; }
        public int EquipmentID { get ; set; }
        public int Rating { get ; set ; }

        public void PerformanceSummary()
        {
            throw new NotImplementedException();
        }
    }
    }

