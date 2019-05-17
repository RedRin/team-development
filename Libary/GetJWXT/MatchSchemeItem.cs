using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.GetJWXT
{
    public class MatchSchemeItem
    {
        public List<string> needs;
        public List<string> study;
        public List<string> lefts;

        public MatchSchemeItem(List<string> needs, List<string> study, List<string> lefts)
        {
            this.needs = needs;
            this.study = study;
            this.lefts = lefts;
        }
    }
}
