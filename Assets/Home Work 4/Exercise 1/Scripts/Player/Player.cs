using UnityEngine;
using Zenject;

namespace HomeWork4.Exercise1
{
    public class Player : MonoBehaviour, IEnemyTarget
    {
        private int _maxHealth;
        private int _health;

        public Vector3 Position => transform.position;

        [Inject]
        private void Construct(PlayerStatsConfig playerStatsConfig)
        {
            _health = _maxHealth = playerStatsConfig.MaxHealth;
            Debug.Log($"� ���� {_health} ��");
        }

        public void TakeDamage(int damage)
        {
            //�������� �����

            Debug.Log($"������� {damage} �����");
        }
    }
}