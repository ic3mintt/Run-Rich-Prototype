using System;
using UnityEngine;

namespace FSM
{
    [Serializable]
    public class ButtonState: BaseState
    {
        [SerializeField] private State _nextState;

        public override void Enter(Player.PlayerFacade playerFacade)
        {
            base.Enter(playerFacade);
            playerFacade.Stop();
            if(CanvasInfo.NextLevelButton != null)
                CanvasInfo.NextLevelButton.onClick.AddListener(() => Fsm.ChangeState(_nextState));
        }

        public override void Exit(Player.PlayerFacade playerFacade)
        {
            base.Exit(playerFacade);
            playerFacade.MoveFromStart();
            if(CanvasInfo.NextLevelButton != null)
                CanvasInfo.NextLevelButton.onClick.RemoveListener(() => Fsm.ChangeState(_nextState));
        }
    }
}