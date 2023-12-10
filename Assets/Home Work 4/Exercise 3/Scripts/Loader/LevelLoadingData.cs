namespace HomeWork4.Exercise3
{
    public class LevelLoadingData
    {
        private RuleType _ruleType;
        private BallColors _ballColors;
        public RuleType RuleType => _ruleType;
        public BallColors BallColors => _ballColors;

        public LevelLoadingData(RuleType ruleType , BallColors ballColors)
        {
            _ruleType = ruleType;
            _ballColors = ballColors;
        }
    }
}