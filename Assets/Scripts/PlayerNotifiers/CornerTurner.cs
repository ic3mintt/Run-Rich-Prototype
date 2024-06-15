using Player;
using UnityEngine;

namespace PlayerNotifiers
{
    public class CornerTurner : PlayerNotifier
    {
        [SerializeField] private Transform _exitRotation;//direction

        protected override void Notify(PlayerFacade player)
        {
            player.TurnTo(_exitRotation.rotation);
        }
    }
}