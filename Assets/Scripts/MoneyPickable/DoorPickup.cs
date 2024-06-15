using MoneyPickable.DTO;
using TMPro;
using UnityEngine;

namespace MoneyPickable
{
    [RequireComponent(typeof(Animator))]
    public class DoorPickup: UnitDecorator
    {
        [SerializeField] private int multiplicationFactor = 2;
        [SerializeField] private TMP_Text _multiplicationFactorText;
        [SerializeField] private Animator _animator;
        
        private readonly int OPEN = Animator.StringToHash("Open");

        private void Awake()
        {
            _multiplicationFactorText.text = $"X{multiplicationFactor}";
        }

        public override PickedData Pick(Transform target)
        {
            _animator.SetTrigger(OPEN);
            AudioSource.PlayOneShot(AudioClip);
            return new PickedData(0, multiplicationFactor);
        }
    }
}