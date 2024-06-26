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

        private int maxSize;

        public int lastOperation = 0; 

        public DequeRealizer(int maxSize, int numElems)
        {
            if (maxSize <= numElems)
            {
                this.numElems = maxSize;
            }
            else
            {
                this.numElems = numElems;
            }
            this.list = new DoubleLinkedList<int>();
            
            this.maxSize = maxSize;

            Random rnd = new Random();
            for (int i = 0; i < numElems; i++)
            {
                list?.AddLast(rnd.Next(1, 10));
            }
        }

        public void InsertFirst(int value)
        {
            if (numElems < maxSize)
            {
                list?.AddFirst(value);
                numElems++;
                lastOperation = 1;
            }
            else
            {
                throw new IndexOutOfRangeException("Очередь переполнена!");
            }
        }

        public void InsertLast(int value)
        {
            if (numElems < maxSize)
            {
                list?.AddLast(value);
                numElems++;
                lastOperation = -1;
            }
            else
            {
                throw new IndexOutOfRangeException("Очередь переполнена!");
            }
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
            return new State(list, numElems, maxSize);
        }

        public void SetState(State state)
        {
            this.maxSize = state.maxSize;
            this.list = state.dequeState;
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
