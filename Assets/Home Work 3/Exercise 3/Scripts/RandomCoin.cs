using UnityEngine;

namespace HomeWork3.Exercise3
{
    public class RandomCoin : Coin
    {
        protected override void AddCoin(ICointPicker cointPicker) => cointPicker.Add(Random.Range(0, Value));
    }
}

