using System.Collections.Generic;
using UnityEngine;

namespace HomeWork4.Exercise1
{
    public class SpawnPointsHandler : MonoBehaviour
    {
        private List<Transform> _spawnPoints = new List<Transform>();

        public List<Transform> SpawnPoints => _spawnPoints;

        private void Awake()
        {
            foreach (Transform child in transform)
                _spawnPoints.Add(child);
        }
    }
}