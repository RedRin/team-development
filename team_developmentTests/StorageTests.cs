using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lib.Tests
{
    [TestClass()]
    public class StorageTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            int a = 3;
            Storage.Save(a, "./testload.xml");
        }
        [TestMethod()]
        public void SaveTest()
        {
            int a = 3;
            Storage.Save(a, "./testsave.xml");
            File.Exists("./testsave.xml");
        }

        [TestMethod()]
        public void LoadTest()
        {
            int a = (int)Storage.Load("./testload.xml");
            if (3 != a)
            {
                Assert.Fail();
            }
        }
    }
}