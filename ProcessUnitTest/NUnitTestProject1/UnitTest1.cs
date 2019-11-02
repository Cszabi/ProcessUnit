using NUnit.Framework;
using ProcessUnitHelper;
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
            Blower blower = new Blower();
            jetpump.SetTagNumber("P-002");
            jetpump.SetDenomination("Jetpump for equalization tank");
 
         

            Assert.AreEqual("P-002", jetpump.TagNumber);
            Assert.AreEqual(0, jetpump.DigitalInput);
            Assert.AreEqual(true, jetpump.isWorking);
            Assert.AreEqual("Jetpump for equalization tank", jetpump.Denomination);

        }
    }
}