using MoneyPickable.DTO;
using UnityEngine;

namespace MoneyPickable
{
    public class ItemPickup: UnitDecorator
    {
        public override PickedData Pick(Transform target)
        {
            //apply effect on target
            _audioSource.PlayOneShot(_audioClip);
            gameObject.SetActive(false);
            return new PickedData(Money);
        }
    }
}