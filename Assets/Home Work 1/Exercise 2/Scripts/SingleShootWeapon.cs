using UnityEngine;

namespace HomeWork1.Exercise2
{
    public class SingleShootWeapon : Weapon
    {
        private int _countAmmo;
        private Transform _shootPoint;
        private float _shootRange;
        public SingleShootWeapon(int countAmmo, Transform shootPoint, float shootRange)
        {
            _countAmmo = countAmmo;
            _shootPoint = shootPoint;
            _shootRange = shootRange;
        }

        public override void Shoot()
        {
            if (_countAmmo <= 0)
            {
                Debug.Log($"Для одиночного выстрела нехватает патронов");
                return;
            }

            _countAmmo--;
            SingleShoot(_shootPoint, _shootRange);
            Debug.Log($"Одиночный выстрел, осталось {_countAmmo} патронов");
        }
    }
}
