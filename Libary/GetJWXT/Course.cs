using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.GetJWXT
{
    public class Course
    {
        public string classnumber;
        public string coursenumber;
        public string coursename;
        public string credit;
        public string type;
        public string category;
        public string time;
        public string teachername;
        public string location;
        public string ps;
        public string testtime;

        public Course(string classnumber, string coursenumber, string coursename, 
            string credit, string type, string category, string time, string teachername, string location, string ps, string testtime)
        {
            this.classnumber = classnumber;
            this.coursenumber = coursenumber;
            this.coursename = coursename;
            this.credit = credit;
            this.type = type;
            this.category = category;
            this.time = time;
            this.teachername = teachername;
            this.location = location;
            this.ps = ps;
            this.testtime = testtime;
        }
    }
}
