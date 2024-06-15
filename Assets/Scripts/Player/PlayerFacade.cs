using System.Collections;
using Input;
using MoneyPickable;
using UnityEngine;

namespace Player
{
    public class PlayerFacade : MonoBehaviour
    {
        [SerializeField] private InputHandler inputHandler;
        [SerializeField] private Mover.Model moverModel;
        [SerializeField] private Wallet.View wallet;

        private Wallet.State lastState;
        
        private Mover.IMovable _movable;
        private SkinChanger.ISkinChangable _skinChangable;
        

        private void Awake()
        {
            _movable = new Mover.Controller(moverModel);
            var skinChanger = GetComponentInChildren<SkinChanger.SkinChanger>();
            if (skinChanger != null)
            {
                _skinChangable = skinChanger;
            }
        }
        
        //turn on and off for start, win, loose
        //start _movable.GoZ();
        private void OnEnable()
        {
            inputHandler.OnStepChange += _movable.MoveHorizontal;
            wallet.Model.OnStateChanged += _skinChangable.ChangeSkinByWalletState;
        }

        private void OnDisable()
        {
            inputHandler.OnStepChange -= _movable.MoveHorizontal;
            wallet.Model.OnStateChanged -= _skinChangable.ChangeSkinByWalletState;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IMoneyPickable moneyPickable))
            {
                wallet.Add(moneyPickable.Pick(transform));
            }
        }

        private void Update()
        {
            _movable.Move(Time.deltaTime);
        }

        public void TurnTo(Quaternion target)
        {
            StartCoroutine(Turn(target));
        }

        public void Stop()
        {
            _movable.Stop();
        }

        public void MoveFromStart()
        {
            moverModel.IsAllowedToMove = true;
            
        }

        private IEnumerator Turn(Quaternion target)
        {
            while (!transform.rotation.Equals(target))
            {
                _movable.TurnTo(target, Time.deltaTime);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}