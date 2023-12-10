using System;

namespace HomeWork3.Exercise4
{
    public interface IEnemyDeathNotifier
    {
        event Action<Enemy> EnemyDeathNotified;
    }
}
