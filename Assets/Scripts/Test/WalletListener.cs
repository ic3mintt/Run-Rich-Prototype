using System;
using TMPro;
using UnityEngine;

namespace Test
{
    public class WalletListener : MonoBehaviour
    {
        [SerializeField] private TMP_Text walletTMP;

        public void Change(float money)
        {
            walletTMP.text = money.ToString();
        }
    }
}