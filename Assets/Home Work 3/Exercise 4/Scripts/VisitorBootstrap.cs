using UnityEngine;

namespace Assets.Visitor
{
    public class VisitorBootstrap: MonoBehaviour
    {
        [SerializeField] private Spawner _spawner;

        private Score _score;
        private EnemiesWeight _enemiesWeight;

        private void Awake()
        {
            _score = new Score(_spawner);
            _enemiesWeight = new EnemiesWeight(_spawner);

            _spawner.Intialize(_enemiesWeight);
            _spawner.StartWork();
        }

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space)) 
                _spawner.KillRandomEnemy();
        }
    }
}
