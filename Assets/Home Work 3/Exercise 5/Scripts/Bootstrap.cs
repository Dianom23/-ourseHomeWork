using UnityEngine;

namespace HomeWork3.Exercise5
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Character _character;
        [SerializeField] private RaceType _race;
        [SerializeField] private ClassType _class;
        [SerializeField] private PassiveAbilityType _passiveAbility;


        private void Awake()
        {
            CharacterStats characterStats = new CharacterStats(5, 5, 5);
            IStatsProvider statsProvider = new BaseStatsProvider(characterStats);
            statsProvider = new RaceDecorator(statsProvider, _race);
            statsProvider = new ClassDecorator(statsProvider, _class);
            statsProvider = new PassiveAbilityDecorator(statsProvider, _passiveAbility);

            _character.Initialize(statsProvider.GetStats());
        }
    }
}