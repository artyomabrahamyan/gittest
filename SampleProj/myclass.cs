using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj
{
    class myclass : ICloneable
    {
        public int Type { get; set; }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
