using Zenject;

namespace HomeWork4.Exercise3
{
    public class LevelInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<Level>().AsSingle();
        }
    }
}