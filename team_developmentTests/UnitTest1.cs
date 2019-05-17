using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib.GetJWXT;
using team_development.UI.Query.QueryGPA;
using System.Collections.Generic;
using System.Windows.Forms;

namespace team_developmentTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

           Lib.GetJWXT.GetJWXT jwxt = new Lib.GetJWXT.GetJWXT();
            HtmlDocument GpaDoc = jwxt.GetGPA();
        /*    string str = (string)GpaDoc.Body.InnerHtml;
            List<Gpa> gpas=jwxt.GetGpaList(str);
           // Assert.Equals(gpas[0].schoolyear, "2016-2017");
//            Assert.Equals();
       */ }
    }
}
