using System.Collections.Generic;

namespace ProcessUnitHelper.Enum
{
    public static class StandardVolume
    {
        private static List<double> Volumes { get; set; } = new List<double>();
        public static void GetStandardVolume()
        {
            Volumes = new List<double>();
            Volumes.Add(100);
            Volumes.Add(500);
            Volumes.Add(1000);
            Volumes.Add(2500);
            Volumes.Add(2500);
            Volumes.Add(2500);

            Volumes.Sort();
        }
        public static double SelectStandardVolume(double requiredpower)
        {
            foreach (var item in Volumes)
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