using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib.GetElectricCharge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Lib;

namespace Lib.GetElectricCharge.Tests
{
    [TestClass()]
    public class GetElectricChargeTests
    {
        GetElectricCharge electric = new GetElectricCharge();

        [TestInitialize]
        public void TestInitialize()
        {
            string dorm = "3305";
            electric.Login(dorm);
        }

        [TestMethod()]
        public void LoginTest()
        {
            string dorm = "3305";
            electric.Login(dorm);
        }

        [TestMethod()]
        public void GetElectric()
        {
            string electricity = electric.GetElectric();
            if (electricity == null)
            {
                Assert.Fail();
            }
        }
    }
}