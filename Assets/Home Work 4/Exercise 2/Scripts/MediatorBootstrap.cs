using System;
using Zenject;

namespace HomeWork4.Exercise2
{
    public class MediatorBootstrap : IInitializable, IDisposable
    {
        private Level _level;
        private IInput _input;

        public MediatorBootstrap(IInput input, Level level)
        {
            _input = input;
            _level = level;
        }
        public void Initialize()
        {
            _input.Defeat += _level.OnDefeat;
            _level.Start();
        }

        public void Dispose() => _input.Defeat -= _level.OnDefeat;
    }
}