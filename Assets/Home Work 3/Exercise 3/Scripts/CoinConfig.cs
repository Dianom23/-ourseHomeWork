using System;
using UnityEngine;

namespace HomeWork3.Exercise3
{
    [Serializable]
    public class CoinConfig
    {
        [SerializeField] private Coin _prefab;
        [SerializeField, Range(0, 50)] private int _value;

        public Coin Prefab => _prefab;
        public int Value => _value;
    }
}
