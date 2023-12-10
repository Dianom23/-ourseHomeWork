using HomeWork3.Exercise4;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HomeWork3.Exercise4
{
    public class Spawner: MonoBehaviour, IEnemyDeathNotifier, IEnemyCreateNotifier
    {
        public event Action<Enemy> EnemyDeathNotified;
        public event Action<Enemy> CreateEnemyNotified;

        [SerializeField] private float _spawnCooldown;
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private EnemyFactory _enemyFactory;
        [SerializeField] private int _maxEnemiesWeight;

        private List<Enemy> _spawnedEnemies = new List<Enemy>();

        private Coroutine _spawn;
        private EnemiesWeight _enemyWeight;

        public void Intialize(EnemiesWeight enemiesWeight)
        {
            _enemyWeight = enemiesWeight;
        }

        public void StartWork()
        {
            StopWork();

            _spawn = StartCoroutine(Spawn());
        }

        public void StopWork()
        {
            if (_spawn != null)
                StopCoroutine(_spawn);
        }

        public void KillRandomEnemy()
        {
            if (_spawnedEnemies.Count == 0)
                return;

            _spawnedEnemies[UnityEngine.Random.Range(0, _spawnedEnemies.Count)].Kill();
        }

        private IEnumerator Spawn()
        {
            while (_enemyWeight.Value < _maxEnemiesWeight)
            {
                Enemy enemy = _enemyFactory.Get((EnemyType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
                enemy.MoveTo(_spawnPoints[UnityEngine.Random.Range(0, _spawnPoints.Count)].position);
                enemy.Died += OnEnemyDied;
                _spawnedEnemies.Add(enemy);
                CreateEnemyNotified?.Invoke(enemy);
                yield return new WaitForSeconds(_spawnCooldown);
            }
        }

        private void OnEnemyDied(Enemy enemy)
        {
            EnemyDeathNotified?.Invoke(enemy);
            enemy.Died -= OnEnemyDied;
            _spawnedEnemies.Remove(enemy);
        }
    }
}
