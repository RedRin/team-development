using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.GetJWXT
{
    public class Gpa
    {
        public string schoolyear;
        public string semester;
        public  string coursename;
        public float credit;
        public float mark;
        public float gp;
        public string coursecategory;

       public Gpa(string schoolyear, string semester, string coursename, float credit, float mark,
            float gp, string coursecategory)
        {
            this.schoolyear = schoolyear;
            this.semester = semester;
            this.coursename = coursename;
            this.credit = credit;
            this.mark = mark;
            this.gp = gp;
            this.coursecategory = coursecategory;
        }
    }
}
