using Microsoft.VisualStudio.TestTools.UnitTesting;
using team_development.FormLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team_development.UI.CourseSelection;
using System.Windows.Forms;

namespace team_development.FormLib.Tests
{
    [TestClass()]
    public class MenuGetterTests
    {
        [TestMethod()]
        public void GetCourseSelectionTest()
        {
            Assert.AreEqual(MenuGetter.GetMenu(MenuType.JWXT,SubMenuType.CourseSelection), MenuGetter.CourseSelectionInstance);
        }
        [TestMethod()]
        public void GetMatchSchemeTest()
        {
            Assert.AreEqual(MenuGetter.GetMenu(MenuType.JWXT, SubMenuType.MatchScheme), MenuGetter.MatchSchemeInstance);
        }
        [TestMethod()]
        public void GetAbsenceTest()
        {
            Assert.AreEqual(MenuGetter.GetMenu(MenuType.Absence), MenuGetter.AbsenceInstance);
        }
        [TestMethod()]
        public void GetQueryCostTest()
        {
            Assert.AreEqual(MenuGetter.GetMenu(MenuType.Query,SubMenuType.QueryCost), MenuGetter.QueryCostInstance);
        }
        [TestMethod()]
        public void GetQueryEmployTest()
        {
            Assert.AreEqual(MenuGetter.GetMenu(MenuType.Query, SubMenuType.QueryEmploy), MenuGetter.QueryEmployInstance);
        }
        [TestMethod()]
        public void GetQueryInformTest()
        {
            Assert.AreEqual(MenuGetter.GetMenu(MenuType.Query, SubMenuType.QueryInform), MenuGetter.QueryInformInstance);
        }
        [TestMethod()]
        public void GetQueryMarkTest()
        {
            Assert.AreEqual(MenuGetter.GetMenu(MenuType.Query, SubMenuType.QueryMark), MenuGetter.QueryMarkInstance);
        }
        [TestMethod()]
        public void GetQueryMealCardTest()
        {
            Assert.AreEqual(MenuGetter.GetMenu(MenuType.Query, SubMenuType.QueryMealCard), MenuGetter.QueryMealCardInstance);
        }
        [TestMethod()]
        public void GetUserInfoTest()
        {
            Assert.AreEqual(MenuGetter.GetMenu(MenuType.UserInfo), MenuGetter.UserInfoInstance);
        }
    }
}