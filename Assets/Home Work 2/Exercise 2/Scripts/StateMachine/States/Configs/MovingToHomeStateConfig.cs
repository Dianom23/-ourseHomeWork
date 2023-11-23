using System;
using UnityEngine;

namespace HomeWork2.Exercise2
{
    [Serializable]
    public class MovingToHomeStateConfig
    {
        [SerializeField, Range(1, 10)] private float _speed;

        public float Speed => _speed;
    }
}
