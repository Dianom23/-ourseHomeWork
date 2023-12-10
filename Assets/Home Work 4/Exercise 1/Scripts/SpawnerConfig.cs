using UnityEngine;

namespace HomeWork4.Exercise1
{
    [CreateAssetMenu(fileName = "SpawnerConfig", menuName = "SpawnerConfig/Config")]
    public class SpawnerConfig : ScriptableObject
    {
        [SerializeField] private float _spawnCooldown;

        public float SpawnCooldown => _spawnCooldown;
    }
}