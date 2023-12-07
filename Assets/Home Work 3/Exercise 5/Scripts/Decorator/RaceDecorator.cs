using System;

namespace HomeWork3.Exercise5
{
    public class RaceDecorator : IStatsProvider
    {
        private IStatsProvider _statsProvider;
        private RaceType _raceType;

        public RaceDecorator(IStatsProvider statsProvider, RaceType raceType)
        {
            _statsProvider = statsProvider;
            _raceType = raceType;
        }

        public CharacterStats GetStats()
        {
            CharacterStats characterStats = _statsProvider.GetStats();

            switch (_raceType)
            {
                case RaceType.Human:
                    characterStats.Intelligence += 2;
                    break;
                case RaceType.Elf:
                    characterStats.Agility += 2;
                    break;
                case RaceType.Ork:
                    characterStats.Strength += 2;
                    break;
                default:
                    throw new ArgumentException(nameof(_raceType));
            }

            return characterStats;
        }
    }
}