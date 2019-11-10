﻿using Signals;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessUnitHelper
{
    abstract public class BaseEquipment : TaggedElement
    {
  
        public double MechanicalEfficiency { get; internal set; }
        public double HydraulicEfficiency { get; internal set; }
        public double ShaftPower { get; internal set; }
        public bool isWorking { get; internal set; }
        public bool isContinousWorking { get; internal set; }
        public int WorkingHoursinADay { get; private set; }
        public bool isVibratingSensitive { get; internal set; }
    }
} 
