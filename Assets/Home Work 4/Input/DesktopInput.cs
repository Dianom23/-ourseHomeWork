using System;
using UnityEngine;
using Zenject;

namespace HomeWork4.Exercise2
{
    public class DesktopInput : IInput, ITickable
    {
        public event Action Defeat;

        public void Tick() => ProcessDefeat();

        private void ProcessDefeat()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Defeat?.Invoke();
        }
    }
}