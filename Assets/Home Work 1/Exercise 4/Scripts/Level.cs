using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HomeWork1.Exercise4
{
    public class Level : MonoBehaviour
    {
        [SerializeField] private UIManager _uiManager;

        private AllBurstCondition _allBurstCondition;
        private OneColorBurstCondition _oneColorBurstCondition;
        private List<Ball> _balls = new List<Ball>();

        void Awake()
        {
            _uiManager.Initialize();

            Initialize();
        }

        private void Initialize()
        {
            _balls = FindObjectsOfType<Ball>().ToList();

            _uiManager.StartOneColorBurstGameEvent += StartOneColorBurstGame;
            _uiManager.StartAllBurstGameButtonEvent += StartAllColorBurstGame;

            SetVisibleBalls(false);
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

            StartGame();
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
            

            StartGame();
        }

        private void Completed(bool isCompleted)
        {
            if (isCompleted == true)
                print("Победа");
            else
                print("Поражение");

            EndGame();
        }

        private void StartGame()
        {
            _uiManager.SetVisiblePanel(false);
            SetVisibleBalls(true);
        }

        private void EndGame()
        {
            _uiManager.SetVisiblePanel(true);
            SetVisibleBalls(false);
        }
    }
}
