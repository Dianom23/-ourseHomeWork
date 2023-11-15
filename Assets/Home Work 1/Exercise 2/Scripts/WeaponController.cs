using System.Collections.Generic;
using UnityEngine;

namespace HomeWork1.Exercise2
{
    public class WeaponController : MonoBehaviour
    {
        [SerializeField] private float _shootRange = 20;
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private int _currentWeaponIndex;
        private List<Weapon> _weaponList = new List<Weapon>();

        void Awake()
        {
            _weaponList.Add(new SingleShootWeapon(50, _shootPoint, _shootRange));
            _weaponList.Add(new SingleInfiniteShootWeapon(_shootPoint, _shootRange));
            _weaponList.Add(new TripleShootWeapon(50, _shootPoint, _shootRange, 15));
        }

        void Update()
        {
            CheckWeaponSwitch();

            if (Input.GetMouseButtonDown(0))
                _weaponList[_currentWeaponIndex].Shoot();
        }

        private void CheckWeaponSwitch()
        {
            switch (Input.mouseScrollDelta.y)
            {
                case -1:
                    _currentWeaponIndex = (_currentWeaponIndex == _weaponList.Count - 1) ? 0 : _currentWeaponIndex + 1;
                    break;
                case 1:
                    _currentWeaponIndex = (_currentWeaponIndex == 0) ? _weaponList.Count - 1 : _currentWeaponIndex - 1;
                    break;
            }
        }
    }
}