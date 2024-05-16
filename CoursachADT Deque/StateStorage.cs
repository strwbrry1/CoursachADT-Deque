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


        public State? GetState()
        {
            if (currentState >= 0 && currentState < StateList.Count)
            {
                return StateList[currentState];
            }
            return null;
        }

        public void Reset()
        {
            currentState = -1;
        }

        public bool NextState()
        {
            currentState++;
            return currentState < StateList.Count;
        }

        public void Traverse()
        {
            while (NextState())
            {
                //StateList.GetState();
            }
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
