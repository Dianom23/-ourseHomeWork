using Zenject;

namespace HomeWork4.Exercise1
{
    public class ServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<PauseHandler>().AsSingle();
        }
    }
}