using UnityEngine;
using Zenject;

namespace HomeWork4.Exercise2
{
    public class MediatorInstaller : MonoInstaller
    {
        [SerializeField] private DefeatPanel _defeatPanel;

        public override void InstallBindings()
        {
            Container.BindInstance(_defeatPanel).AsSingle();
            Container.BindInstance(new Level()).AsSingle();
            Container.BindInterfacesAndSelfTo<GameplayMediator>().AsSingle();
            Container.BindInterfacesAndSelfTo<MediatorBootstrap>().AsSingle();
        }
    }
}