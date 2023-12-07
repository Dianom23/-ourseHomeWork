using System;
using UnityEngine;

namespace HomeWork3.Exercise3
{
    public abstract class Coin : MonoBehaviour
    {
        public event Action<Coin> UpCoin;

        protected int Value;

        public void Initialize(int value) => Value = value;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out ICointPicker cointPicker))
            {
                AddCoin(cointPicker);
                UpCoin?.Invoke(this);
                Destroy(gameObject);
            }
        }

        protected abstract void AddCoin(ICointPicker cointPicker);
    }
}
