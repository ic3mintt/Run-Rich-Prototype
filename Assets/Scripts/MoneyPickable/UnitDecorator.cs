using MoneyPickable.DTO;
using UnityEngine;

namespace MoneyPickable
{
    [RequireComponent(typeof(Collider), typeof(AudioSource))]
    public abstract class UnitDecorator : MonoBehaviour, IMoneyPickable
    {
        [SerializeField] protected int Money;
        [SerializeField] protected AudioClip AudioClip;
        [SerializeField] protected AudioSource AudioSource;
        
        // [SerializeField] private Effect pickUpEffect

        public abstract PickedData Pick(Transform target);
    }
}