using MoneyPickable.DTO;
using UI.Bonus;
using UnityEngine;

namespace MoneyPickable
{
    public class ItemPickup: UnitDecorator
    {
        [SerializeField] private GameObject _instantiatePatent;
        [SerializeField] private GameObject _bonusShowerPrefab;
        
        public override PickedData Pick(Transform target)
        {
            if (_bonusShowerPrefab != null)
            {
                if(Instantiate(_bonusShowerPrefab, _instantiatePatent.transform).TryGetComponent(out BonusShower bonusShower))
                {
                    bonusShower.Show(Money);
                }
            }
            
            AudioSource.PlayOneShot(AudioClip);
            gameObject.SetActive(false);
            return new PickedData(Money);
        }
    }
}