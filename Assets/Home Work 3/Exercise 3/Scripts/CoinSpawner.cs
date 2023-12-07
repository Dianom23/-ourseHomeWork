using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HomeWork3.Exercise3
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private float _spawnCooldown;
        [SerializeField] private List<Transform> _spawnPointObjects;
        [SerializeField] private List<SpawnPoint> _spawnPoints;
        [SerializeField] private CoinFactory _coinFactory;

        private Coroutine _spawn;

        public void Initalize()
        {
            foreach (Transform spawnPointObject in _spawnPointObjects)
            {
                SpawnPoint spawnPoint = new SpawnPoint(spawnPointObject.position);
                _spawnPoints.Add(spawnPoint);
            }
        }

        public void StartWork()
        {
            StopWork();

            _spawn = StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                SpawnPoint spawnPoint = GetRandomSpawnPoin();              
                
                if (spawnPoint != null)
                {
                    Coin coin = _coinFactory.Get((CoinType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(CoinType)).Length));
                    coin.transform.position = spawnPoint.Position;
                    spawnPoint.SetOccupied(true, coin);
                    coin.UpCoin += OnCoinUp;
                }
                
                yield return new WaitForSeconds(_spawnCooldown);
            }
        }

        private void StopWork()
        {
            if(_spawn != null )
                StopCoroutine(_spawn);
        }

        private void OnCoinUp(Coin coin)
        {
            coin.UpCoin -= OnCoinUp;
            SpawnPoint spawnPoint = _spawnPoints.FirstOrDefault(spawnPoint =>  spawnPoint.Coin == coin);
            spawnPoint.SetOccupied(false, null);
        }


        private SpawnPoint GetRandomSpawnPoin()
        {
            List<SpawnPoint> unoccupiedSpawnPoints = new List<SpawnPoint>();

            foreach (SpawnPoint spawnPoint in _spawnPoints)
                if(spawnPoint.IsOccupied() == false)
                    unoccupiedSpawnPoints.Add(spawnPoint);

            if (unoccupiedSpawnPoints.Count == 0)
                return null;
            else
                return unoccupiedSpawnPoints[UnityEngine.Random.Range(0, unoccupiedSpawnPoints.Count)];
        }
    }
}
