using UnityEngine;

namespace HomeWork3.Exercise5
{
    public class CharacterStats
    {
        public CharacterStats(int strength, int intelligence, int agility)
        {
            Strength = strength;
            Intelligence = intelligence;
            Agility = agility;
        }

        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }

        public void DisplayStats()
        {
            Debug.Log($"Strength: {Strength}, Intelligence: {Intelligence},Agility: {Agility}");
        }
    }
}