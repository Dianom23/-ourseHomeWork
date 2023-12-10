using Zenject;
using UnityEngine;

namespace HomeWork4.Exercise1
{
    public class EnemySpawnerInstaller : MonoInstaller
    {
        [SerializeField] private SpawnerConfig _spawnerConfig;
        [SerializeField] private SpawnPointsHandler _spawnPointsHandler;

        public override void InstallBindings()
        {
            Container.Bind<MonoBehaviour>().FromInstance(this).AsSingle();
            Container.BindInstance(_spawnPointsHandler).AsSingle();
            Container.BindInstance(_spawnerConfig).AsSingle();
            Container.Bind<EnemyFactory>().AsSingle();
            Container.BindInterfacesAndSelfTo<EnemySpawner>().AsSingle();
        }
    }
}