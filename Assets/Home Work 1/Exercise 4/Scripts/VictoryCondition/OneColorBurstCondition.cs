using System.Collections.Generic;
using System.Linq;

namespace HomeWork1.Exercise4
{
    public class OneColorBurstCondition : VictoryCondition
    {
        private IEnumerable<Ball> _ballList;
        private int _counterBalls;
        private int _countBallsWithSelectedColor;
        private BallColors _selectedBallColor;

        public OneColorBurstCondition(List<Ball> ballList, BallColors ballColor)
        {
            _ballList = ballList;
            _selectedBallColor = ballColor;

            Initialize();
        }

        public void ClearingCondition()
        {
            foreach (var ball in _ballList)
                ball.ClickToBallEvent -= HandleClickedBall;
        }

        protected override void CheckConditionToComplete()
        {
            if (_counterBalls == _countBallsWithSelectedColor)
                Completed?.Invoke(true);
        }

        private void Initialize()
        {
            foreach (var ball in _ballList)
                ball.ClickToBallEvent += HandleClickedBall;

            _countBallsWithSelectedColor = _ballList.Where(ball => ball.Color == _selectedBallColor).Count();
        }

        private void HandleClickedBall(Ball burstedBall)
        {
            if (burstedBall.Color == _selectedBallColor)
                _counterBalls++;
            else
            {
                Completed?.Invoke(false);
                return;
            }

            CheckConditionToComplete();
        }
    }
}
