namespace SkinChanger
{
    public interface ISkinChangable
    {
        public void ChangeSkinByWalletState(Wallet.State nextState);
    }
}