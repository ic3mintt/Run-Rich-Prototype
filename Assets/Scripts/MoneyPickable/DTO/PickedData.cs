using System;

namespace MoneyPickable.DTO
{
    public struct PickedData
    {
        public int Money;
        public int MultiplicationFactor;

        
        public PickedData(int money, int multiplicationFactor = Int32.MinValue)
        {
            Money = money;
            MultiplicationFactor = multiplicationFactor;
        }
    }
}