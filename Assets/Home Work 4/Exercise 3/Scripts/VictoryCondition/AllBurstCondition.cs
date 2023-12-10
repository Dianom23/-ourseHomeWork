using System.Collections.Generic;

namespace HomeWork4.Exercise3
{
    public class AllBurstCondition : VictoryCondition
    {
        private List<Ball> _ballList;
        private int _counterBalls;

        public AllBurstCondition(List<Ball> ballList)
        {
            _ballList = ballList;

            Initialize();
        }

        public void ClearingCondition()
        {
            foreach (var ball in _ballList)
                ball.ClickToBallEvent -= HandleClickedBall;
        }

        protected override void CheckConditionToComplete()
        {
            if (_counterBalls == _ballList.Count)
                Completed?.Invoke(true);
        }

        private void Initialize()
        {
            foreach (var ball in _ballList)
                ball.ClickToBallEvent += HandleClickedBall;
        }

        private void HandleClickedBall(Ball ball)
        {
            _counterBalls++;

            CheckConditionToComplete();
        }
    }
}
