namespace ProcessUnitHelper
{
    public abstract class TaggedElement
    {
        public int ID { get; }
        public string TagNumber { get; internal set; }
        public string Denomination { get; internal set; }
        public void SetTagNumber(string tagnumber)
        {
            TagNumber = tagnumber;
        }
        public void SetDenomination(string denomination)
        {
            Denomination = denomination;
        }
    }
}