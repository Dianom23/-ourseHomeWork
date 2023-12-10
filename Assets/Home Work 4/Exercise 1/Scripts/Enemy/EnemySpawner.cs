using System;
using System.Collections;
using UnityEngine;

namespace HomeWork4.Exercise1
{
    public class EnemySpawner : IPause
    {
        private EnemyFactory _enemyFactory;

        private Coroutine _spawn;

        private MonoBehaviour _context;

        private SpawnerConfig _config;
        private SpawnPointsHandler _spawnPointsHandler;

        private PauseHandler _pauseHandler;
        private bool _isPaused;

        public EnemySpawner(EnemyFactory enemyFactory, PauseHandler pauseHandler, MonoBehaviour context, SpawnerConfig config, SpawnPointsHandler spawnPointsHandler)
        {
            _enemyFactory = enemyFactory;
            _pauseHandler = pauseHandler;
            _context = context;
            _config = config;
            _spawnPointsHandler = spawnPointsHandler;
            _pauseHandler.Add(this);
        }

        public void SetPause(bool isPaused) => _isPaused = isPaused;

        public void StartWork()
        {
            StopWork();
            _context.StartCoroutine(Spawn());
        }

        public void StopWork()
        {
            if (_spawn != null)
                _context.StopCoroutine(_spawn);
        }

        private IEnumerator Spawn()
        {
            float time = 0;

            while (true)
            {
                while (time < _config.SpawnCooldown)
                {
                    if (_isPaused == false)
                        time += Time.deltaTime;

                    yield return null;
                }

                Enemy enemy = _enemyFactory.Get((EnemyType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
                enemy.MoveTo(_spawnPointsHandler.SpawnPoints[UnityEngine.Random.Range(0, _spawnPointsHandler.SpawnPoints.Count)].position);
                time = 0;
            }
        }
    }
}