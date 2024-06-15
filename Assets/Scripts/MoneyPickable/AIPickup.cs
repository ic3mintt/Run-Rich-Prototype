using MoneyPickable.DTO;
using UnityEngine;

namespace MoneyPickable
{
    public class AIPickup: UnitDecorator
    {
        //Walk
        
        public override PickedData Pick(Transform target)
        {
            //apply effect
            //Play death animation
            //stop walk
            _audioSource.PlayOneShot(_audioClip);
            return new PickedData(Money);
        }
    }
}