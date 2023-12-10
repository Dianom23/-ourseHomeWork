using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

namespace HomeWork4.Exercise3
{
    public class Level : IInitializable
    {
        private AllBurstCondition _allBurstCondition;
        private OneColorBurstCondition _oneColorBurstCondition;
        private List<Ball> _balls = new List<Ball>();
        private LevelLoadingData _levelData;
        private ISceneLoadMediator _sceneLoader;

        public Level(LevelLoadingData levelData, ISceneLoadMediator sceneLoaded)
        {
            _levelData = levelData;
            _sceneLoader = sceneLoaded;
        }

        public void Initialize()
        {
            _balls = GameObject.FindObjectsOfType<Ball>().ToList();

            StartGame();
        }

        private void StartGame()
        {
            switch (_levelData.RuleType)
            {
                case RuleType.OneColor:
                    StartOneColorBurstGame(_levelData.BallColors);
                    break;
                case RuleType.AllColors:
                    StartAllColorBurstGame();
                    break;
            }
        }

        private void SetVisibleBalls(bool isVisible) => _balls.ForEach(ball => ball.gameObject.SetActive(isVisible));

        private void StartOneColorBurstGame(BallColors selectedColor)
        {
            if (_oneColorBurstCondition != null)
            {
                _oneColorBurstCondition.ClearingCondition();
                _oneColorBurstCondition.Completed -= Completed;
            }

            _oneColorBurstCondition = new OneColorBurstCondition(_balls, selectedColor);
            _oneColorBurstCondition.Completed += Completed;
        }

        private void StartAllColorBurstGame()
        {
            if (_allBurstCondition != null)
            {
                _allBurstCondition.ClearingCondition();
                _allBurstCondition.Completed -= Completed;
            }

            _allBurstCondition = new AllBurstCondition(_balls);
            _allBurstCondition.Completed += Completed;
        }

        private void Completed(bool isCompleted)
        {
            if (isCompleted == true)
                Debug.Log("Победа");
            else
                Debug.Log("Поражение");

            EndGame();
        }

        private void EndGame()
        {
            _sceneLoader.GoToLevelSelection();
        }
    }
}
