using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib.GetElectricCharge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Lib;
using team_development.UI.QueryElectricity;

namespace Lib.GetElectricCharge.Tests
{
    [TestClass()]
    public class GetElectricChargeTests
    {
        GetElectricCharge electric = new GetElectricCharge();
        QueryElectricity query = new QueryElectricity();

        [TestMethod()]
        public void GetElectric()
        {                        
            try
            {
                electric.GetElectric("3305", new SetCharge(query.SetElectricCharge));
            }
            catch (Exception E)
            {
                Assert.Fail();
            }

        }
    }
}