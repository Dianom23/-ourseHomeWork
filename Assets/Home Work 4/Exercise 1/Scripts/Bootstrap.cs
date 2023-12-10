using UnityEngine;
using Zenject;

namespace HomeWork4.Exercise1
{
    public class Bootstrap : MonoBehaviour
    {
        private EnemySpawner _spawner;
        private PauseHandler _pauseHandler;

        [Inject]
        private void Construct(EnemySpawner spawner, PauseHandler pauseHandler)
        {
            _spawner = spawner;
            _pauseHandler = pauseHandler;
        }

        private void Awake() => _spawner.StartWork();

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.F))
                _pauseHandler.SetPause(true);

            if (Input.GetKeyUp(KeyCode.S))
                _pauseHandler.SetPause(false);
        }
    }
}