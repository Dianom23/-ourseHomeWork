using System;
using UnityEngine;

namespace HomeWork3.Exercise3
{
    public class Player : MonoBehaviour, ICointPicker
    {
        [field: SerializeField] public int Coins { get; private set; }

        public void Add(int value)
        {
            if(value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            Coins += value;
            Debug.Log(Coins);
        }
    }
}

