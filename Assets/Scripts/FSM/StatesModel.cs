using System;
using System.Collections.Generic;
using UnityEngine;

namespace FSM
{
    [Serializable]
    public class StatesModel
    {
        [SerializeField] public ButtonState startState;
        [SerializeField] public WalletState playState;
        [SerializeField] public ButtonState winState;
        [SerializeField] public ButtonState looseState;

        public List<BaseState> States => new List<BaseState>() {startState, playState, winState, looseState};
    }
}