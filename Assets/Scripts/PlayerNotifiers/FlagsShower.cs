using Player;
using UnityEngine;

namespace PlayerNotifiers
{
    public class FlagsShower: PlayerNotifier
    {
        [SerializeField] private AudioClip _audioClip;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private Animator _animator;

        private readonly int SHOW = Animator.StringToHash("Show");
        
        protected override void Notify(PlayerFacade player)
        {
            _animator.SetTrigger(SHOW);
            _audioSource.PlayOneShot(_audioClip);
        }
    }
}