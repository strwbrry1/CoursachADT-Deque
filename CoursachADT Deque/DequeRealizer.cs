using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursachADT_Deque
{
    public class DequeRealizer
    {
        public DoubleLinkedList<int>? list;

        public int numElems;

        public int lastOperation = 0;

        public DequeRealizer(int numElems)
        {

            this.numElems = numElems;
            this.list = new DoubleLinkedList<int>();


            Random rnd = new Random();
            for (int i = 0; i < numElems; i++)
            {
                list?.AddLast(rnd.Next(1, 10));
                lastOperation = 1;
            }
        }

        public void InsertFirst(int value)
        {

            list?.AddFirst(value);
            numElems++;
            lastOperation = 1;

        }

        public void InsertLast(int value)
        {

            list?.AddLast(value);
            numElems++;
            lastOperation = -1;

        }

        public int PopFirst()
        {
            if (list == null || numElems == 0)
            {
                return -1;
            }
            int temp = list.getHead();
            list.RemoveHead();
            numElems--;
            lastOperation = 1;
            return temp;
        }

        public int PopLast()
        {
            if (list == null || numElems == 0)
            {
                return -1;
            }
            int temp = list.getTail();
            list.RemoveTail();
            numElems--;
            lastOperation = -1;
            return temp;
        }

        public void Step()
        {
            //TODO: выполнение одного шага операции
        }

        public State SaveState()
        {
            return new State(list, numElems);
        }

        public void SetState(State? state)
        {
            if (state == null || state.dequeState == null) return;
            Node<int> curr = state.dequeState.getHeadPointer();
            this.list.Clear();
            while (curr != null)
            {
                this.list.AddLast(curr.data);
                curr = curr.next;
            }
            //this.list = state.dequeState;
            this.numElems = state.numElems;
        }

        public bool isEmpty()
        {
            return list.isEmpty();
        }

        public void Clear()
        {
            list.Clear();
            numElems = 0;
        }


    }
}
