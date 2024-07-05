using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursachADT_Deque
{
    [Serializable]
    public class State
    {
        public int numElems;

        public DoubleLinkedList<int>? dequeState;

        public State(DoubleLinkedList<int>? list, int numElems)
        {
            this.dequeState = new DoubleLinkedList<int>();
            Node<int> curr = list.getHeadPointer();
            while (curr != null) 
            {
                this.dequeState.AddLast(curr.data);
                curr = curr.next;
            }
            this.numElems = numElems;
        }
    }
}
