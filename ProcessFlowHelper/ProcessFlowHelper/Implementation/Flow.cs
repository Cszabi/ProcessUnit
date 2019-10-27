using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessFlowHelper.Implementation
{
    public class Flow
    {
        public double MaximumFlow { get; set; }
        public double RatedFlow { get; set; }
        public double NormalFlow { get; set; }

        public Medium Medium {get; private set;}
        public double SuggestedVelocity { get; set; }
        public enum FlowType {openchannel, pipe }

    }
}
