using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using team_development.UI.CourseSelection;

namespace team_developmentTests
{
    [TestClass]
    public class CourseLoadTest
    {
        [TestMethod]
        public void LoadTest()
        {
            string classnumber = "201925665";
            CourseSelection course = new CourseSelection();
            course.GetCourse();
            Console.WriteLine("test");
            string temp = "";
            temp = course.CourseInfo.Items[0].ToString();
            temp = System.Text.RegularExpressions.Regex.Replace(temp, @"[^0-9]+", "");
            Console.WriteLine(temp);
            if(temp!=classnumber)
            {
                Assert.Fail();
            }
            
        }
    }
}
