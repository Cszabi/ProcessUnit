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
 
         

            Assert.AreEqual("P-001", jetpump.TagNumber);

            Assert.AreEqual(true, jetpump.isWorking);



        }
    }
}