using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CoursachADT_Deque
{
    [Serializable]
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

        public State? GetLastState()
        {
            currentState = StateList.Count - 1;
            return StateList[currentState];
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
            currentState = 0;
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

        public void SaveToFile(string filename)
        {
            using (FileStream fs = new(filename, FileMode.Create))
            {
                #pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this);

            }
        }

        public void LoadFromFile(string filename)
        {
            StateList = new List<State>();
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                StateList = ((StateStorage)bf.Deserialize(fs)).StateList;
            }
            
        }
    }
}
