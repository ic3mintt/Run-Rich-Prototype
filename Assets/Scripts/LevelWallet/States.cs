using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Wallet
{
    [CreateAssetMenu(fileName = "Wallet states", menuName = "ScriptableObjects/WalletStates", order = 0)]
    public class States : ScriptableObject
    {
        [SerializeField] private List<StateData> _statesData;
        [SerializeField] private List<StateSliderColor> _statesColors;

        public StateData GetStateDataByState(State state)
        {
            return _statesData.First(stateData => stateData.State.Equals(state));
        }
        
        public StateData GetStateDataByMoney(float money)
        {
            return _statesData.First(state => money > state.MinMoney && money < state.MaxMoney);
        }

        public Color GetColorByStateData(StateData stateData)
        {
            return _statesColors.First(state => state.State == stateData.State).Color;
        }
    }
}