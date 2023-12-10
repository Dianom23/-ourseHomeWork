using System;

namespace HomeWork4.Exercise3
{
    public class SceneLoader : ISimpleSceneLoader, ILevelLoader
    {
        private ZenjectSceneLoaderWrapper _zenjectSceneLoaderWrapper;

        public SceneLoader(ZenjectSceneLoaderWrapper zenjectSceneLoaderWrapper)
        {
            _zenjectSceneLoaderWrapper = zenjectSceneLoaderWrapper;
        }

        public void Load(SceneID sceneID)
        {
            if(sceneID == SceneID.GameplayLevel)
                throw new ArgumentException($"{SceneID.GameplayLevel} не может быть загружен без конфигурации");

            _zenjectSceneLoaderWrapper.Load(null, (int)sceneID);
        }

        public void Load(LevelLoadingData loadingData)
        {
            _zenjectSceneLoaderWrapper.Load(container =>
            {
                container.BindInstances(loadingData);
            }, (int)SceneID.GameplayLevel);
        }
    }
}