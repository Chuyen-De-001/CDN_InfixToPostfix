using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDN.Entity
{
    class bracket
    {
        public int vStart { get; set; }
        public int vEnd { get; set; }
        public bracket()
        {
        }

        public bracket(int s, int e)
        {
            this.vStart = s;
            this.vEnd = e;
        }
    }
}
