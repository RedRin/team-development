using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team_development.UI.UserInfo;

namespace team_developmentTests
{
    [TestClass()]
    public class StorageTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            string password = "abc";
            Cryptography c = new Cryptography();
            password = c.Encryption(password);
            Storage.Save(password,"./passwordload.xml");
        }
        [TestMethod()]
        public void SaveTest()
        {
            string password = "edf";
            Cryptography c = new Cryptography();
            password = c.Encryption(password);
            Storage.Save(password, "./passwordsave.xml");
            password = (String)Storage.Load("./passwordsave.xml");
            if(password=="edf")
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void LoadTest()
        {
            Cryptography c = new Cryptography();
            string password = c.Decrypt((string)Storage.Load("./passwordload.xml"));
            if (password!="abc")
            {
                Assert.Fail();
            }
        }
    }
}
