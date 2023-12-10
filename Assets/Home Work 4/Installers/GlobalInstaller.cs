using HomeWork4.Exercise3;
using Zenject;

namespace HomeWork4.Exercise2
{
    public class GlobalInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindInput();
            BindLoader();
        }

        private void BindLoader()
        {
            Container.Bind<ZenjectSceneLoaderWrapper>().AsSingle();
            Container.BindInterfacesAndSelfTo<SceneLoader>().AsSingle();
            Container.BindInterfacesAndSelfTo<SceneLoadMediator>().AsSingle();
        }

        private void BindInput() => Container.BindInterfacesAndSelfTo<DesktopInput>().AsSingle();
    }
}