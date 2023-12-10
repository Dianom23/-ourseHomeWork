using System;

namespace HomeWork3.Exercise4
{
    public interface IEnemyCreateNotifier
    {
        event Action<Enemy> CreateEnemyNotified;
    }
}