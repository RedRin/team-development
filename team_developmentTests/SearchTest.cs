using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lib.Tests
{
    [TestClass]
    public class SearchTest
    {
        NoticeSearch search = new NoticeSearch();

        [TestMethod]
        public void getHtmlTest()
        {
            try
            {
                search.getHtml("6");
            }
            catch (Exception E)
            {
                Assert.Fail();
            }
        }
    }
}
