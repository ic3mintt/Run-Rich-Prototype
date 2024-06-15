using System;
using Player;
using UnityEngine;

namespace FSM
{
    [Serializable]
    public abstract class BaseState
    {
        [SerializeField] protected FSM Fsm;
        [SerializeField] protected CanvasInfo CanvasInfo;

        public State State;

        public virtual void Enter(PlayerFacade playerFacade)
        {
            CanvasInfo.Canvas.gameObject.SetActive(true);
        }

        public virtual void Exit(PlayerFacade playerFacade)
        {
            CanvasInfo.Canvas.gameObject.SetActive(false);
        }
    }
}