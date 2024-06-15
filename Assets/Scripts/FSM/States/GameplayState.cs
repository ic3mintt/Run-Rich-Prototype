using System;
using PlayerNotifiers;
using UnityEngine;

namespace FSM
{
    [Serializable]
    public class GameplayState: BaseState
    {
        [SerializeField] private Wallet.View _view;

        public override void Enter(Player.PlayerFacade playerFacade)
        {
            base.Enter(playerFacade);
            playerFacade.MoveFromStart();
            _view.Model.OnBroken += () => Fsm.ChangeState(State.Loose);
            WinArea.OnWon += () => Fsm.ChangeState(State.Win);
        }

        public override void Exit(Player.PlayerFacade playerFacade)
        {
            base.Exit(playerFacade);
            playerFacade.Stop();
            _view.Model.OnBroken -= () => Fsm.ChangeState(State.Loose);
            WinArea.OnWon -= () => Fsm.ChangeState(State.Win);
        }
    }
}