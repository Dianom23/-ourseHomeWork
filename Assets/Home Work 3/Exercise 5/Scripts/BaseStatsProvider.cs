namespace HomeWork3.Exercise5
{
    public class BaseStatsProvider : IStatsProvider
    {
        private CharacterStats _characterStats;

        public BaseStatsProvider(CharacterStats characterStats)
        {
            _characterStats = characterStats;
        }

        public CharacterStats GetStats()
        {
            return _characterStats;
        }
    }
}