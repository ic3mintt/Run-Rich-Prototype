using System;
using Player;
using UnityEngine;

namespace PlayerNotifiers
{
    public class WinArea : PlayerNotifier
    {
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private AudioClip audioClip;
        
        public static event Action OnWon;
        
        protected override void Notify(PlayerFacade player)
        {
            OnWon?.Invoke();
            _audioSource.PlayOneShot(audioClip);
        }
    }
}