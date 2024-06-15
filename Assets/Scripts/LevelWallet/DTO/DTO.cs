using System;
using UnityEngine;

namespace Wallet
{
    public enum State
    {
        Poor,
        Normal,
        Rich
    }

    [Serializable]
    public struct StateData
    {
        public State State;
        public string Name;
        public float MinMoney;
        public float MaxMoney;
    }
    
    [Serializable]
    public struct StateSliderColor
    {
        public State State;
        public Color Color;
    }
}