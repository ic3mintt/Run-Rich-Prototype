using System.Collections.Generic;
using System.Linq;
using Player;
using UnityEngine;

namespace FSM
{
    public class FSM : MonoBehaviour
    {
        [SerializeField] private PlayerFacade _playerFacade;
        [SerializeField] private StatesModel _statesModel;

        private BaseState currentState;

        private void Awake()
        {
            currentState = _statesModel.startState;
            currentState.Enter(_playerFacade);
        }

        public void ChangeState(State nextState)
        {
            currentState.Exit(_playerFacade);
            
            //Change state to next one
            currentState = _statesModel.States.First(state => state.State.Equals(nextState));
            
            currentState.Enter( _playerFacade);
        }
    }
}