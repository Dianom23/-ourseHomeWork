namespace HomeWork4.Exercise3
{
    public interface ISceneLoadMediator
    {
        void GoToLevelSelection();

        void GoToGameplayLevel(LevelLoadingData levelLoadingData);
    }
}