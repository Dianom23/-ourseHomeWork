namespace HomeWork4.Exercise3
{
    public class SceneLoadMediator : ISceneLoadMediator
    {
        private ISimpleSceneLoader _simpleSceneLoader;
        private ILevelLoader _levelLoader;

        public SceneLoadMediator(ISimpleSceneLoader simpleSceneLoader, ILevelLoader levelLoader)
        {
            _simpleSceneLoader = simpleSceneLoader;
            _levelLoader = levelLoader;
        }

        public void GoToGameplayLevel(LevelLoadingData levelLoadingData)
            => _levelLoader.Load(levelLoadingData);

        public void GoToLevelSelection()
            => _simpleSceneLoader.Load(SceneID.MainMenu);
    }
}