using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork1.Exercise4
{
    public class AllBurstPattern : IRulesGame
    {
        public event Action LoseGameEvent;
        public event Action WinGameEvent;

        private int _counterBalls;
        private int _allBalls;

        public AllBurstPattern(IEnumerable<Ball> balls) => _allBalls = balls.Count();


        public void CheckWin()
        {
            if (_counterBalls == _allBalls)
                WinGameEvent?.Invoke();
        }

        public bool TryBurstBall(Ball ball)
        {
            _counterBalls++;
            CheckWin();
            return true;
        }
    }
}
