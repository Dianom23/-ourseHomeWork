using UnityEngine;

namespace HomeWork4.Exercise1
{
    public interface IEnemyTarget : IDamagable
    {
        Vector3 Position { get; }
    }
}