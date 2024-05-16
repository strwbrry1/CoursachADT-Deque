using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursachADT_Deque
{
    public class ParameterClass
    {
        public int maxSize;
        public int numElems;

        public ParameterClass(int maxSize, int numElems)
        {
            this.maxSize = maxSize;
            this.numElems = numElems;
        }
    }
}
