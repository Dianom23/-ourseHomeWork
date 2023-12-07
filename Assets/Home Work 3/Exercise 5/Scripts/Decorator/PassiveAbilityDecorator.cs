using System;

namespace HomeWork3.Exercise5
{
    public class PassiveAbilityDecorator : IStatsProvider
    {
        private IStatsProvider _statsProvider;
        private PassiveAbilityType _passiveAbility;

        public PassiveAbilityDecorator(IStatsProvider statsProvider, PassiveAbilityType passiveAbility)
        {
            _statsProvider = statsProvider;
            _passiveAbility = passiveAbility;
        }

        public CharacterStats GetStats()
        {
            CharacterStats characterStats = _statsProvider.GetStats();

            switch (_passiveAbility)
            {
                case PassiveAbilityType.StrengthBoost:
                    characterStats.Strength += 3;
                    break;
                case PassiveAbilityType.AgilityBoots:
                    characterStats.Agility += 3;
                    break;
                case PassiveAbilityType.IntelligenceBoots:
                    characterStats.Intelligence += 3;
                    break;
                default:
                    throw new ArgumentException(nameof(_passiveAbility));
            }

            return characterStats;
        }
    }
}