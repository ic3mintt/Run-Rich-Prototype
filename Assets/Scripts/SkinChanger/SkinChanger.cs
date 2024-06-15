using UnityEngine;

namespace SkinChanger
{
    public class SkinChanger: MonoBehaviour, ISkinChangable
    {
        [SerializeField] private PersonsSkins _personsSkins;
        [SerializeField] private Wallet.View wallet;
        [SerializeField] private Wallet.State currentState = Wallet.State.Poor;

        private void Start()
        {
            ChangeSkinByWalletState(wallet.Model.State);
        }

        public void ChangeSkinByWalletState(Wallet.State nextState)
        {
            if(currentState.Equals(nextState))
                return;
            
            var currentSkin = _personsSkins.Persons[_personsSkins.CurrentPersonIndex].Skins[currentState];
            var nextSkin = _personsSkins.Persons[_personsSkins.CurrentPersonIndex].Skins[nextState];
            currentSkin.View.SetActive(false);
            nextSkin.View.SetActive(true);
            currentState = nextState;
        }
    }
}