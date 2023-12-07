using System;
using UnityEngine;

namespace HomeWork3.Exercise3
{
    [CreateAssetMenu(fileName = "CoinFactory", menuName = "Factory/CoinFactory")]
    public class CoinFactory : ScriptableObject
    {
        [SerializeField] private CoinConfig _standart, _random, _empty;

        public Coin Get(CoinType coinType)
        {
            CoinConfig config = GetConfig(coinType);
            Coin instance = Instantiate(config.Prefab);
            instance.Initialize(config.Value);
            return instance;
        }

        private CoinConfig GetConfig(CoinType coinType)
        {
            switch (coinType)
            {
                case CoinType.Standart:
                    return _standart;

                case CoinType.Random:
                    return _random;

                case CoinType.Empty:
                    return _empty;

                default:
                    throw new ArgumentException(nameof(coinType));
            }
        }
    }
}
