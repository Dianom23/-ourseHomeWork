using Assets.Visitor;
using System;

public interface IEnemyCreateNotifier
{
    event Action<Enemy> CreateEnemyNotified;
}
