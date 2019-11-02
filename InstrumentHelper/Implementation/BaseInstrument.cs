using Signals;

namespace InstrumentHelper.Implementation
{
    public abstract class BaseInstrument : ISignal
    {
        public abstract int DigitalInput { get; set; }
        public abstract int DigitalOutput { get; set; }
        public abstract int AnalogInput { get; set; }
        public abstract int AnalogOutput { get; set; }
        public abstract int PO { get; set; }
        public abstract int PB { get; set; }
        string MeasuredSignal { get; set; }
        

    }
}
