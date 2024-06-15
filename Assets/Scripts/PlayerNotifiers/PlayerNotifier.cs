using Player;
using UnityEngine;

namespace PlayerNotifiers
{
    [RequireComponent(typeof(Collider))]
    public abstract class PlayerNotifier : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out PlayerFacade player))
            {
                Notify(player);
            }
        }

        protected abstract void Notify(PlayerFacade player);
    }
}