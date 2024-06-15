using System;
using Player;
using TMPro;
using UnityEngine;

namespace FSM
{
    [Serializable]
    public class WinState: ButtonState
    {
        [SerializeField] private Wallet.View _wallet;

        [SerializeField] private TMP_Text _money;
        [SerializeField] private UI.Wheel wheel;
        
        public override void Enter(PlayerFacade playerFacade)
        {
            base.Enter(playerFacade);
            _money.text = (_wallet.Model.Money * _wallet.Model.MultiplicationFactor).ToString();
        }
    }
}