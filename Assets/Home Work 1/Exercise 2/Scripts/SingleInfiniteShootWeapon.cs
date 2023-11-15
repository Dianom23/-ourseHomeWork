using UnityEngine;

namespace HomeWork1.Exercise2
{
    public class SingleInfiniteShootWeapon : Weapon
    {
        private Transform _shootPoint;
        private float _shootRange;

        public SingleInfiniteShootWeapon(Transform shootPoint, float shootRange)
        { 
            _shootPoint = shootPoint;
            _shootRange = shootRange;
        }

        public override void Shoot()
        {
            SingleShoot(_shootPoint, _shootRange);
            Debug.Log($"Одиночный выстрел из бесконечной пушки");
        }
    }
}
