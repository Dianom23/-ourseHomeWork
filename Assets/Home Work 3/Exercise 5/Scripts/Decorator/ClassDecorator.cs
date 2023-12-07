using System;

namespace HomeWork3.Exercise5
{
    public class ClassDecorator : IStatsProvider
    {
        private IStatsProvider _statsProvider;
        private ClassType _classType;

        public ClassDecorator(IStatsProvider statsProvider, ClassType classType)
        {
            _statsProvider = statsProvider;
            _classType = classType;
        }

        public CharacterStats GetStats()
        {
            CharacterStats characterStats = _statsProvider.GetStats();

            switch (_classType)
            {
                case ClassType.Mage:
                    characterStats.Intelligence *= 2;
                    break;
                case ClassType.Thief:
                    characterStats.Agility *= 2;
                    break;
                case ClassType.Barbarian:
                    characterStats.Strength *= 2;
                    break;
                default:
                    throw new ArgumentException(nameof(_classType));
            }

            return characterStats;
        }
    }
}