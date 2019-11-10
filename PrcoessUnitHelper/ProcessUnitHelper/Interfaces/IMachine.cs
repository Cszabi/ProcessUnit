using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper
{
    interface IMachine : ISignal
    {
        double InstalledPower { get; }
        double ConsumedPower { get; }
        bool isGenerateVibration { get; }
        void CalculateConsumedPower();
        void CalculateInstalledPower();

    }
}
