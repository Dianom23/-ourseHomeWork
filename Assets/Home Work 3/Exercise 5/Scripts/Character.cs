using UnityEngine;

namespace HomeWork3.Exercise5
{
    public class Character : MonoBehaviour
    {
        private CharacterStats _characterStats;

        public void Initialize(CharacterStats characterStats)
        {
            _characterStats = characterStats;

            _characterStats.DisplayStats();
        }
    }
}