using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork1.Exercise4
{
    public class OneColorBurstPattern : IRulesGame
    {
        public event Action LoseGameEvent;
        public event Action WinGameEvent;

        private int _counterBalls;
        private int _allBalls;
        private BallColor _ballColor;

        public OneColorBurstPattern(IEnumerable<Ball> balls, BallColor ballColor)
        {
            _ballColor = ballColor;
            _allBalls = balls.Count(ball => ball.Color == ballColor);
        }

        public void CheckWin()
        {
            if (_counterBalls == _allBalls)
                WinGameEvent?.Invoke();
        }

        public bool TryBurstBall(Ball ball)
        {
            if (ball.Color == _ballColor)
            {
                _counterBalls++;
                CheckWin();
                return true;
            }
            else
            {
                LoseGameEvent?.Invoke();
                return false;
            }
        }
    }
}
