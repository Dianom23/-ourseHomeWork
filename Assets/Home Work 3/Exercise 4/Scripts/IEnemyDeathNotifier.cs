using System;

namespace Assets.Visitor
{
    public interface IEnemyDeathNotifier
    {
        event Action<Enemy> EnemyDeathNotified;
    }
}
