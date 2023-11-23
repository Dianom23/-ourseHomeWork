using System;
using UnityEngine;

namespace HomeWork2.Exercise2
{
    [Serializable]  
    public class WorkingStateConfig
    {
        [SerializeField, Range(0, 10)] private float _workingDuration;

        public float WorkingDuration => _workingDuration;
    }
}
