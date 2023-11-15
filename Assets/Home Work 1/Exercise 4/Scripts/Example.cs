using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace HomeWork1.Exercise4
{
    public class Example : MonoBehaviour
    {
        [SerializeField] private GameObject _uiPanel;
        [SerializeField] private Button _startOneColorBurstGameButton;
        [SerializeField] private Button _startAllBurstGameButton;
        [SerializeField] private ToggleGroup _toggleGroupColors;
        private Camera _camera;
        private Gun _gun;
        private IRulesGame _ruleGame;
        private List<Ball> _balls = new List<Ball>();
        private bool _isStartGame;

        void Awake()
        {
            _camera = Camera.main;
            _gun = new Gun(_camera);
            _balls = FindObjectsOfType<Ball>().ToList();
            _startAllBurstGameButton.onClick.AddListener(StartAllBurstGame);
            _startOneColorBurstGameButton.onClick.AddListener(StartOneColorBurstGame);
            _balls.ForEach(ball => ball.gameObject.SetActive(false));
        }

        private void OnDisable()
        {
            _startAllBurstGameButton.onClick.RemoveListener(StartAllBurstGame);
            _startOneColorBurstGameButton.onClick.RemoveListener(StartOneColorBurstGame);

            if (_ruleGame != null)
            {
                _ruleGame.WinGameEvent -= WinGame;
                _ruleGame.LoseGameEvent -= LoseGame;
            }
        }

        void Update()
        {
            if (_isStartGame == false) return;

            if (Input.GetMouseButton(0))
            {
                Ball ball = _gun.OnShoot();

                if (ball != null)
                    if (_ruleGame.TryBurstBall(ball) == true)
                        ball.gameObject.SetActive(false);
            }
        }

        private void StartOneColorBurstGame()
        {
            _ruleGame = new OneColorBurstPattern(_balls, GetSelectedToggleColor());
            StartGame();
        }

        private void StartAllBurstGame()
        {
            _ruleGame = new AllBurstPattern(_balls);
            StartGame();
        }

        private BallColor GetSelectedToggleColor()
        {
            if (_toggleGroupColors.ActiveToggles().First().TryGetComponent(out ToggleColors toggleColor))
            {
                return toggleColor.ToggleBallColor;
            }
            else throw new NullReferenceException(nameof(toggleColor));   
        }

        private void StartGame()
        {
            _isStartGame = true;
            _uiPanel.SetActive(false);
            _balls.ForEach(ball => ball.gameObject.SetActive(true));
            _ruleGame.WinGameEvent += WinGame;
            _ruleGame.LoseGameEvent += LoseGame;
        }

        private void LoseGame()
        {
            print("Проиграл");
            RestartGame();
        }

        private void WinGame()
        {
            print("Победил");
            RestartGame();
        }

        private void RestartGame()
        {
            _balls.ForEach(ball => ball.gameObject.SetActive(false));
            _isStartGame = false;
            _uiPanel.SetActive(true);
            _ruleGame.WinGameEvent -= WinGame;
            _ruleGame.LoseGameEvent -= LoseGame;
        }
    }
}
