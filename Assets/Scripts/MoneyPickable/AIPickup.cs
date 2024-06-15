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
            AudioSource.PlayOneShot(AudioClip);
            return new PickedData(Money);
        }
    }
}