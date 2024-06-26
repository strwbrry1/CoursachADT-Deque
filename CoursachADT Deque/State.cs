using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursachADT_Deque
{
    public class State
    {
        public int numElems;

        public DoubleLinkedList<int>? dequeState;

        public State(DoubleLinkedList<int>? list, int numElems)
        {
            this.dequeState = list;
            this.numElems = numElems;
        }
    }
}
