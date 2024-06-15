using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SkinChanger
{
    [Serializable]
    public class PersonsSkins
    {
        public List<Person> Persons;
        [HideInInspector] public int CurrentPersonIndex;
    }
    
    [Serializable]
    public class Person
    {
        [SerializeField] private string id;
        [SerializeField] private List<PersonSkins> skins;

        public Dictionary<Wallet.State, Skin> Skins =>
            skins.ToDictionary(skin => skin.WalletState, skin => skin.Skin);
    }

    [Serializable]
    public class PersonSkins
    {
        public Wallet.State WalletState;
        public Skin Skin;
    }

    [Serializable]
    public class Skin
    {
        public GameObject View;
    }
}