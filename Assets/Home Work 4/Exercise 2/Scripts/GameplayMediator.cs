using System;
using Zenject;

namespace HomeWork4.Exercise2
{
    public class GameplayMediator : IInitializable, IDisposable
    {
        private DefeatPanel _defeatPanel;
        private Level _level;

        public GameplayMediator(Level level, DefeatPanel defeatPanel)
        {
            _level = level;
            _defeatPanel = defeatPanel;
        }

        public void Initialize()
        {
            _level.Defeat += OnLevelDefeat;
            _defeatPanel.RestartClicked += RestartLevel;
        }

        public void Dispose() => _level.Defeat -= OnLevelDefeat;

        private void RestartLevel()
        {
            _defeatPanel.Hide();
            _level.Restart();
        }

        private void OnLevelDefeat() => _defeatPanel.Show();
    }
}