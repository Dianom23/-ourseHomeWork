using UnityEngine;

namespace HomeWork3.Exercise4
{
    public class EnemiesWeight
    {
        private IEnemyCreateNotifier _enemyCreateNotifier;
        private EnemyVisitor _enemyVisitor;

        public EnemiesWeight(IEnemyCreateNotifier enemyCreateNotifier)
        {
            _enemyCreateNotifier = enemyCreateNotifier;
            _enemyCreateNotifier.CreateEnemyNotified += OnCreatedEnemy;

            _enemyVisitor = new EnemyVisitor();
        }

        ~EnemiesWeight() => _enemyCreateNotifier.CreateEnemyNotified -= OnCreatedEnemy;

        public int Value => _enemyVisitor.Weight;

        private void OnCreatedEnemy(Enemy enemy)
        {
            _enemyVisitor.Visit(enemy);
            Debug.Log($"Вес: {Value}");
        }

        private class EnemyVisitor : IEnemyVisitor
        {
            public int Weight { get; private set; }

            public void Visit(Ork ork) => Weight += 3;

            public void Visit(Human human) => Weight += 2;

            public void Visit(Elf elf) => Weight += 1;

            public void Visit(Enemy enemy) => Visit((dynamic)enemy);
        }
    }
}