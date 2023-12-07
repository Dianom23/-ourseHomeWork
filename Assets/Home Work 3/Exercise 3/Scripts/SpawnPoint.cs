using System;
using UnityEngine;

namespace HomeWork3.Exercise3
{
    [Serializable]
    public class SpawnPoint
    {

        [SerializeField] private Vector3 _position;
        [SerializeField] private Coin _coin;

        public Vector3 Position => _position;
        public Coin Coin => _coin;

        public SpawnPoint(Vector3 position) => _position = position;

        public void SetOccupied(bool isOccupied, Coin coin)
        {
            _coin = coin;
        }

        public bool IsOccupied()
        {
            if (_coin != null)
                return true;
            else
                return false;
        }
    }
}
