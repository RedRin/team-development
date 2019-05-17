using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Lib.Tests
{
    /// <summary>
    /// MealcardTest 的摘要说明
    /// </summary>
    [TestClass]
    public class MealcardTest
    {
        Geticas icastest = new Geticas();
        int s = 1;
        //WebBrowser web = new WebBrowser();

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetSetCookie(string lpszUrlName, string lbszCookieName, string lpszCookieData);
        [TestMethod]
        public void Query()
        {
            WebBrowser web = new WebBrowser();
            icastest.Login("2016052351", "104213");
            try
            {
                icastest.Query();
                s--;
            }
            catch (Exception E) {
                Console.WriteLine(E);
                s--;
                Assert.Fail();
                
            }
        }

        /*[TestMethod]
        public void Login()
        {
            try
            {
                icastest.Login("2016052349", "191032");
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
                Assert.Fail();
            }
            //return ret;
        }*/
    }
}
