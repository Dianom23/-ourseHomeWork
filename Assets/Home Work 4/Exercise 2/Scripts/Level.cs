using System;
using UnityEngine;

namespace HomeWork4.Exercise2
{
    public class Level
    {
        public event Action Defeat;

        public void Start()
        {
            //Логика старта игры
            Debug.Log("Start level");
        }

        public void Restart()
        {
            //Логика очистки уровни
            Start();
        }

        public void OnDefeat()
        {
            //логика остановки игры
            Defeat?.Invoke();
        }
    }
}