using UnityEngine;

namespace HomeWork1.Exercise2
{
    public class TripleShootWeapon : Weapon
    {
        private int _countAmmo;
        private Transform _shootPoint;
        private float _shootRange;
        private float _deflectionAngle;

        public TripleShootWeapon(int countAmmo, Transform shootPoint, float shootRange, float deflectionAngle)
        {
            _countAmmo = countAmmo;
            _shootPoint = shootPoint;
            _shootRange = shootRange;
            _deflectionAngle = deflectionAngle;
        }

        public override void Shoot()
        {
            if (_countAmmo < 3)
            {
                Debug.Log($"Для тройного выстрела нехватает патронов");
                return;
            }

            _countAmmo -= 3;

            for (int i = -1; i <= 1; i++)
            {
                _shootPoint.rotation = Quaternion.Euler(0, _deflectionAngle * i, 0);
                SingleShoot(_shootPoint, _shootRange);
            }
            _shootPoint.rotation = Quaternion.Euler(Vector3.zero);
        
            Debug.Log($"Тройной выстрел, осталось {_countAmmo} патронов");
        }
    }
}
