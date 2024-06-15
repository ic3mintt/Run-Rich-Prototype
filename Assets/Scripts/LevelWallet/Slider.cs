using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Wallet
{
    public class Slider : MonoBehaviour
    {
        [SerializeField] private UnityEngine.UI.Slider _slider;
        [SerializeField] private TMP_Text _tmpText;
        [SerializeField] private Image _fillAreaImage;
        [SerializeField] private float maxMoneyValue = 130f;

        public void ChangeValue(float currentMoney)
        {
            _slider.value = currentMoney / maxMoneyValue;
        }
        
        public void ChangeState(string stateName, Color color)
        {
            _tmpText.text = stateName;
            _tmpText.color = color;
            _fillAreaImage.color = color;
        }
    }
}