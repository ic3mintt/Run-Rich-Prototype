using System;
using Player;
using UnityEngine;

namespace PlayerNotifiers
{
    public class WinArea : PlayerNotifier
    {
        public static event Action OnWon;
        
        protected override void Notify(PlayerFacade player)
        {
            OnWon?.Invoke();
        }
    }
}