using System;
using UnityEngine;

namespace HomeWork2.Exercise2
{
    [Serializable]
    public class RestingStateConfig
    {
        [SerializeField, Range(0, 10)] private float _restingDuration;   

        public float RestingDuration => _restingDuration;
    }
}
