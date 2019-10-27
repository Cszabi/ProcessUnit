using System;
using System.Collections.Generic;
using System.Text;

namespace PipeHelper.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
        public interface IBranchComposite
        {
            int Id { get; set; }
            double Size { get; set; }
             string From { get; set; }
            string To { get; set; }
        }
    }

