using UnityEngine;

namespace HomeWork1.Exercise2
{
    public abstract class Weapon : IWeapon
    {
        public abstract void Shoot();

        protected virtual void SingleShoot(Transform shootPoint, float shootRange)
        {
            Ray ray = new Ray(shootPoint.position, shootPoint.forward);
        
            if (Physics.Raycast(ray, out RaycastHit hit, shootRange))
                if (hit.collider.TryGetComponent(out IDamageable damageable))
                    damageable.GetDamage();

            Debug.DrawRay(shootPoint.position, shootPoint.forward * shootRange, Color.red, 0.1f);
        }
    }
}
