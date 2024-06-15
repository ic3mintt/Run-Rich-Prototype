using System;
using UnityEngine;

namespace Wallet
{
    [Serializable]
    public class Model
    {
        private State state;
        
        public int MultiplicationFactor = 1;
        public float Money = 40f;
        public State State
        {
            set
            {
                state = value;
                OnStateChangedInvoke();
            }
            get => state;
        }
 
        public event Action<State> OnStateChanged;
        public event Action OnBroken;

        public void OnBrokeInvoke()
        {
            OnBroken?.Invoke();
        }

        private void OnStateChangedInvoke()
        {
            OnStateChanged?.Invoke(State);
        }
    }
}