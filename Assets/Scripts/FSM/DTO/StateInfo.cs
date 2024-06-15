using System;
using UnityEngine.UI;

namespace FSM
{
    [Serializable]
    public struct StateInfo
    {
        public State State;
        public Button Button;
        public Wallet.View Wallet;
    }
}