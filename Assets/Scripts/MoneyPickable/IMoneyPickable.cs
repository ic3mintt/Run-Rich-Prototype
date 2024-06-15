using MoneyPickable.DTO;
using UnityEngine;

namespace MoneyPickable
{
    public interface IMoneyPickable
    {
        public PickedData Pick(Transform target);
    }
}