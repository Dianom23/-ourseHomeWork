using UnityEngine;

namespace HomeWork3.Exercise3
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private CoinSpawner _coinSpawner;

        private void Awake()
        {
            _coinSpawner.Initalize();
            _coinSpawner.StartWork();
        }
    }
}

