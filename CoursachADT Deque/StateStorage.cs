using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursachADT_Deque
{
    public class StateStorage
    {
        private List<State> StateList;

        private int currentState;

        public StateStorage()
        {
            StateList = new List<State>();
            currentState = -1;
        }

        public void AddState(State state)
        {
            StateList.Add(state);
        }

        public State? GetCurrentState()
        {
            if (currentState >= 0 && currentState < StateList.Count) return StateList[currentState];

            return null;
        }


        public State? GetNextState()
        {
            if (StateList[currentState + 1] != null)
            {
                return StateList[++currentState];
            }
            return null;
        }

        public State? GetPrevState()
        {
            if (currentState - 1 > 0)
            {
                return StateList[--currentState];
            }
            return null;
        }

        public void Reset()
        {
            currentState = -1;
        }

        public bool NextState()
        {
            if (currentState + 1 >= StateList.Count) { return false; }
            currentState++;
            return true;
        }

        public bool PreviousState() 
        {
            if (currentState - 1 < 0) return false;
            currentState--;
            return true;
        }

        public void Traverse()
        {
            //TODO
        }

        public void SaveToFile(string filename)
        {
            //TODO
        }

        public void LoadFromFile(string filename)
        {
            StateList = new List<State>();
            //TODO
        }
    }
}
