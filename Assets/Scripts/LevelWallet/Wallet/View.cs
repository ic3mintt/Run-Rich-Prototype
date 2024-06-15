using System;
using MoneyPickable.DTO;
using UnityEngine;

namespace Wallet
{
    public class View : MonoBehaviour
    {
        [SerializeField] private Test.WalletListener _listener;
        
        //private Effect MoneyAppearingEffect; +5$ ...
        [SerializeField] private States _states;
        [SerializeField] private Slider _slider;
        private Controller _controller;
        
        public Model Model;

        private void Awake()
        {
            _controller = new Controller(Model);
            var stateData = _states.GetStateDataByMoney(Model.Money);
            Model.State = stateData.State;
            _slider.ChangeValue(Model.Money);
            _slider.ChangeState(stateData.Name,
                _states.GetColorByStateData(stateData));
            
            _listener.Change(Model.Money);
        }
        
        public void Add(PickedData pickedData)
        {
            if (pickedData.Money != 0)
            {
                _controller.Add(pickedData.Money);
                _slider.ChangeValue(Model.Money);
                SetState(_states.GetStateDataByMoney(Model.Money));
                //Effect.Show();
            }

            if (pickedData.MultiplicationFactor != Int32.MinValue)
            {
                Model.MultiplicationFactor = pickedData.MultiplicationFactor;
            }
            
            
            
            _listener.Change(Model.Money);
        }

        private void SetState(StateData stateData)
        {
            if(Model.State.Equals(stateData.State))
                return;
            Model.State = stateData.State;
            _slider.ChangeState(stateData.Name, _states.GetColorByStateData(stateData));
        }
    }
}