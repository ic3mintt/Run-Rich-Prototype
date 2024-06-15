using System.Linq;
using Player;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FSM
{
    public class FSM : MonoBehaviour
    {
        [SerializeField] private PlayerFacade _playerFacade;
        [SerializeField] private StatesModel _statesModel;

        private BaseState currentState;

        private void Start()
        {
            currentState = _statesModel.startState;
            currentState.Enter(_playerFacade);
        }

        public void ChangeState(State nextState)
        {
            currentState.Exit(_playerFacade);

            if (nextState.Equals(State.Start))
            {
                Debug.Log("Reload");
                SceneManager.LoadScene(0);
            }
            
            //Change state to next one
            currentState = _statesModel.States.First(state => state.State.Equals(nextState));
            
            currentState.Enter( _playerFacade);
        }
    }
}