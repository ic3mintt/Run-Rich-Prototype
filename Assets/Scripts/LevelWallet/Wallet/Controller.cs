namespace Wallet
{
    public class Controller
    {
        private readonly Model _model;
        
        public Controller(Model model)
        {
            _model = model;
        }

        public void Add(float money)
        {
            _model.Money += money;
            if (_model.Money <= 0)
            {
                _model.Money = 0f;
                _model.OnBrokeInvoke();
            }
        }
    }
}