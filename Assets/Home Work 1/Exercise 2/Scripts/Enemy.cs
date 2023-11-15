using UnityEngine;

namespace HomeWork1.Exercise2
{
    public class Enemy : MonoBehaviour, IDamageable
    {
        public void GetDamage() => Destroy(gameObject);
    }
}
