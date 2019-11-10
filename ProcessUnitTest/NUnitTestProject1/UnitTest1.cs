using NUnit.Framework;
using ProcessFlowHelper;
using ProcessUnitHelper;
using ProcessUnitHelper.Implementation.Equipment;
using System;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var f1 = new ProcessFlowHelper.Implementation.Flow();
            f1.RatedFlow = 10;
            Pump jetpump =new Pump (f1,20);
            var f2 = new ProcessFlowHelper.Implementation.Flow();
            f2.RatedFlow = 20;
            var medi = new Medium();
            Blower blower = new Blower(100, 90, f2);
            jetpump.SetTagNumber("P-002");
            jetpump.SetDenomination("Jetpump for equalization tank");
            Assert.AreEqual("P-002", jetpump.TagNumber);
            Assert.AreEqual(0, jetpump.DigitalInput);
            Assert.AreEqual(true, jetpump.isWorking);
            Assert.AreEqual("Jetpump for equalization tank", jetpump.Denomination);

        }
        [Test]
        public void Test2()
        {
            var f1 = new ProcessFlowHelper.Implementation.Flow();
            f1.RatedFlow = 10;
            var f2 = new ProcessFlowHelper.Implementation.Flow();
            f2.RatedFlow = 20;
            var medi = new Medium();
            Pump jetpump = new Pump(f1, 20);
            Blower blower = new Blower(98,90,f2);
            blower.SetTagNumber("AR-001");
            jetpump.SetTagNumber("P-002");
            jetpump.SetDenomination("Jetpump for equalization tank");
            var eqtankunit = new ProcessUnit();
            eqtankunit.AddEquipment(jetpump);
            eqtankunit.AddEquipment(blower);
            eqtankunit.SetDenomination("U-001");
            eqtankunit.SetDenomination("Equalization tank process unit");
            Assert.AreEqual("P-002", eqtankunit.ListSubEquipment[0].TagNumber);
            Assert.AreEqual("AR-001", eqtankunit.ListSubEquipment[1].TagNumber);
            Assert.AreEqual(500, eqtankunit.InstalledPower);
        }
        [Test]
        public void Test3()
        {
            var f1 = new ProcessFlowHelper.Implementation.Flow();
            f1.RatedFlow = 10;
            Pump jetpump = new Pump(f1, 20);
    
            CoarseScreen cs = new CoarseScreen(f1,1);
            var eqtankunit = new ProcessUnit();
            eqtankunit.AddEquipment(cs);
            eqtankunit.AddEquipment(jetpump);
            eqtankunit.SetDenomination("U-001");
            eqtankunit.SetDenomination("Equalization tank process unit");
 
            Assert.AreEqual(253.7, eqtankunit.InstalledPower);
        }
    }
}