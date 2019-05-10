using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.GetInfo
{
    class GetInfo
    {
        HTMLHelper htmlHelper = new HTMLHelper();
        public string LoginDigitJnu(string username,string pwd) {
            HttpHeader header = new HttpHeader();
            string postDate="";
            return htmlHelper.Login("", header, postDate);
        }
    }
}
