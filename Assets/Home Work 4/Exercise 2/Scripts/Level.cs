using System;
using UnityEngine;

namespace HomeWork4.Exercise2
{
    public class Level
    {
        public event Action Defeat;

        public void Start()
        {
            //������ ������ ����
            Debug.Log("Start level");
        }

        public void Restart()
        {
            //������ ������� ������
            Start();
        }

        public void OnDefeat()
        {
            //������ ��������� ����
            Defeat?.Invoke();
        }
    }
}